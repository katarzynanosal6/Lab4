using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Bitmap Files|*.bmp" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            if (rb90.Checked) pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            else if (rb180.Checked) pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            else if (rb270.Checked) pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Refresh();
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            pictureBox1.Refresh();
        }

        private void btnUpsideDown_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Refresh();
        }

        private void btnOnlyGreen_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap bmp = new Bitmap(pictureBox1.Image);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);

                  
                    if (!(c.G > c.R && c.G > c.B))
                    {
                        
                        bmp.SetPixel(x, y, Color.Black);
                    }
                }
            }
            
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }
    }
}
