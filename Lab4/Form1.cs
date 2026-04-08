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
    }
}
