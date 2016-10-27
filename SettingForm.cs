using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Reflection;

namespace Capture
{
	public partial class SettingForm : Form
	{
		public SettingForm()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(linkLabel1.Text);
		}

		private void _buttonSelectDirectory_Click(object sender, EventArgs e)
		{
			_folderBrowserDialog.Description = "出力先フォルダ";

			_folderBrowserDialog.SelectedPath = _textOutputDirectory.Text;

			_folderBrowserDialog.ShowNewFolderButton = true;


			DialogResult ret = _folderBrowserDialog.ShowDialog(this);
			if (ret == DialogResult.OK)
			{
				_textOutputDirectory.Text = _folderBrowserDialog.SelectedPath;
			}
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			Type @if = typeof(ImageFormat);
			foreach (PropertyInfo pi in @if.GetProperties())
				_comboImageType.Items.Add(pi.Name);

			Capture.Properties.Settings setting = new Capture.Properties.Settings();

			_textOutputDirectory.Text = setting.OutputDirectory;
			_textFileName.Text = setting.FileName;
			if (setting.IsIncrement == true)
			{
				_radioIncrement.Checked = true;
			}
			else
			{
				_radioFixed.Checked = true;
			}
			_comboImageType.Text = setting.ImageFormat;

				ClipbordDataFormat cdf = (ClipbordDataFormat)Enum.Parse(typeof(ClipbordDataFormat), setting.ClipbordDataFormat);
		
			//クリップボードのフォーマット（設定⇒画面）
			if (cdf == ClipbordDataFormat.Image)
			{
				_radioImage.Checked = true;
			}
			else if (cdf == ClipbordDataFormat.FileDropList)
			{
				_radioFile.Checked = true;
			}
			else
			{
				throw new SystemException("無効な処理です。");
			}

            try
            {
                _numericUpDownOpacity.Value = setting.FormOpacity;
            }
            catch
            {
                _numericUpDownOpacity.Value = _numericUpDownOpacity.Maximum;
            }
		}

		private void _buttonUpdate_Click(object sender, EventArgs e)
		{
			Capture.Properties.Settings setting = new Capture.Properties.Settings();

			setting.OutputDirectory = _textOutputDirectory.Text;
			setting.FileName = _textFileName.Text;
			setting.IsIncrement = _radioIncrement.Checked;
			setting.ImageFormat = _comboImageType.Text;

			//クリップボードのフォーマット（画面⇒設定）
			if (_radioFile.Checked == true)
			{
				setting.ClipbordDataFormat = ClipbordDataFormat.FileDropList.ToString();
			}
			else if (_radioImage.Checked == true) {
				setting.ClipbordDataFormat = ClipbordDataFormat.Image.ToString();
			}
			else
			{
				throw new SystemException("無効な処理");
			}

            setting.FormOpacity = Convert.ToInt32( _numericUpDownOpacity.Value);

			setting.Save();
		}

		private void _buttonOk_Click(object sender, EventArgs e)
		{
			_buttonUpdate_Click(sender, e);

			DialogResult = DialogResult.OK;

			Close();
		}

		private void _buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;

			Close();
		}

        private void _numericUpDownOpacity_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown s = (NumericUpDown)sender;
            Opacity = (Convert.ToDouble(s.Value) / 100);
        }
	}
}