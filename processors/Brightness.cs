using System.Drawing;

namespace Image0.processors {
  class Brightness : IImageProcessor {
    public string Name => "明るさ";

    public string Postfix => "_brightness";

    public Bitmap Process(Bitmap bmp, double parameter) => bmp.MapPixels(
      (c) => c.WithBrightness((int)parameter)
    );
  }
}
