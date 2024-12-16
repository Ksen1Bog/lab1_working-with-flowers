namespace Redactor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnProcessImage = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnRotateImage = new System.Windows.Forms.Button(); 
            this.btnAdjustBrightness = new System.Windows.Forms.Button(); 
            this.btnBlurImage = new System.Windows.Forms.Button(); 
            this.btnEdgeDetection = new System.Windows.Forms.Button(); 
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxProcessed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).BeginInit();
            this.SuspendLayout();

          
            this.btnLoadImage.Location = new System.Drawing.Point(12, 12);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(150, 30);
            this.btnLoadImage.Text = "Загрузить изображение";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);

           
            this.btnProcessImage.Location = new System.Drawing.Point(12, 48);
            this.btnProcessImage.Name = "btnProcessImage";
            this.btnProcessImage.Size = new System.Drawing.Size(150, 30);
            this.btnProcessImage.Text = "Обработать изображение";
            this.btnProcessImage.UseVisualStyleBackColor = true;
            this.btnProcessImage.Click += new System.EventHandler(this.btnProcessImage_Click);

           
            this.btnSaveImage.Location = new System.Drawing.Point(12, 84);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(150, 30);
            this.btnSaveImage.Text = "Сохранить изображение";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);

           
            this.btnRotateImage.Location = new System.Drawing.Point(12, 120);
            this.btnRotateImage.Name = "btnRotateImage";
            this.btnRotateImage.Size = new System.Drawing.Size(150, 30);
            this.btnRotateImage.Text = "Повернуть изображение";
            this.btnRotateImage.UseVisualStyleBackColor = true;
            this.btnRotateImage.Click += new System.EventHandler(this.btnRotateImage_Click);

            this.btnAdjustBrightness.Location = new System.Drawing.Point(12, 156);
            this.btnAdjustBrightness.Name = "btnAdjustBrightness";
            this.btnAdjustBrightness.Size = new System.Drawing.Size(150, 30);
            this.btnAdjustBrightness.Text = "Изменить яркость";
            this.btnAdjustBrightness.UseVisualStyleBackColor = true;
            this.btnAdjustBrightness.Click += new System.EventHandler(this.btnAdjustBrightness_Click);

           
            this.btnBlurImage.Location = new System.Drawing.Point(12, 192);
            this.btnBlurImage.Name = "btnBlurImage";
            this.btnBlurImage.Size = new System.Drawing.Size(150, 30);
            this.btnBlurImage.Text = "Размыть изображение";
            this.btnBlurImage.UseVisualStyleBackColor = true;
            this.btnBlurImage.Click += new System.EventHandler(this.btnBlurImage_Click);

          
            this.btnEdgeDetection.Location = new System.Drawing.Point(12, 228);
            this.btnEdgeDetection.Name = "btnEdgeDetection";
            this.btnEdgeDetection.Size = new System.Drawing.Size(150, 30);
            this.btnEdgeDetection.Text = "Обнаружение краев";
            this.btnEdgeDetection.UseVisualStyleBackColor = true;
            this.btnEdgeDetection.Click += new System.EventHandler(this.btnEdgeDetection_Click);

            
            this.pictureBoxOriginal.Location = new System.Drawing.Point(200, 12);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.pictureBoxProcessed.Location = new System.Drawing.Point(620, 12);
            this.pictureBoxProcessed.Name = "pictureBoxProcessed";
            this.pictureBoxProcessed.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

           
            this.ClientSize = new System.Drawing.Size(1040, 330);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnProcessImage);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnRotateImage);
            this.Controls.Add(this.btnAdjustBrightness);
            this.Controls.Add(this.btnBlurImage);
            this.Controls.Add(this.btnEdgeDetection);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.pictureBoxProcessed);
            this.Name = "MainForm";
            this.Text = "Обработка изображений с использованием EmguCV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).EndInit();
            this.ResumeLayout(false);
        }


        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnProcessImage;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxProcessed;
        private System.Windows.Forms.Button btnRotateImage;
        private System.Windows.Forms.Button btnAdjustBrightness;
        private System.Windows.Forms.Button btnBlurImage;
        private System.Windows.Forms.Button btnEdgeDetection;

    }
}

