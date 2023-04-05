using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class frmFindDuplicates : Form
    {
        public frmFindDuplicates()
        {
            InitializeComponent();
        }

        private void btnLoadFile1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath1.Text = openFileDialog1.FileName;
            }
        }

        private void btnLoadFile2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txtFilePath2.Text = openFileDialog2.FileName;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            ImgMagick imgMagick = new ImgMagick();
           bool result = imgMagick.areImageSame(txtFilePath1.Text, txtFilePath2.Text);
            lblResult.Text = result == true ? "Same" : "Different"; 
        }
    }
}
