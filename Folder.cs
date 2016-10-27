using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Capture
{
	public partial class Folder : UserControl
	{
		public Folder()
		{
			InitializeComponent();
		}

		private void textBox1_SizeChanged(object sender, EventArgs e)
		{
			Height = textBox1.Height;
		}
	}
}
