using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Bitmap bmp0 = (Bitmap)pictureBox1.Image.Clone();
            Bitmap bmp01 = bmp0;
            Bitmap bmp1 = (Bitmap)pictureBox2.Image;
            Graphics g = Graphics.FromImage(bmp01);

            g.DrawImage(bmp1, 0, 0, bmp0.Size.Width, bmp0.Size.Height);
            g.Dispose();
            pictureBox3.Image = bmp01;


        }

        private void BtnTarayıcı_Click(object sender, EventArgs e)
        {
            OpenFileDialog thm = new OpenFileDialog();
            if (thm.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = System.Drawing.Image.FromFile(thm.FileName);
            }
        }
    }
}
