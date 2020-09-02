using System.Drawing;

namespace Image0.processors.fold {

  class Identity : IImageProcessor {
    public string Name => "恒等変換";

    public string Postfix => "_identity";

    public Bitmap Process(Bitmap bmp, double p) => bmp.FoldPixels(new double[3, 3]{
      {0, 0, 0,},
      {0, 1, 0,},
      {0, 0, 0,},
    });
  }

  class LeftRightSmooth : IImageProcessor {
    public string Name => "左右平滑化";

    public string Postfix => "_leftRightSmooth";

    public Bitmap Process(Bitmap bmp, double p) => bmp.FoldPixels(new double[3, 3]{
      {0, 0, 0,},
      {1.0 / 3, 1.0 / 3, 1.0 / 3,},
      {0, 0, 0,},
    });
  }

  class Smooth : IImageProcessor {
    public string Name => "平滑化";

    public string Postfix => "_smooth";

    public Bitmap Process(Bitmap bmp, double p) => bmp.FoldPixels(new double[3, 3]{
      {1.0 / 9, 1.0 / 9, 1.0 / 9,},
      {1.0 / 9, 1.0 / 9, 1.0 / 9,},
      {1.0 / 9, 1.0 / 9, 1.0 / 9,},
    });
  }
}
