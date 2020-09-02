using System;
using System.Drawing;
using System.Linq;

namespace Image0.processors {
  class Gamma : IImageProcessor {
    public string Name => "γ補正";

    public string Postfix => "_gamma";

    public Bitmap Process(Bitmap bmp, double p) => bmp.MapPixels((c) => {
      byte[] comps = { c.R, c.G, c.B };
      var processed = comps.Select(comp =>
        (byte.MaxValue * Math.Pow(1.0 * comp / byte.MaxValue, 1 / p)).Clamp()
      ).ToArray();
      return Color.FromArgb(c.A, processed[0], processed[1], processed[2]);
    });
  }
}
