namespace Image0 {
  partial class HistogramForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.step = new System.Windows.Forms.NumericUpDown();
      this.lblCapHistMin = new System.Windows.Forms.Label();
      this.saveAsCSVButton = new System.Windows.Forms.Button();
      this.canvas = new System.Windows.Forms.PictureBox();
      this.colorSwitchPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.colorSwitch1 = new Image0.ColorSwitch();
      this.colorSwitch2 = new Image0.ColorSwitch();
      this.colorSwitch3 = new Image0.ColorSwitch();
      this.colorSwitch4 = new Image0.ColorSwitch();
      ((System.ComponentModel.ISupportInitialize)(this.step)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
      this.colorSwitchPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // step
      // 
      this.step.Location = new System.Drawing.Point(12, 12);
      this.step.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.step.Name = "step";
      this.step.Size = new System.Drawing.Size(120, 31);
      this.step.TabIndex = 38;
      this.step.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
      this.step.ValueChanged += new System.EventHandler(this.OnChangeStep);
      // 
      // lblCapHistMin
      // 
      this.lblCapHistMin.AutoSize = true;
      this.lblCapHistMin.Location = new System.Drawing.Point(110, 226);
      this.lblCapHistMin.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
      this.lblCapHistMin.Name = "lblCapHistMin";
      this.lblCapHistMin.Size = new System.Drawing.Size(22, 24);
      this.lblCapHistMin.TabIndex = 37;
      this.lblCapHistMin.Text = "0";
      this.lblCapHistMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // saveAsCSVButton
      // 
      this.saveAsCSVButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.saveAsCSVButton.Location = new System.Drawing.Point(537, 262);
      this.saveAsCSVButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.saveAsCSVButton.Name = "saveAsCSVButton";
      this.saveAsCSVButton.Size = new System.Drawing.Size(163, 46);
      this.saveAsCSVButton.TabIndex = 36;
      this.saveAsCSVButton.Text = "CSVで保存";
      this.saveAsCSVButton.UseVisualStyleBackColor = true;
      this.saveAsCSVButton.Click += new System.EventHandler(this.OnClickSaveAsCSV);
      // 
      // canvas
      // 
      this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.canvas.BackColor = System.Drawing.Color.White;
      this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.canvas.Location = new System.Drawing.Point(148, 12);
      this.canvas.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.canvas.Name = "canvas";
      this.canvas.Size = new System.Drawing.Size(552, 238);
      this.canvas.TabIndex = 35;
      this.canvas.TabStop = false;
      // 
      // colorSwitchPanel
      // 
      this.colorSwitchPanel.Controls.Add(this.colorSwitch1);
      this.colorSwitchPanel.Controls.Add(this.colorSwitch2);
      this.colorSwitchPanel.Controls.Add(this.colorSwitch3);
      this.colorSwitchPanel.Controls.Add(this.colorSwitch4);
      this.colorSwitchPanel.Location = new System.Drawing.Point(13, 50);
      this.colorSwitchPanel.Name = "colorSwitchPanel";
      this.colorSwitchPanel.Size = new System.Drawing.Size(119, 258);
      this.colorSwitchPanel.TabIndex = 40;
      // 
      // colorSwitch1
      // 
      this.colorSwitch1.AutoSize = true;
      this.colorSwitch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.colorSwitch1.Checked = true;
      this.colorSwitch1.CheckText = "赤";
      this.colorSwitch1.Location = new System.Drawing.Point(3, 3);
      this.colorSwitch1.Name = "colorSwitch1";
      this.colorSwitch1.Size = new System.Drawing.Size(73, 35);
      this.colorSwitch1.SwitchColor = System.Drawing.Color.Red;
      this.colorSwitch1.TabIndex = 0;
      // 
      // colorSwitch2
      // 
      this.colorSwitch2.AutoSize = true;
      this.colorSwitch2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.colorSwitch2.Checked = true;
      this.colorSwitch2.CheckText = "緑";
      this.colorSwitch2.Location = new System.Drawing.Point(3, 44);
      this.colorSwitch2.Name = "colorSwitch2";
      this.colorSwitch2.Size = new System.Drawing.Size(73, 35);
      this.colorSwitch2.SwitchColor = System.Drawing.Color.Green;
      this.colorSwitch2.TabIndex = 1;
      // 
      // colorSwitch3
      // 
      this.colorSwitch3.AutoSize = true;
      this.colorSwitch3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.colorSwitch3.Checked = true;
      this.colorSwitch3.CheckText = "青";
      this.colorSwitch3.Location = new System.Drawing.Point(3, 85);
      this.colorSwitch3.Name = "colorSwitch3";
      this.colorSwitch3.Size = new System.Drawing.Size(73, 35);
      this.colorSwitch3.SwitchColor = System.Drawing.Color.Blue;
      this.colorSwitch3.TabIndex = 2;
      // 
      // colorSwitch4
      // 
      this.colorSwitch4.AutoSize = true;
      this.colorSwitch4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.colorSwitch4.Checked = false;
      this.colorSwitch4.CheckText = "灰";
      this.colorSwitch4.Location = new System.Drawing.Point(3, 126);
      this.colorSwitch4.Name = "colorSwitch4";
      this.colorSwitch4.Size = new System.Drawing.Size(73, 35);
      this.colorSwitch4.SwitchColor = System.Drawing.SystemColors.ControlText;
      this.colorSwitch4.TabIndex = 3;
      // 
      // HistogramForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(715, 323);
      this.Controls.Add(this.colorSwitchPanel);
      this.Controls.Add(this.step);
      this.Controls.Add(this.lblCapHistMin);
      this.Controls.Add(this.saveAsCSVButton);
      this.Controls.Add(this.canvas);
      this.Name = "HistogramForm";
      this.Text = "ヒストグラム";
      this.ResizeEnd += new System.EventHandler(this.OnChangeStep);
      ((System.ComponentModel.ISupportInitialize)(this.step)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
      this.colorSwitchPanel.ResumeLayout(false);
      this.colorSwitchPanel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.NumericUpDown step;
    private System.Windows.Forms.Label lblCapHistMin;
    private System.Windows.Forms.Button saveAsCSVButton;
    private System.Windows.Forms.PictureBox canvas;
    private System.Windows.Forms.FlowLayoutPanel colorSwitchPanel;
    private ColorSwitch colorSwitch1;
    private ColorSwitch colorSwitch2;
    private ColorSwitch colorSwitch3;
    private ColorSwitch colorSwitch4;
  }
}