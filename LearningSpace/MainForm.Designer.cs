namespace LearningSpace
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.picturePassowrd = new System.Windows.Forms.PictureBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassowrd)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(385, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "ENTRY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GoToMenu);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(342, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureLogin
            // 
            this.pictureLogin.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureLogin.Location = new System.Drawing.Point(245, 200);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(47, 40);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogin.TabIndex = 2;
            this.pictureLogin.TabStop = false;
            // 
            // picturePassowrd
            // 
            this.picturePassowrd.BackColor = System.Drawing.Color.SlateBlue;
            this.picturePassowrd.Location = new System.Drawing.Point(245, 262);
            this.picturePassowrd.Name = "picturePassowrd";
            this.picturePassowrd.Size = new System.Drawing.Size(47, 40);
            this.picturePassowrd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePassowrd.TabIndex = 3;
            this.picturePassowrd.TabStop = false;
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loginBox.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(314, 200);
            this.loginBox.Multiline = true;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(318, 40);
            this.loginBox.TabIndex = 4;
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordBox.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(314, 262);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(318, 40);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(854, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.CloseApp);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(811, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.MinimizeAdd);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.picturePassowrd);
            this.Controls.Add(this.pictureLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassowrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.PictureBox picturePassowrd;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

