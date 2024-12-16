using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Redactor
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> originalImage;
        private Image<Bgr, byte> processedImage; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Выберите изображение"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Загрузка изображения
                originalImage = new Image<Bgr, byte>(openFileDialog.FileName);
                processedImage = originalImage.Clone(); 
                pictureBoxOriginal.Image = originalImage.ToBitmap();
                pictureBoxProcessed.Image = processedImage.ToBitmap(); 
            }
        }

        private void btnProcessImage_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                
                processedImage = originalImage.Convert<Gray, byte>().Convert<Bgr, byte>(); 
                pictureBoxProcessed.Image = processedImage.ToBitmap();
            }
            else
            {
                MessageBox.Show("Сначала загрузите изображение!");
            }
        }

        // сохранить
        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (processedImage != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PNG Image|*.png",
                    Title = "Сохранить обработанное изображение"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    processedImage.Save(saveFileDialog.FileName);
                    MessageBox.Show("Изображение успешно сохранено!");
                }
            }
            else
            {
                MessageBox.Show("Обработанное изображение отсутствует!");
            }
        }

        // Поворот
        private void btnRotateImage_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                
                originalImage = originalImage.Rotate(90, new Bgr(255, 255, 255));
                pictureBoxOriginal.Image = originalImage.ToBitmap();

              
                if (processedImage != null)
                {
                    processedImage = processedImage.Rotate(90, new Bgr(255, 255, 255)); 
                    pictureBoxProcessed.Image = processedImage.ToBitmap();
                }
            }
            else
            {
                MessageBox.Show("Сначала загрузите изображение!");
            }
        }

        // Яркость
        private void btnAdjustBrightness_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
             
                processedImage = originalImage.Mul(1.2).Add(new Bgr(50, 50, 50)); 
                pictureBoxProcessed.Image = processedImage.ToBitmap();
            }
            else
            {
                MessageBox.Show("Сначала загрузите изображение!");
            }
        }

        // Размытие
        private void btnBlurImage_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
              
                processedImage = originalImage.SmoothGaussian(15);
                pictureBoxProcessed.Image = processedImage.ToBitmap();
            }
            else
            {
                MessageBox.Show("Сначала загрузите изображение!");
            }
        }

        // Края
       
        private void btnEdgeDetection_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
               
                Image<Gray, byte> edges = originalImage.Convert<Gray, byte>(); 
                edges = edges.Canny(100, 200); 

                
                pictureBoxProcessed.Image = edges.ToBitmap();
            }
            else
            {
                MessageBox.Show("Сначала загрузите изображение!");
            }
        }

    }

}
