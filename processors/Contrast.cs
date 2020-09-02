using System.Drawing;

namespace Image0.processors {
  class Contrast : IImageProcessor {
    public string Name => "コントラスト";

    public string Postfix => "_contrast";

    public Bitmap Process(Bitmap bmp, double p) => bmp.MapPixels((c) => {
      byte R = (c.R * p).Clamp(), G = (c.G * p).Clamp(), B = (c.B * p).Clamp();
      return Color.FromArgb(c.A, R, G, B);
    });
  }
}
