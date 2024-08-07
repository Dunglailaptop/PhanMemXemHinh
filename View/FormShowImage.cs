using DevExpress.XtraEditors;
using PhanMemXemHinh.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemXemHinh.View
{
    public partial class FormShowImage : DevExpress.XtraEditors.XtraForm
    {

        public string MaBenhNhan { get; set; }
        public string urlFolder { get; set; }
        private int currentImageIndex = 0;
        private List<string> imagePaths;

        public FormShowImage()
        {
            InitializeComponent();
        }

        private void LoadImages()
        {
            imagePaths = GetDataImageController.FindPatientImages(MaBenhNhan, urlFolder);
            if (imagePaths.Any())
            {
                DisplayCurrentImage();
                UpdateNavigationButtons();
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh cho bệnh nhân này.");
                simpleButton1.Enabled = false;
                simpleButton2.Enabled = false;
            }
        }

        private void DisplayCurrentImage()
        {
            if (currentImageIndex >= 0 && currentImageIndex < imagePaths.Count)
            {
                string path = imagePaths[currentImageIndex];
                if (File.Exists(path))
                {
                    pictureEdit1.Image?.Dispose();
                    pictureEdit1.Image = Image.FromFile(path);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy file: {path}");
                }
            }
        }

        private void UpdateNavigationButtons()
        {
            simpleButton1.Enabled = currentImageIndex < imagePaths.Count - 1;
            simpleButton2.Enabled = currentImageIndex > 0;
        }

        private void imageListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void DisplayImages(List<string> path, int number)
        {

            if (File.Exists(path[number]))
            {
                Image image = Image.FromFile(path[0]);
                pictureEdit1.Image?.Dispose();
                pictureEdit1.Image = image;
            }
            else
            {
                MessageBox.Show($"Không tìm thấy file: {path}");
            }

        }



        private void FormShowImage_Load(object sender, EventArgs e)
        {
           LoadImages();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (currentImageIndex < imagePaths.Count - 1)
            {
                currentImageIndex++;
                DisplayCurrentImage();
                UpdateNavigationButtons();
            }


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                DisplayCurrentImage();
                UpdateNavigationButtons();
            }
        }
    }
}