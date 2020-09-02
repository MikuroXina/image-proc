namespace Image0 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
      this.picCap = new System.Windows.Forms.PictureBox();
      this.picView = new System.Windows.Forms.PictureBox();
      this.btnLoad = new System.Windows.Forms.Button();
      this.btnCapHist = new System.Windows.Forms.Button();
      this.btnViewSave = new System.Windows.Forms.Button();
      this.btnViewHist = new System.Windows.Forms.Button();
      this.processorSelector = new System.Windows.Forms.ComboBox();
      this.process = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.parameter = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.picCap)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.parameter)).BeginInit();
      this.SuspendLayout();
      // 
      // picCap
      // 
      this.picCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.picCap.Location = new System.Drawing.Point(16, 73);
      this.picCap.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.picCap.Name = "picCap";
      this.picCap.Size = new System.Drawing.Size(691, 478);
      this.picCap.TabIndex = 0;
      this.picCap.TabStop = false;
      // 
      // picView
      // 
      this.picView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.picView.Location = new System.Drawing.Point(974, 73);
      this.picView.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.picView.Name = "picView";
      this.picView.Size = new System.Drawing.Size(691, 478);
      this.picView.TabIndex = 1;
      this.picView.TabStop = false;
      // 
      // btnLoad
      // 
      this.btnLoad.Location = new System.Drawing.Point(16, 15);
      this.btnLoad.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(163, 46);
      this.btnLoad.TabIndex = 3;
      this.btnLoad.Text = "&Load";
      this.btnLoad.UseVisualStyleBackColor = true;
      this.btnLoad.Click += new System.EventHandler(this.OnClickLoad);
      // 
      // btnCapHist
      // 
      this.btnCapHist.Enabled = false;
      this.btnCapHist.Location = new System.Drawing.Point(547, 565);
      this.btnCapHist.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.btnCapHist.Name = "btnCapHist";
      this.btnCapHist.Size = new System.Drawing.Size(163, 46);
      this.btnCapHist.TabIndex = 4;
      this.btnCapHist.Text = "ヒストグラム";
      this.btnCapHist.UseVisualStyleBackColor = true;
      this.btnCapHist.Click += new System.EventHandler(this.ShowHistogram_Original);
      // 
      // btnViewSave
      // 
      this.btnViewSave.Enabled = false;
      this.btnViewSave.Location = new System.Drawing.Point(1329, 565);
      this.btnViewSave.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.btnViewSave.Name = "btnViewSave";
      this.btnViewSave.Size = new System.Drawing.Size(163, 46);
      this.btnViewSave.TabIndex = 8;
      this.btnViewSave.Text = "Save";
      this.btnViewSave.UseVisualStyleBackColor = true;
      this.btnViewSave.Click += new System.EventHandler(this.OnClickSave);
      // 
      // btnViewHist
      // 
      this.btnViewHist.Enabled = false;
      this.btnViewHist.Location = new System.Drawing.Point(1505, 565);
      this.btnViewHist.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.btnViewHist.Name = "btnViewHist";
      this.btnViewHist.Size = new System.Drawing.Size(163, 46);
      this.btnViewHist.TabIndex = 7;
      this.btnViewHist.Text = "ヒストグラム";
      this.btnViewHist.UseVisualStyleBackColor = true;
      this.btnViewHist.Click += new System.EventHandler(this.ShowHistogram_Processed);
      // 
      // processorSelector
      // 
      this.processorSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.processorSelector.FormattingEnabled = true;
      this.processorSelector.Location = new System.Drawing.Point(718, 73);
      this.processorSelector.Name = "processorSelector";
      this.processorSelector.Size = new System.Drawing.Size(246, 32);
      this.processorSelector.TabIndex = 39;
      // 
      // process
      // 
      this.process.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.process.Location = new System.Drawing.Point(718, 470);
      this.process.Name = "process";
      this.process.Size = new System.Drawing.Size(246, 81);
      this.process.TabIndex = 40;
      this.process.Text = "変換";
      this.process.UseVisualStyleBackColor = true;
      this.process.Click += new System.EventHandler(this.OnClickProcess);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(717, 131);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 24);
      this.label1.TabIndex = 41;
      this.label1.Text = "パラメータ";
      // 
      // parameter
      // 
      this.parameter.DecimalPlaces = 2;
      this.parameter.Location = new System.Drawing.Point(717, 159);
      this.parameter.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.parameter.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
      this.parameter.Name = "parameter";
      this.parameter.Size = new System.Drawing.Size(247, 31);
      this.parameter.TabIndex = 42;
      this.parameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1684, 644);
      this.Controls.Add(this.parameter);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.process);
      this.Controls.Add(this.processorSelector);
      this.Controls.Add(this.btnViewSave);
      this.Controls.Add(this.btnViewHist);
      this.Controls.Add(this.btnCapHist);
      this.Controls.Add(this.btnLoad);
      this.Controls.Add(this.picView);
      this.Controls.Add(this.picCap);
      this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.Name = "Form1";
      this.Text = "画像処理";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picCap)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.parameter)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCap;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCapHist;
        private System.Windows.Forms.Button btnViewSave;
        private System.Windows.Forms.Button btnViewHist;
    private System.Windows.Forms.ComboBox processorSelector;
    private System.Windows.Forms.Button process;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown parameter;
  }
}