using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Image0.processors {
  class Denoise : IImageProcessor {
    public string Name => "ノイズ除去";

    public string Postfix => "_denoise";

    public Bitmap Process(Bitmap bmp, double p) {
      var cloned = new Bitmap(bmp);
      for (int y = 1; y < cloned.Height - 1; ++y) {
        for (int x = 1; x < cloned.Width - 1; ++x) {
          var pxOriginal = bmp.GetPixel(x, y);
          var aroundPixels = new List<Color>(9);
          for (int v = 0; v < 3; ++v) {
            for (int u = 0; u < 3; ++u) {
              aroundPixels.Add(bmp.GetPixel(x + u - 1, y + v - 1));
            }
          }
          var R = aroundPixels.Select(c => c.R).ToList().Median().SaturateAdd(0);
          var G = aroundPixels.Select(c => c.G).ToList().Median().SaturateAdd(0);
          var B = aroundPixels.Select(c => c.B).ToList().Median().SaturateAdd(0);
          cloned.SetPixel(
            x,
            y,
            Color.FromArgb(pxOriginal.A, R, G, B)
          );
        }
      }
      return cloned;
    }
  }
}
