using ImageEdgeDetectionProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEdgeDetectionProject
{
    public partial class Form1 : Form
    {
        ImageDetection anImageDetection;

        public Form1()
        {
            InitializeComponent();
            anImageDetection = new ImageDetection();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = anImageDetection.loadImage(ofd.FileName);
            }
        }

        private void applyFilter_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = anImageDetection.applyFilter((Bitmap) pictureBox1.Image);
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Specify a file name and file path";
            sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                anImageDetection.saveImage((Bitmap)pictureBox1.Image, sfd.FileName);
            }
        }
    }
}
