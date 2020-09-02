using System.Drawing;

namespace Image0.processors {
  class HueRotate : IImageProcessor {
    public string Name => "色相変換";

    public string Postfix => "_hueRotate";

    public Bitmap Process(Bitmap bmp, double p) => bmp.MapPixels(c => 
      BitmapExtension.FromAhsl(c.A, c.GetHue() + p, c.GetSaturation(), c.GetBrightness())
    );
  }
}
