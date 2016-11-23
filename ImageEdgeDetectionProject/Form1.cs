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
        ImageManagement anImageDetection;

        // initialization for the component from ImageDetection class
        public Form1()
        {
            InitializeComponent();
            IImageDetection iid = new ImageDetection();
            IIOfiles iiof = new FileRW();
            anImageDetection = new ImageManagement(iiof ,iid);
        }

        // method to ...
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // method - add an image file by clicking on a button
        private void addImage_Click(object sender, EventArgs e)
        {
            // choosing the file from a pool of available extensions
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = anImageDetection.GetImageFromPath(ofd.FileName);
            }
        }

        // method - apply a filter to the chosen image file
        private void applyFilter_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = anImageDetection.applyTheFilter((Bitmap) pictureBox1.Image);
        }

        // method - save the filtered image in a chosen directory + file name/extension
        private void saveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Specify a file name and file path";
            sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                anImageDetection.SaveImageToPath((Bitmap)pictureBox1.Image, sfd.FileName);
            }
        }
    }
}
