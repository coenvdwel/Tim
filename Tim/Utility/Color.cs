﻿using System;

namespace Tim.Utility
{
  public static class Color
  {
    public static System.Drawing.Color Get(double hue, double saturation, double value)
    {
      var hi = Convert.ToInt32(Math.Floor(hue/60))%6;
      var f = hue/60 - Math.Floor(hue/60);

      value = value*255;

      var v = Convert.ToInt32(value);
      var p = Convert.ToInt32(value*(1 - saturation));
      var q = Convert.ToInt32(value*(1 - f*saturation));
      var t = Convert.ToInt32(value*(1 - (1 - f)*saturation));

      switch (hi)
      {
        case 0:
          return System.Drawing.Color.FromArgb(255, v, t, p);
        case 1:
          return System.Drawing.Color.FromArgb(255, q, v, p);
        case 2:
          return System.Drawing.Color.FromArgb(255, p, v, t);
        case 3:
          return System.Drawing.Color.FromArgb(255, p, q, v);
        case 4:
          return System.Drawing.Color.FromArgb(255, t, p, v);
        default:
          return System.Drawing.Color.FromArgb(255, v, p, q);
      }
    }
  }
}