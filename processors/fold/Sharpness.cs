using System.Drawing;

namespace Image0.processors.fold {

  class Sharpness : IImageProcessor {
    public string Name => "先鋭化";

    public string Postfix => "_sharpness";

    public Bitmap Process(Bitmap bmp, double p) => bmp.FoldPixels(new double[3, 3]{
      {0, 1, 0,},
      {1, -3, 1},
      {0, 1, 0,},
    });
  }
}
