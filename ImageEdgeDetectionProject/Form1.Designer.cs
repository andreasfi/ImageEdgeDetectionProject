namespace ImageEdgeDetectionProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addImage = new System.Windows.Forms.Button();
            this.applyFilter = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(896, 708);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addImage
            // 
            this.addImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImage.Location = new System.Drawing.Point(24, 740);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(120, 50);
            this.addImage.TabIndex = 4;
            this.addImage.Text = "Add Image";
            this.addImage.UseVisualStyleBackColor = false;
            this.addImage.Click += new System.EventHandler(this.addImage_Click);
            // 
            // applyFilter
            // 
            this.applyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.applyFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.applyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyFilter.Location = new System.Drawing.Point(165, 740);
            this.applyFilter.Name = "applyFilter";
            this.applyFilter.Size = new System.Drawing.Size(120, 50);
            this.applyFilter.TabIndex = 5;
            this.applyFilter.Text = "Apply Filter";
            this.applyFilter.UseVisualStyleBackColor = false;
            this.applyFilter.Click += new System.EventHandler(this.applyFilter_Click);
            // 
            // saveImage
            // 
            this.saveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveImage.Location = new System.Drawing.Point(307, 740);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(120, 50);
            this.saveImage.TabIndex = 6;
            this.saveImage.Text = "Save Image";
            this.saveImage.UseVisualStyleBackColor = false;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 799);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.applyFilter);
            this.Controls.Add(this.addImage);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.Button applyFilter;
        private System.Windows.Forms.Button saveImage;
    }
}