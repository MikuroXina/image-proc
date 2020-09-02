using System;
using System.Drawing;

namespace Image0.processors.transform {
  class ForwardRotate : IImageProcessor {
    public string Name => "回転 (フォワード)";

    public string Postfix => "_rotateForward";

    public Bitmap Process(Bitmap bmp, double p) => bmp.MapPixels((x, y) =>
      (
        u: (int)(x * Math.Cos(p.DegToRad()) - y * Math.Sin(p.DegToRad())),
        v: (int)(x * Math.Sin(p.DegToRad()) + y * Math.Cos(p.DegToRad()))
      )
    );
  }
  class BackwardRotate : IImageProcessor {
    public string Name => "回転 (バックワード)";

    public string Postfix => "_rotateBackward";

    public Bitmap Process(Bitmap bmp, double p) {
      Bitmap cloned = new Bitmap(bmp.Width, bmp.Height);
      for (int y = 0; y < bmp.Height; ++y) {
        for (int x = 0; x < bmp.Width; ++x) {
          var u = (int)(x * Math.Cos(p.DegToRad()) + y * Math.Sin(p.DegToRad()));
          var v = (int)(-x * Math.Sin(p.DegToRad()) + y * Math.Cos(p.DegToRad()));
          if (0 <= u && u < bmp.Width && 0 <= v && v < bmp.Height)
            cloned.SetPixel(x, y, bmp.GetPixel(u, v));
        }
      }
      return cloned;
    }
  }
}
