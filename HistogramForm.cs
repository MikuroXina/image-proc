using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Image0 {
  public partial class HistogramForm : Form {
    public HistogramForm(Bitmap bmp) {
      original = bmp;
      scales = new ColorScales(bmp);

      InitializeComponent();

      colorSwitches = new ColorSwitch[] { colorSwitch1, colorSwitch2, colorSwitch3, colorSwitch4 };
      foreach (var colorSwitch in colorSwitches) {
        colorSwitch.CheckedChanged += OnChangeStep;
      }
      DrawHistograms();
    }

    readonly Bitmap original;
    readonly ColorScales scales;
    readonly ColorSwitch[] colorSwitches;

    public void DrawHistograms() {
      var img = new Bitmap(original.Width, original.Height);
      var g = Graphics.FromImage(img);
      g.Clear(Color.White);

      var histograms = scales.Components;
      for (int i = 0; i < colorSwitches.Length; ++i) {
        if (colorSwitches[i].Checked) {
          DrawHistogram(histograms[i], colorSwitches[i].SwitchColor, g);
        }
      }
      canvas.Image = img;
    }

    private void DrawHistogram(int[] histogram, Color color, Graphics g) {
      var pen = new Pen(color);

      var x = 0f;
      var barWidth = 1.0f * canvas.Width / histogram.Length;
      foreach (var bar in histogram) {
        var barHeight = bar * canvas.Height / (float)step.Value;
        g.DrawRectangle(pen, x, canvas.Height - barHeight, barWidth, barHeight);
        x += barWidth;
      }
    }

    private void OnClickSaveAsCSV(object sender, EventArgs e) {
      var histograms = scales.Components;

      var dialog = new SaveFileDialog();
      dialog.FileOk += NewMethod(histograms);
      dialog.ShowDialog();
    }

    private static CancelEventHandler NewMethod(int[][] histograms) => (dialogWithOk, okEvent) => {
      using (var writer = new StreamWriter((dialogWithOk as SaveFileDialog).FileName, false)) {
        writer.WriteLine(",Gray,R,G,B");
        for (int i = 0; i < histograms[0].Length; i++) {
          writer.WriteLine($"{i},{histograms[3][i]},{histograms[0][i]},{histograms[1][i]},{histograms[2][i]}");
        }
      }
    };

    private void OnChangeStep(object sender, EventArgs e) => DrawHistograms();
  }
}
