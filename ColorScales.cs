using System.Drawing;

namespace Image0 {
  public class ColorScales {
    public readonly int[] R, G, B, Gray;
    public int[][] Components => new int[][] { R, G, B, Gray };

    public ColorScales(Bitmap bmp) {
      const int level = 256;
      R = new int[level];
      G = new int[level];
      B = new int[level];
      Gray = new int[level];


      for (int x = 0; x < bmp.Width; x++) {
        for (int y = 0; y < bmp.Height; y++) {
          var c = bmp.GetPixel(x, y);
          R[c.R]++;
          G[c.G]++;
          B[c.B]++;
          var gray = (c.R + c.G + c.B) / 3;
          Gray[gray]++;
        }
      }
    }
  }
}
