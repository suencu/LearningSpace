namespace LearningSpace
{
    partial class RegisterForm
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
            this.picturePassowrd = new System.Windows.Forms.PictureBox();
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.buttonAutorization = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkPasswordBox = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxForPassword = new System.Windows.Forms.CheckBox();
            this.buttonForIgor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassowrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LearningSpace.Properties.Resources.icons8_unlock_48;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(49, 323);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // picturePassowrd
            // 
            this.picturePassowrd.BackColor = System.Drawing.Color.Transparent;
            this.picturePassowrd.BackgroundImage = global::LearningSpace.Properties.Resources.icons8_lock_48;
            this.picturePassowrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturePassowrd.Location = new System.Drawing.Point(49, 235);
            this.picturePassowrd.Margin = new System.Windows.Forms.Padding(4);
            this.picturePassowrd.Name = "picturePassowrd";
            this.picturePassowrd.Size = new System.Drawing.Size(63, 59);
            this.picturePassowrd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePassowrd.TabIndex = 12;
            this.picturePassowrd.TabStop = false;
            // 
            // pictureLogin
            // 
            this.pictureLogin.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogin.BackgroundImage = global::LearningSpace.Properties.Resources.icons8_user_48;
            this.pictureLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureLogin.Location = new System.Drawing.Point(49, 159);
            this.pictureLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(63, 59);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogin.TabIndex = 11;
            this.pictureLogin.TabStop = false;
            // 
            // buttonAutorization
            // 
            this.buttonAutorization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAutorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(196)))), ((int)(((byte)(120)))));
            this.buttonAutorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutorization.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAutorization.FlatAppearance.BorderSize = 0;
            this.buttonAutorization.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAutorization.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAutorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutorization.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutorization.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAutorization.Location = new System.Drawing.Point(118, 416);
            this.buttonAutorization.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAutorization.Name = "buttonAutorization";
            this.buttonAutorization.Size = new System.Drawing.Size(523, 46);
            this.buttonAutorization.TabIndex = 20;
            this.buttonAutorization.Text = "AUTHORIZATION";
            this.buttonAutorization.UseVisualStyleBackColor = false;
            this.buttonAutorization.Click += new System.EventHandler(this.GoToAuthorization);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRegister.Location = new System.Drawing.Point(118, 481);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(525, 46);
            this.buttonRegister.TabIndex = 24;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.GoToMenu);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(132)))), ((int)(((byte)(152)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.passwordBox.Location = new System.Drawing.Point(120, 238);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(523, 56);
            this.passwordBox.TabIndex = 23;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // loginBox
            // 
            this.loginBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(132)))), ((int)(((byte)(152)))));
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginBox.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.loginBox.Location = new System.Drawing.Point(120, 159);
            this.loginBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(523, 56);
            this.loginBox.TabIndex = 22;
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginBox.Enter += new System.EventHandler(this.loginBox_Enter);
            this.loginBox.Leave += new System.EventHandler(this.loginBox_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 62);
            this.label1.TabIndex = 21;
            this.label1.Text = "REGISTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkPasswordBox
            // 
            this.checkPasswordBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(132)))), ((int)(((byte)(152)))));
            this.checkPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkPasswordBox.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.checkPasswordBox.Location = new System.Drawing.Point(122, 326);
            this.checkPasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkPasswordBox.Name = "checkPasswordBox";
            this.checkPasswordBox.Size = new System.Drawing.Size(523, 56);
            this.checkPasswordBox.TabIndex = 25;
            this.checkPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.checkPasswordBox.Enter += new System.EventHandler(this.checkPasswordBox_Enter);
            this.checkPasswordBox.Leave += new System.EventHandler(this.checkPasswordBox_Leave);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Image = global::LearningSpace.Properties.Resources.cancel;
            this.pictureBoxClose.Location = new System.Drawing.Point(660, 0);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 27;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.DoubleClick += new System.EventHandler(this.CloseMenu);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Image = global::LearningSpace.Properties.Resources.minus;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(620, 0);
            this.pictureBoxMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 26;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.MinimizeAdd);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.checkBoxForPassword);
            this.panel1.Controls.Add(this.buttonForIgor);
            this.panel1.Controls.Add(this.pictureLogin);
            this.panel1.Controls.Add(this.picturePassowrd);
            this.panel1.Controls.Add(this.checkPasswordBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonAutorization);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.loginBox);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 717);
            this.panel1.TabIndex = 28;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // checkBoxForPassword
            // 
            this.checkBoxForPassword.AutoSize = true;
            this.checkBoxForPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(229)))), ((int)(((byte)(191)))));
            this.checkBoxForPassword.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold);
            this.checkBoxForPassword.Location = new System.Drawing.Point(361, 552);
            this.checkBoxForPassword.Name = "checkBoxForPassword";
            this.checkBoxForPassword.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.checkBoxForPassword.Size = new System.Drawing.Size(280, 47);
            this.checkBoxForPassword.TabIndex = 29;
            this.checkBoxForPassword.Text = "SHOW PASSWORD?";
            this.checkBoxForPassword.UseVisualStyleBackColor = false;
            this.checkBoxForPassword.Click += new System.EventHandler(this.checkBoxForPassword_Click);
            // 
            // buttonForIgor
            // 
            this.buttonForIgor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonForIgor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.buttonForIgor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonForIgor.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonForIgor.FlatAppearance.BorderSize = 0;
            this.buttonForIgor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonForIgor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonForIgor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForIgor.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForIgor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonForIgor.Location = new System.Drawing.Point(408, 623);
            this.buttonForIgor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonForIgor.Name = "buttonForIgor";
            this.buttonForIgor.Size = new System.Drawing.Size(233, 47);
            this.buttonForIgor.TabIndex = 28;
            this.buttonForIgor.Text = "FOR IGOR";
            this.buttonForIgor.UseVisualStyleBackColor = false;
            this.buttonForIgor.Click += new System.EventHandler(this.buttonForIgor_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(700, 750);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassowrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picturePassowrd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.Button buttonAutorization;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox checkPasswordBox;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonForIgor;
        private System.Windows.Forms.CheckBox checkBoxForPassword;
    }
}