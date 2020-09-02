using System.Drawing;

namespace Image0.processors.transform {
  class Triangulation : IImageProcessor {
    public string Name => "三角形化";

    public string Postfix => "_triangulation";

    public Bitmap Process(Bitmap bmp, double p) => bmp.MapPixels((x, y) => 
      (u: (int)(1.0 * x * y / (bmp.Height - 1)), v: y)
    );
  }
}
