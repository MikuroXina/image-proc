using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Image0.processors;
using Image0.processors.fold;
using Image0.processors.transform;

namespace Image0 {
  public interface IImageProcessor {
    string Name { get; }
    string Postfix { get; }

    Bitmap Process(Bitmap bmp, double parameter);
  }

  public partial class Form1 : Form {
    readonly IImageProcessor[] processors = {
      new GrayScale(),
      new Brightness(),
      new Contrast(),
      new Gamma(),
      new RightEdge(),
      new LeftEdge(),
      new LeftRightEdge(),
      new Laplacian(),
      new Identity(),
      new LeftRightSmooth(),
      new Smooth(),
      new Sharpness(),
      new Denoise(),
      new HorizontalMirror(),
      new Triangulation(),
      new ForwardRotate(),
      new BackwardRotate(),
      new HueRotate(),
    };

    public Form1() {
      InitializeComponent();

      processorSelector.Items.AddRange(processors.Select(p => p.Name).ToArray());
    }

    static readonly string originalTitle = "画像処理";
    string openedFileName = null;

    IImageProcessor CurrentProcessor() => processors[processorSelector.SelectedIndex];

    private void OnClickLoad(object sender, EventArgs e) {
      var dialog = new OpenFileDialog {
        Filter = "ビットマップ(*.bmp)|*.bmp",
        Title = "画像（ビットマップ）の読み込み"
      };
      dialog.FileOk += LoadImageFile;
      dialog.ShowDialog();
    }

    private void LoadImageFile(object sender, CancelEventArgs e) {
      openedFileName = (sender as OpenFileDialog).FileName;
      Text = $"{originalTitle} - {openedFileName}";
      picCap.Image = Image.FromFile(openedFileName);

      btnViewSave.Enabled = false;
      btnViewHist.Enabled = false;

      btnCapHist.Enabled = true;
      btnCapHist.Enabled = true;
      process.Enabled = true;
    }

    private void Form1_Load(object sender, EventArgs e) {
      btnCapHist.Enabled = false;
      btnViewSave.Enabled = false;
      btnViewHist.Enabled = false;
      btnCapHist.Enabled = false;
      process.Enabled = false;
    }

    private void OnClickSave(object sender, EventArgs e) {
      var defaultDstPath = $"{Path.GetFileNameWithoutExtension(openedFileName)}{CurrentProcessor().Postfix}.bmp";
      var dialog = new SaveFileDialog {
        FileName = defaultDstPath
      };
      dialog.FileOk += (_, okEvent) => picView.Image.Save(dialog.FileName);
      dialog.ShowDialog();
    }

    private void ShowHistogram_Original(object sender, EventArgs e) {
      var bmpCap = new Bitmap(picCap.Image);
      new HistogramForm(bmpCap).Show();
    }

    private void ShowHistogram_Processed(object sender, EventArgs e) {
      var bmpView = new Bitmap(picView.Image);
      new HistogramForm(bmpView).Show();
    }

    private void OnClickProcess(object sender, EventArgs e) {
      btnViewHist.Enabled = true;
      btnViewSave.Enabled = true;

      var idx = processorSelector.SelectedIndex;
      var before = new Bitmap(picCap.Image);
      var after = processors[idx].Process(before, (double)parameter.Value);
      picView.Image = after;
    }
  }
}
