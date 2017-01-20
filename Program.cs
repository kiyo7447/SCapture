using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using System.Drawing.Imaging;
using Microsoft.VisualBasic.MyServices;
using Win32;
using System.IO;
using System.Text;

namespace Capture
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static int Main(string[] args)
		{
			try
			{
				return MainProc(args);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				//OSのログに保存
				throw;
			}
		}

		static int MainProc(string[] args)
		{
			if (args.Length > 0)
			{
				if (args[0].ToUpper() == "/S")
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new SettingForm());
				}
				else
				{
					MessageBox.Show("無効なパラメータが引き渡されました。");
				}
			}
			else
			{
				Capture.Properties.Settings setting = new Capture.Properties.Settings();
				Rectangle rc = Rectangle.Empty;

				System.Windows.Forms.Keys key = System.Windows.Forms.Control.ModifierKeys;

				Thread.Sleep(1000);

				//なぜかGetActiveWindow()では上手くいかなかった。
				int hwnd = User.GetForegroundWindow();
				//int hwnd = User.GetActiveWindow();

				if (hwnd == 0)
				{
					MessageBox.Show("アクティブウィンドウの取得に失敗しました。");
					return -1;
				}
				//Windows 7コード
				//RECT rect = new RECT();
				//int ret = User.GetWindowRect((IntPtr)hwnd, ref rect);

				//
				Rectangle rectn = Dwm.GetWindowRectangle((IntPtr)hwnd);
				RECT rect = new RECT();
				rect.Bottom = rectn.Bottom;
				rect.Top = rectn.Top;
				rect.Left = rectn.Left;
				rect.Right = rectn.Right;

				//Shiftキー押下→Control押下に修正
				//if (key == System.Windows.Forms.Keys.Shift)
				if (key == System.Windows.Forms.Keys.Control)
				{
					//全画面を取得
					//ただし、マルチモニタの場合は、対象のウィンドウがあるスクリーンをキャプチャします。

					//マルチモニタ対応
					foreach (Screen screen in Screen.AllScreens)
					{
						if (rect.Left >= screen.Bounds.X && rect.Left <= screen.Bounds.X + screen.Bounds.Width && rect.Top >= screen.Bounds.Y && rect.Top <= screen.Bounds.Y + screen.Bounds.Height)
						{
							rc = screen.Bounds;
						}
					}

					if (rc.IsEmpty == true)
					{
						//MessageBox.Show("set primary screen");
						//左隅がどこのモニタにも写っていなかったら、プライマリモニタをキャプチャする（適当ｗ
						rc = Screen.PrimaryScreen.Bounds;
					}

					////Debug Message
					//StringBuilder s = new StringBuilder();
					//s.AppendLine("rect.Left:" + rect.Left);      //Y座標
					//s.AppendLine("rect.Top:" + rect.Top);        //X座標
					//s.AppendLine("rect.Right:" + rect.Right);    //Y座標
					//s.AppendLine("rect.Bottom:" + rect.Bottom);  //X座標

					//s.AppendLine("");  //X座標

					//s.AppendLine("rc.X:" + rc.X);               //Y座標
					//s.AppendLine("rc.Y:" + rc.Y);               //X座標
					//s.AppendLine("rc.Heght:" + rc.Height);      //Y座標
					//s.AppendLine("rc.Width:" + rc.Width);       //X座標

					//MessageBox.Show(s.ToString());

				}
				else
				{

					//マルチモニタ対応
					//if (Screen.AllScreens.Length == 1)
					//{
					//    //最大化の場合の補正を行う
					//    if (rect.Top < 0)
					//    {
					//        rect.Top = 0;
					//    }
					//    if (rect.Left < 0)
					//    {
					//        rect.Left = 0;
					//    }
					//    if (rect.Bottom > Screen.PrimaryScreen.Bounds.Height)
					//    {
					//        rect.Bottom = Screen.PrimaryScreen.Bounds.Height;
					//    }
					//    if (rect.Right > Screen.PrimaryScreen.Bounds.Width)
					//    {
					//        rect.Right = Screen.PrimaryScreen.Bounds.Width;
					//    }
					//}
					//else
					//{
					//マルチモニタ対応
					const int Hosei = 4;        //フルスクリーン時の補正値
					foreach (Screen screen in Screen.AllScreens)
					{
						Rectangle fullRect = screen.Bounds;
						//フルスクリーンの場合は補正を行う。
						if ((rect.Top + Hosei) == fullRect.Top &&
								(rect.Bottom - Hosei) == fullRect.Bottom &&
								(rect.Left + Hosei) == fullRect.Left &&
								(rect.Right - Hosei) == fullRect.Right)
						{
							rect.Top = fullRect.Top;
							rect.Bottom = fullRect.Bottom;
							rect.Left = fullRect.Left;
							rect.Right = fullRect.Right;
						}
					}
					//}
					rc = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
				}


				// Bitmapオブジェクトにスクリーン・キャプチャ
				Bitmap bmp = new Bitmap(
				  rc.Width, rc.Height, PixelFormat.Format32bppArgb);
				using (Graphics g = Graphics.FromImage(bmp))
				{
					g.CopyFromScreen(rc.X, rc.Y, 0, 0,
					  rc.Size, CopyPixelOperation.SourceCopy);

					// ビット・ブロック転送方式の切り替え例：
					//g.FillRectangle(Brushes.LightPink,
					//  0, 0, rc.Width, rc.Height);
					//g.CopyFromScreen(rc.X, rc.Y, 0, 0,
					//  rc.Size, CopyPixelOperation.SourceAnd);
				}




				// ビットマップ画像として保存して表示
				string filePath = Path.Combine(setting.OutputDirectory, setting.FileName);

				ImageFormat @if = null;
				string extensions = "";
				switch (setting.ImageFormat)
				{
					case "Icon":
						@if = ImageFormat.Icon;
						extensions = ".ico";
						break;
					case "Jpeg":
						@if = ImageFormat.Jpeg;
						extensions = ".jpg";
						break;
					case "Bmp":
						@if = ImageFormat.Bmp;
						extensions = ".bmp";
						break;
					case "Gif":
						@if = ImageFormat.Gif;
						extensions = ".gif";
						break;
					case "Png":
						@if = ImageFormat.Png;
						extensions = ".png";
						break;
					default:
						throw new SystemException("無効なフォーマットが選ばれました。ImageFormat=" + setting.ImageFormat);

				}

				if (setting.IsIncrement == true)
				{
					int cnt;
					for (cnt = 1; cnt < 1000; cnt++)
					{
						string fp = filePath + cnt.ToString("000") + extensions;

						if (File.Exists(fp) == false)
						{
							filePath = filePath + cnt.ToString("000");
							break;
						}
					}
					if (cnt == 1000)
					{
						throw new SystemException("保存先のファイル数が最大数を超えました。保存先フォルダ=" + filePath + ", 保存先のファイル最大数=" + cnt);
					}
				}


				string fileName = null;
				try
				{
					fileName = filePath + extensions;
					bmp.Save(fileName, @if);
				}
				catch (Exception ex)
				{
					MessageBox.Show("エラーの原因がGDI+の汎用エラーの場合、保存先への書き込み権限がないことが考えられます。" + Environment.NewLine + "保存ファイル名=" + fileName + ", 詳細=" + ex.ToString(), "エラー");
				}
				//Process.Start(filePath);

				StringCollection sc = new StringCollection();
				sc.Add(filePath + extensions);

				ClipbordDataFormat cdf = (ClipbordDataFormat)Enum.Parse(typeof(ClipbordDataFormat), setting.ClipbordDataFormat);

				switch (cdf)
				{
					case ClipbordDataFormat.FileDropList:
						Clipboard.SetFileDropList(sc);

						break;
					case ClipbordDataFormat.Image:
						Clipboard.SetImage(bmp);
						break;
					default:
						throw new SystemException("無効なパラメターたです。ClipbordDataFormat=" + cdf);
				}
			}
			return 0;
		}
	}
}