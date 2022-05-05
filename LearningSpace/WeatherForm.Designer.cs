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
            this.Погода = new System.Windows.Forms.GroupBox();
            this.groupBoxВетер = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelПогода = new System.Windows.Forms.Panel();
            this.BackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherClose)).BeginInit();
            this.Погода.SuspendLayout();
            this.groupBoxВетер.SuspendLayout();
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
            // Погода
            // 
            this.Погода.Controls.Add(this.BackToMenu);
            this.Погода.Controls.Add(this.groupBoxВетер);
            this.Погода.Controls.Add(this.label5);
            this.Погода.Controls.Add(this.label4);
            this.Погода.Controls.Add(this.label3);
            this.Погода.Controls.Add(this.label2);
            this.Погода.Controls.Add(this.label1);
            this.Погода.Controls.Add(this.panelПогода);
            this.Погода.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.Погода.ForeColor = System.Drawing.SystemColors.Info;
            this.Погода.Location = new System.Drawing.Point(12, 37);
            this.Погода.Name = "Погода";
            this.Погода.Size = new System.Drawing.Size(876, 479);
            this.Погода.TabIndex = 16;
            this.Погода.TabStop = false;
            this.Погода.Text = "Погода";
            // 
            // groupBoxВетер
            // 
            this.groupBoxВетер.Controls.Add(this.label7);
            this.groupBoxВетер.Controls.Add(this.label6);
            this.groupBoxВетер.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBoxВетер.Location = new System.Drawing.Point(6, 271);
            this.groupBoxВетер.Name = "groupBoxВетер";
            this.groupBoxВетер.Size = new System.Drawing.Size(300, 202);
            this.groupBoxВетер.TabIndex = 21;
            this.groupBoxВетер.TabStop = false;
            this.groupBoxВетер.Text = "Ветер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(18, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(18, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(464, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(464, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(360, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(271, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(271, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panelПогода
            // 
            this.panelПогода.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelПогода.Location = new System.Drawing.Point(6, 19);
            this.panelПогода.Name = "panelПогода";
            this.panelПогода.Size = new System.Drawing.Size(210, 210);
            this.panelПогода.TabIndex = 0;
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.BackToMenu.FlatAppearance.BorderSize = 0;
            this.BackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMenu.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMenu.ForeColor = System.Drawing.SystemColors.Info;
            this.BackToMenu.Location = new System.Drawing.Point(683, 417);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(193, 62);
            this.BackToMenu.TabIndex = 22;
            this.BackToMenu.Text = "BACK TO MENU";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.backToMenuWeather);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 528);
            this.Controls.Add(this.Погода);
            this.Controls.Add(this.pictureBoxWeatherClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeatherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherForm";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherClose)).EndInit();
            this.Погода.ResumeLayout(false);
            this.Погода.PerformLayout();
            this.groupBoxВетер.ResumeLayout(false);
            this.groupBoxВетер.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWeatherClose;
        private System.Windows.Forms.GroupBox Погода;
        private System.Windows.Forms.GroupBox groupBoxВетер;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelПогода;
        private System.Windows.Forms.Button BackToMenu;
    }
}