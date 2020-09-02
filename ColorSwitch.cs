using System;
using System.Drawing;
using System.Windows.Forms;

namespace Image0 {
  public partial class ColorSwitch : UserControl {
    public ColorSwitch() {
      InitializeComponent();

      check.CheckedChanged += (sender, e) => CheckedChanged?.Invoke(sender, e);
    }

    public event EventHandler CheckedChanged;

    public Color SwitchColor {
      set => check.ForeColor = value;
      get => check.ForeColor;
    }
    public string CheckText {
      set => check.Text = value;
      get => check.Text;
    }
    public bool Checked {
      set => check.Checked = value;
      get => check.Checked;
    }
  }
}
