using System.Drawing;

namespace Image0.processors.transform {
  class HorizontalMirror : IImageProcessor {
    public string Name => "左右反転";

    public string Postfix => "_horizontalMirror";

    public Bitmap Process(Bitmap bmp, double p) => bmp.MapPixels((x, y) => (u:bmp.Width - 1 - x, v: y));
  }
}
