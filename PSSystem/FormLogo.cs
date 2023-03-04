using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSystem
{
    public partial class FormLogo : Form
    {
        public FormLogo()
        {
            InitializeComponent();
        }

        public void ShowImage(Bitmap image, int pictureIndex)
        {
            if (pictureIndex == 0)
            {
                pictureBox1.Image = image;
            }
            else if (pictureIndex == 1)
            {
                pictureBox2.Image = image;
            }
            else if (pictureIndex == 2)
            {
                pictureBox3.Image = image;
            }
            else if (pictureIndex == 3)
            {
                pictureBox4.Image = image;
            }
        }
    }
}
