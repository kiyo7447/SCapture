namespace Capture
{
	partial class SettingForm
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this._textFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._textOutputDirectory = new System.Windows.Forms.TextBox();
            this._buttonSelectDirectory = new System.Windows.Forms.Button();
            this._comboImageType = new System.Windows.Forms.ComboBox();
            this._radioFixed = new System.Windows.Forms.RadioButton();
            this._radioIncrement = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this._buttonOk = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._radioImage = new System.Windows.Forms.RadioButton();
            this._radioFile = new System.Windows.Forms.RadioButton();
            this._numericUpDownOpacity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // _textFileName
            // 
            this._textFileName.Location = new System.Drawing.Point(171, 45);
            this._textFileName.Name = "_textFileName";
            this._textFileName.Size = new System.Drawing.Size(318, 22);
            this._textFileName.TabIndex = 1;
            this._textFileName.Text = "screen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ファイル名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "出力ディレクトリ";
            // 
            // _textOutputDirectory
            // 
            this._textOutputDirectory.Location = new System.Drawing.Point(171, 17);
            this._textOutputDirectory.Name = "_textOutputDirectory";
            this._textOutputDirectory.Size = new System.Drawing.Size(318, 22);
            this._textOutputDirectory.TabIndex = 4;
            this._textOutputDirectory.Text = "o:\\";
            // 
            // _buttonSelectDirectory
            // 
            this._buttonSelectDirectory.Location = new System.Drawing.Point(495, 16);
            this._buttonSelectDirectory.Name = "_buttonSelectDirectory";
            this._buttonSelectDirectory.Size = new System.Drawing.Size(111, 23);
            this._buttonSelectDirectory.TabIndex = 5;
            this._buttonSelectDirectory.Text = "参照...";
            this._buttonSelectDirectory.UseVisualStyleBackColor = true;
            this._buttonSelectDirectory.Click += new System.EventHandler(this._buttonSelectDirectory_Click);
            // 
            // _comboImageType
            // 
            this._comboImageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboImageType.FormattingEnabled = true;
            this._comboImageType.Location = new System.Drawing.Point(171, 98);
            this._comboImageType.Name = "_comboImageType";
            this._comboImageType.Size = new System.Drawing.Size(318, 23);
            this._comboImageType.TabIndex = 6;
            // 
            // _radioFixed
            // 
            this._radioFixed.AutoSize = true;
            this._radioFixed.Location = new System.Drawing.Point(171, 73);
            this._radioFixed.Name = "_radioFixed";
            this._radioFixed.Size = new System.Drawing.Size(57, 19);
            this._radioFixed.TabIndex = 7;
            this._radioFixed.Text = "固定";
            this._radioFixed.UseVisualStyleBackColor = true;
            // 
            // _radioIncrement
            // 
            this._radioIncrement.AutoSize = true;
            this._radioIncrement.Checked = true;
            this._radioIncrement.Location = new System.Drawing.Point(298, 73);
            this._radioIncrement.Name = "_radioIncrement";
            this._radioIncrement.Size = new System.Drawing.Size(137, 19);
            this._radioIncrement.TabIndex = 8;
            this._radioIncrement.TabStop = true;
            this._radioIncrement.Text = "インクリメント";
            this._radioIncrement.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "ファイルタイプ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(615, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(404, 312);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(199, 15);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://kiyo.dnsalias.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // _buttonOk
            // 
            this._buttonOk.Location = new System.Drawing.Point(378, 287);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(111, 22);
            this._buttonOk.TabIndex = 12;
            this._buttonOk.Text = "OK(Enter)";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this._buttonOk_Click);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Location = new System.Drawing.Point(261, 287);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(111, 22);
            this._buttonCancel.TabIndex = 13;
            this._buttonCancel.Text = "ｷｬﾝｾﾙ(ESC)";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this._buttonCancel_Click);
            // 
            // _buttonUpdate
            // 
            this._buttonUpdate.Location = new System.Drawing.Point(495, 287);
            this._buttonUpdate.Name = "_buttonUpdate";
            this._buttonUpdate.Size = new System.Drawing.Size(111, 22);
            this._buttonUpdate.TabIndex = 14;
            this._buttonUpdate.Text = "更新";
            this._buttonUpdate.UseVisualStyleBackColor = true;
            this._buttonUpdate.Click += new System.EventHandler(this._buttonUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._radioImage);
            this.groupBox1.Controls.Add(this._radioFile);
            this.groupBox1.Location = new System.Drawing.Point(171, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 54);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "クリップボード";
            // 
            // _radioImage
            // 
            this._radioImage.AutoSize = true;
            this._radioImage.Location = new System.Drawing.Point(156, 21);
            this._radioImage.Name = "_radioImage";
            this._radioImage.Size = new System.Drawing.Size(89, 19);
            this._radioImage.TabIndex = 18;
            this._radioImage.Text = "イメージ";
            this._radioImage.UseVisualStyleBackColor = true;
            // 
            // _radioFile
            // 
            this._radioFile.AutoSize = true;
            this._radioFile.Checked = true;
            this._radioFile.Location = new System.Drawing.Point(13, 21);
            this._radioFile.Name = "_radioFile";
            this._radioFile.Size = new System.Drawing.Size(89, 19);
            this._radioFile.TabIndex = 17;
            this._radioFile.TabStop = true;
            this._radioFile.Text = "ファイル";
            this._radioFile.UseVisualStyleBackColor = true;
            // 
            // _numericUpDownOpacity
            // 
            this._numericUpDownOpacity.Location = new System.Drawing.Point(171, 187);
            this._numericUpDownOpacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numericUpDownOpacity.Name = "_numericUpDownOpacity";
            this._numericUpDownOpacity.Size = new System.Drawing.Size(120, 22);
            this._numericUpDownOpacity.TabIndex = 19;
            this._numericUpDownOpacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numericUpDownOpacity.ValueChanged += new System.EventHandler(this._numericUpDownOpacity_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "透明度";
            // 
            // SettingForm
            // 
            this.AcceptButton = this._buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._buttonCancel;
            this.ClientSize = new System.Drawing.Size(615, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._numericUpDownOpacity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._buttonUpdate);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._radioIncrement);
            this.Controls.Add(this._radioFixed);
            this.Controls.Add(this._comboImageType);
            this.Controls.Add(this._buttonSelectDirectory);
            this.Controls.Add(this._textOutputDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textFileName);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.Opacity = 0.8D;
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _textFileName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _textOutputDirectory;
		private System.Windows.Forms.Button _buttonSelectDirectory;
		private System.Windows.Forms.ComboBox _comboImageType;
		private System.Windows.Forms.RadioButton _radioFixed;
		private System.Windows.Forms.RadioButton _radioIncrement;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
		private System.Windows.Forms.Button _buttonOk;
		private System.Windows.Forms.Button _buttonCancel;
		private System.Windows.Forms.Button _buttonUpdate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton _radioImage;
		private System.Windows.Forms.RadioButton _radioFile;
        private System.Windows.Forms.NumericUpDown _numericUpDownOpacity;
        private System.Windows.Forms.Label label4;

	}
}