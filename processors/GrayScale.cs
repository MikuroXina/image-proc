using System.Drawing;

namespace Image0.processors {
  class GrayScale : IImageProcessor {
    public string Name { get => "白黒化"; }
    public string Postfix { get => "_grayed"; }

    public Bitmap Process(Bitmap bmp, double _) => bmp.MapPixels((c) => {
      var gray = (c.R + c.G + c.B) / 3;
      return Color.FromArgb(gray, gray, gray);
    });
  }
}
