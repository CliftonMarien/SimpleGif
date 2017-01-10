using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGif
{
    public partial class Viewer : Form
    {

        string fileName;

        public Viewer(string filename)
        {
            InitializeComponent();
            fileName = filename;
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                Image file = Image.FromFile(fileName);
                image.Image = file;
                Size = new System.Drawing.Size(file.Size.Width + 150, file.Size.Height + 150);
            }
        }
    }
}
