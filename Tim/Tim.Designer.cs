using System.Windows.Forms;

namespace Tim
{
  partial class Tim
  {
    private System.ComponentModel.IContainer components = null;
    private Button btnExit;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) components.Dispose();
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tim));
      this.btnExit = new System.Windows.Forms.Button();
      this.tbHour = new System.Windows.Forms.TextBox();
      this.tbMinute = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnExit
      // 
      this.btnExit.BackColor = System.Drawing.Color.Black;
      this.btnExit.FlatAppearance.BorderSize = 0;
      this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExit.ForeColor = System.Drawing.Color.White;
      this.btnExit.Location = new System.Drawing.Point(14, 27);
      this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(55, 20);
      this.btnExit.TabIndex = 2;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = false;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // tbHour
      // 
      this.tbHour.BackColor = System.Drawing.Color.Black;
      this.tbHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbHour.ForeColor = System.Drawing.Color.White;
      this.tbHour.Location = new System.Drawing.Point(14, 4);
      this.tbHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tbHour.Multiline = true;
      this.tbHour.Name = "tbHour";
      this.tbHour.Size = new System.Drawing.Size(26, 20);
      this.tbHour.TabIndex = 3;
      this.tbHour.Text = "15";
      this.tbHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbHour.TextChanged += new System.EventHandler(this.SetTime);
      // 
      // tbMinute
      // 
      this.tbMinute.BackColor = System.Drawing.Color.Black;
      this.tbMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbMinute.ForeColor = System.Drawing.Color.White;
      this.tbMinute.Location = new System.Drawing.Point(43, 4);
      this.tbMinute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tbMinute.Multiline = true;
      this.tbMinute.Name = "tbMinute";
      this.tbMinute.Size = new System.Drawing.Size(26, 20);
      this.tbMinute.TabIndex = 4;
      this.tbMinute.Text = "00";
      this.tbMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbMinute.TextChanged += new System.EventHandler(this.SetTime);
      // 
      // Tim
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(213, 212);
      this.Controls.Add(this.tbMinute);
      this.Controls.Add(this.tbHour);
      this.Controls.Add(this.btnExit);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Tim";
      this.Opacity = 0.75D;
      this.ShowInTaskbar = false;
      this.Text = "Tim";
      this.TopMost = true;
      this.MouseEnter += new System.EventHandler(this.Tim_MouseEnter);
      this.MouseLeave += new System.EventHandler(this.Tim_MouseLeave);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox tbHour;
    private TextBox tbMinute;
  }
}