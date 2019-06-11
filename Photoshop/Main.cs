using System;
using System.Windows.Forms;

namespace Photoshop
{
	class MainClass
	{
        [STAThread]
		public static void Main (string[] args)
		{
			var window=new MainWindow();
			window.AddFilter (new LighteningFilter());
            window.AddFilter(new GrayScaleFilter());
            Application.Run (window);
		}
	}
}
