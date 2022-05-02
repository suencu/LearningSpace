namespace LearningSpace
{
    partial class WeatherForm
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
            this.pictureBoxWeatherClose = new System.Windows.Forms.PictureBox();
            this.WeatherTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWeatherClose
            // 
            this.pictureBoxWeatherClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWeatherClose.BackgroundImage = global::LearningSpace.Properties.Resources.cancel;
            this.pictureBoxWeatherClose.Image = global::LearningSpace.Properties.Resources.cancel;
            this.pictureBoxWeatherClose.Location = new System.Drawing.Point(870, 0);
            this.pictureBoxWeatherClose.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxWeatherClose.Name = "pictureBoxWeatherClose";
            this.pictureBoxWeatherClose.Size = new System.Drawing.Size(30, 24);
            this.pictureBoxWeatherClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWeatherClose.TabIndex = 14;
            this.pictureBoxWeatherClose.TabStop = false;
            this.pictureBoxWeatherClose.Click += new System.EventHandler(this.PictureBoxWeatherClose);
            // 
            // WeatherTextBox
            // 
            this.WeatherTextBox.Location = new System.Drawing.Point(143, 72);
            this.WeatherTextBox.Multiline = true;
            this.WeatherTextBox.Name = "WeatherTextBox";
            this.WeatherTextBox.Size = new System.Drawing.Size(577, 192);
            this.WeatherTextBox.TabIndex = 15;
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(900, 528);
            this.Controls.Add(this.WeatherTextBox);
            this.Controls.Add(this.pictureBoxWeatherClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeatherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherForm";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWeatherClose;
        private System.Windows.Forms.TextBox WeatherTextBox;
    }
}