using System.Drawing;

namespace Image0.processors.fold {
  class RightEdge : IImageProcessor {
    public string Name => "右方向エッジ";

    public string Postfix => "_rightEdge";

    public Bitmap Process(Bitmap bmp, double p) => bmp.FoldPixels(new double[3, 3]{
      {0, 0, 0,},
      {0, -1, 1,},
      {0, 0, 0,},
    });
  }

  class LeftEdge : IImageProcessor {
    public string Name => "左方向エッジ";

    public string Postfix => "_leftEdge";

    public Bitmap Process(Bitmap bmp, double p) => bmp.FoldPixels(new double[3, 3]{
      {0, 0, 0,},
      {1, -1, 0,},
      {0, 0, 0,},
    });
  }

  class LeftRightEdge : IImageProcessor {
    public string Name => "左右方向エッジ";

    public string Postfix => "_leftRightEdge";

    public Bitmap Process(Bitmap bmp, double p) => bmp.FoldPixels(new double[3, 3]{
      {0, 0, 0,},
      {1, -2, 1,},
      {0, 0, 0,},
    });
  }

  class Laplacian : IImageProcessor {
    public string Name => "ラプラシアン";

    public string Postfix => "_laplacian";

    public Bitmap Process(Bitmap bmp, double p) => bmp.FoldPixels(new double[3, 3]{
      {0, 1, 0,},
      {1, -4, 1,},
      {0, 1, 0,},
    });
  }
}
