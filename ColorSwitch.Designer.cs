namespace Image0 {
  partial class ColorSwitch {
    /// <summary> 
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region コンポーネント デザイナーで生成されたコード

    /// <summary> 
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent() {
      this.check = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // check
      // 
      this.check.AutoSize = true;
      this.check.Location = new System.Drawing.Point(4, 4);
      this.check.Name = "check";
      this.check.Size = new System.Drawing.Size(151, 28);
      this.check.TabIndex = 0;
      this.check.Text = "checkBox1";
      this.check.UseVisualStyleBackColor = true;
      // 
      // ColorSwitch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.Controls.Add(this.check);
      this.Name = "ColorSwitch";
      this.Size = new System.Drawing.Size(158, 35);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox check;
  }
}
