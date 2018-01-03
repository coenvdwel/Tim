using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tim
{
  public partial class Tim : Form
  {
    // const settings
    private const int CollapsedWidth = 4;
    private const int HoverWidth = 12;
    private const int FullWidth = 80;
    private const int RefreshRate = 400;

    // private data
    private bool _collapsed;
    private Rectangle _workingArea;
    private DateTime? _time;
    private readonly Timer _timer = new Timer {Interval = RefreshRate };

    public Tim()
    {
      InitializeComponent();

      // initialize with current hour and minute
      tbHour.Text = DateTime.Now.ToString("HH");
      tbMinute.Text = DateTime.Now.ToString("mm");

      // save current display
      _workingArea = Screen.FromPoint(Location).WorkingArea;

      // start event handling
      Shown += OnShown;
      Click += OnClick;
      _timer.Tick += OnTick;
    }

    // helper methods
    public void SetHeight(int? h = null)
    {
      Top = _workingArea.Bottom - (Height = h ?? _workingArea.Height);
    }

    public void Collapse(bool collapse = true)
    {
      _collapsed = collapse;
      Left = _workingArea.Right - (Width = _collapsed ? CollapsedWidth : FullWidth);
      Refresh();
    }

    private static int Sanitize(Control tb, int max)
    {
      int n;
      var text = Regex.Replace(tb.Text.Trim(), @"[^\d]", "");
      if (!int.TryParse(text, out n)) n = 0;

      n = Math.Max(0, Math.Min(n, max));

      if (tb.Text != text) tb.Text = n.ToString();
      return n;
    }

    // event handlers
    public void OnShown(object sender, EventArgs args)
    {
      Collapse();
      _timer.Start();
    }

    public void OnTick(object sender, EventArgs args)
    {
      if (!_time.HasValue)
      {
        BackColor = BackColor == Color.Black ? Color.Red : Color.Black;
        return;
      }

      if (DateTime.Now >= _time.Value)
      {
        _time = null;
        SetHeight();
        return;
      }

      const double b = 3600;
      double h = 0d, d = _workingArea.Height/2d, x = (_time.Value - DateTime.Now).TotalSeconds, r = x;
      while (r >= b)
      {
        r -= b;
        h += d;
        d /= 2;
      }

      BackColor = BackColor == Color.Black || x > 600 ? Utility.Color.Get(Math.Min(x/60, 120), 1, 1) : Color.Black;
      SetHeight(Math.Max(_workingArea.Height - (int) (h + d/b*r), _collapsed ? 22 : 60));
    }

    public void OnClick(object sender, EventArgs args)
    {
      Collapse(!_collapsed);
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void SetTime(object sender, EventArgs e)
    {
      var h = Sanitize(tbHour, 23);
      var m = Sanitize(tbMinute, 59);

      _time = DateTime.Today.AddHours(h).AddMinutes(m);
    }

    private void Tim_MouseEnter(object sender, EventArgs e)
    {
      if (!_collapsed) return;

      Left = _workingArea.Right - (Width = HoverWidth);
      Refresh();
    }

    private void Tim_MouseLeave(object sender, EventArgs e)
    {
      if (!_collapsed) return;

      Left = _workingArea.Right - (Width = CollapsedWidth);
      Refresh();
    }
  }
}