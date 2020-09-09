using System;
using System.Collections.Generic;
using System.Drawing;

namespace Image0.processors {
  internal static class BitmapExtension {
    public static byte SaturateAdd(this double a, double b) {
      if (0 < a && byte.MaxValue - a <= b) {
        return byte.MaxValue;
      }
      if (a < 0 && byte.MinValue - b <= a) {
        return byte.MinValue;
      }
      return Math.Min(Math.Max((byte)Math.Round(a + b), byte.MinValue), byte.MaxValue);
    }

    public static double DegToRad(this double value) => value / 180 * Math.PI;

    public static Bitmap MapPixels(this Bitmap bmp, Func<Color, Color> mapper) {
      Bitmap cloned = new Bitmap(bmp.Width, bmp.Height);
      for (int y = 0; y < cloned.Height; ++y) {
        for (int x = 0; x < cloned.Width; ++x) {
          cloned.SetPixel(x, y, mapper(bmp.GetPixel(x, y)));
        }
      }
      return cloned;
    }

    public static Bitmap MapPixels(this Bitmap bmp, Func<int, int, (int u, int v)> mapper) {
      Bitmap cloned = new Bitmap(bmp.Width, bmp.Height);
      for (int y = 0; y < cloned.Height; ++y) {
        for (int x = 0; x < cloned.Width; ++x) {
          var (u, v) = mapper(x, y);
          if (0 <= u && u < bmp.Width && 0 <= v && v < bmp.Height)
            cloned.SetPixel(u, v, bmp.GetPixel(x, y));
        }
      }
      return cloned;
    }

    public static Bitmap FoldPixels(this Bitmap bmp, double[,] filter) {
      Bitmap cloned = new Bitmap(bmp.Width, bmp.Height);
      for (int y = 1; y < cloned.Height - 1; ++y) {
        for (int x = 1; x < cloned.Width - 1; ++x) {
          var pxOriginal = bmp.GetPixel(x, y);
          double[] comps = { 0, 0, 0 };
          for (int v = 0; v < 3; ++v) {
            for (int u = 0; u < 3; ++u) {
              var coefficient = filter[u, v];
              var pxFilter = bmp.GetPixel(x + u - 1, y + v - 1).MultiplyRGB(coefficient);
              comps[0] += pxFilter[0];
              comps[1] += pxFilter[1];
              comps[2] += pxFilter[2];
            }
          }
          cloned.SetPixel(
            x,
            y,
            Color.FromArgb(pxOriginal.A, comps[0].SaturateAdd(0), comps[1].SaturateAdd(0), comps[2].SaturateAdd(0))
          );
        }
      }
      return cloned;
    }

    public static Color WithBrightness(this Color c, int brightness) {
      var R = SaturateAdd(c.R, brightness);
      var G = SaturateAdd(c.G, brightness);
      var B = SaturateAdd(c.B, brightness);
      return Color.FromArgb(c.A, R, G, B);
    }

    public static double[] MultiplyRGB(this Color c, double a) => new double[] {
      c.R * a, c.G * a, c.B * a,
    };

    public static List<T> Sorted<T>(this List<T> arr) {
      var cloned = new List<T>(arr);
      cloned.Sort();
      return cloned;
    }

    public static double Median(this List<byte> arr) {
      if (arr == null || arr.Count == 0) throw new ArgumentException("the list must have one or more elements");
      var sorted = arr.Sorted();
      if (arr.Count % 2 == 0) {
        return (sorted[arr.Count / 2] + sorted[arr.Count / 2 + 1]) / 2.0;
      }
      return sorted[arr.Count / 2];
    }

    // Source: https://en.wikipedia.org/wiki/HSL_and_HSV#HSL_to_RGB_alternative
    public static Color FromAhsl(byte alpha, double hue, double saturation, double luminance) {
      if (double.IsNaN(hue) || double.IsInfinity(hue))
        throw new ArgumentOutOfRangeException(nameof(hue), hue, "hue must be in real number");
      if (!(0 <= saturation && saturation <= 1))
        throw new ArgumentOutOfRangeException(nameof(saturation), saturation, "saturation must be in [0, 1]");
      if (!(0 <= luminance && luminance <= 1))
        throw new ArgumentOutOfRangeException(nameof(luminance), luminance, "luminance must be in [0, 1]");

      while (hue < 0) hue += 360;
      while (360 < hue) hue -= 360;

      byte Component(byte n) {
        var a = saturation * Math.Min(luminance, 1 - luminance);
        var k = (n + hue / 30f) % 12;
        var normalizedColor = luminance - a * Math.Max(Math.Min(Math.Min(k - 3, 9 - k), 1), -1);
        return (normalizedColor * byte.MaxValue).SaturateAdd(0);
      }

      return Color.FromArgb(alpha, Component(0), Component(8), Component(4));
    }
  }
}
