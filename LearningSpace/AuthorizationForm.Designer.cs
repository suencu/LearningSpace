namespace LearningSpace
{
    partial class AuthorizationForm
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.picturePassowrd = new System.Windows.Forms.PictureBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassowrd)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLogin.BackColor = System.Drawing.Color.SlateGray;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogin.Location = new System.Drawing.Point(225, 331);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(160, 62);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "ENTRY";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.GoToMenu);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(319, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureLogin
            // 
            this.pictureLogin.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureLogin.InitialImage = null;
            this.pictureLogin.Location = new System.Drawing.Point(170, 159);
            this.pictureLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(63, 49);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogin.TabIndex = 2;
            this.pictureLogin.TabStop = false;
            // 
            // picturePassowrd
            // 
            this.picturePassowrd.BackColor = System.Drawing.Color.SlateBlue;
            this.picturePassowrd.Location = new System.Drawing.Point(170, 245);
            this.picturePassowrd.Margin = new System.Windows.Forms.Padding(4);
            this.picturePassowrd.Name = "picturePassowrd";
            this.picturePassowrd.Size = new System.Drawing.Size(63, 49);
            this.picturePassowrd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePassowrd.TabIndex = 3;
            this.picturePassowrd.TabStop = false;
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loginBox.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(254, 159);
            this.loginBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginBox.Multiline = true;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(423, 48);
            this.loginBox.TabIndex = 4;
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginBox.Enter += new System.EventHandler(this.loginBox_Enter);
            this.loginBox.Leave += new System.EventHandler(this.loginBox_Leave);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordBox.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(254, 245);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(423, 48);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClose.Location = new System.Drawing.Point(840, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 39);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.CloseApp);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonMinimize.BackColor = System.Drawing.Color.Silver;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMinimize.Location = new System.Drawing.Point(785, 0);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(61, 39);
            this.buttonMinimize.TabIndex = 8;
            this.buttonMinimize.Text = "-";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.MinimizeAdd);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(448, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "REGISTER?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GoToRegister);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.picturePassowrd);
            this.Controls.Add(this.pictureLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogin);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizationForm";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassowrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.PictureBox picturePassowrd;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button button1;
    }
}

