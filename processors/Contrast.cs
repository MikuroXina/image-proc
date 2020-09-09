using System.Drawing;

namespace Image0.processors {
  class Contrast : IImageProcessor {
    public string Name => "コントラスト";

    public string Postfix => "_contrast";

    public Bitmap Process(Bitmap bmp, double p) => bmp.MapPixels((c) => {
      byte R = (c.R * p).SaturateAdd(0), G = (c.G * p).SaturateAdd(0), B = (c.B * p).SaturateAdd(0);
      return Color.FromArgb(c.A, R, G, B);
    });
  }
}
