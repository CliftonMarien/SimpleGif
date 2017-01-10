using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace SimpleGif
{
    class Program
    {

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            if (args.Length > 0)
            {
                Application.Run(new Viewer(args[0]));
            }
            else
            {
                MessageBox.Show("No file was found, or there was an error loading the file.  \nBe sure to open the file with the application instead of running it directly.", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
