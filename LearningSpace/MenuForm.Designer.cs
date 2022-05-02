namespace LearningSpace
{
    partial class MenuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMaximaze = new System.Windows.Forms.Button();
            this.buttonTestMenu = new System.Windows.Forms.Button();
            this.buttonCalender = new System.Windows.Forms.Button();
            this.buttonWeather = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximaze = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.buttonMaximaze);
            this.panel1.Controls.Add(this.buttonTestMenu);
            this.panel1.Controls.Add(this.buttonCalender);
            this.panel1.Controls.Add(this.buttonWeather);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 500);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonMaximaze
            // 
            this.buttonMaximaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximaze.BackgroundImage = global::LearningSpace.Properties.Resources.maximize;
            this.buttonMaximaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximaze.Location = new System.Drawing.Point(836, -182);
            this.buttonMaximaze.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMaximaze.Name = "buttonMaximaze";
            this.buttonMaximaze.Size = new System.Drawing.Size(34, 27);
            this.buttonMaximaze.TabIndex = 7;
            this.buttonMaximaze.UseVisualStyleBackColor = true;
            // 
            // buttonTestMenu
            // 
            this.buttonTestMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(115)))), ((int)(((byte)(57)))));
            this.buttonTestMenu.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonTestMenu.FlatAppearance.BorderSize = 0;
            this.buttonTestMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTestMenu.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTestMenu.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonTestMenu.Location = new System.Drawing.Point(492, 246);
            this.buttonTestMenu.Name = "buttonTestMenu";
            this.buttonTestMenu.Size = new System.Drawing.Size(198, 219);
            this.buttonTestMenu.TabIndex = 4;
            this.buttonTestMenu.Text = "TestMenu";
            this.buttonTestMenu.UseVisualStyleBackColor = false;
            this.buttonTestMenu.Click += new System.EventHandler(this.buttonTestMenu_Click);
            // 
            // buttonCalender
            // 
            this.buttonCalender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCalender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.buttonCalender.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCalender.FlatAppearance.BorderSize = 0;
            this.buttonCalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalender.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalender.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonCalender.Location = new System.Drawing.Point(208, 246);
            this.buttonCalender.Name = "buttonCalender";
            this.buttonCalender.Size = new System.Drawing.Size(198, 219);
            this.buttonCalender.TabIndex = 3;
            this.buttonCalender.Text = "Calender";
            this.buttonCalender.UseVisualStyleBackColor = false;
            this.buttonCalender.Click += new System.EventHandler(this.buttonCalender_Click);
            // 
            // buttonWeather
            // 
            this.buttonWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(75)))), ((int)(((byte)(201)))));
            this.buttonWeather.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonWeather.FlatAppearance.BorderSize = 0;
            this.buttonWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeather.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWeather.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonWeather.Location = new System.Drawing.Point(642, 3);
            this.buttonWeather.Name = "buttonWeather";
            this.buttonWeather.Size = new System.Drawing.Size(198, 219);
            this.buttonWeather.TabIndex = 2;
            this.buttonWeather.Text = "Weather";
            this.buttonWeather.UseVisualStyleBackColor = false;
            this.buttonWeather.Click += new System.EventHandler(this.buttonWeather_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(84)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(349, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 219);
            this.button2.TabIndex = 1;
            this.button2.Text = "Graph";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(187)))), ((int)(((byte)(115)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(63, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 219);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nodes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNodes_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.pictureBoxClose.Image = global::LearningSpace.Properties.Resources.minus;
            this.pictureBoxClose.Location = new System.Drawing.Point(1160, 0);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 10;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClose_MouseDoubleClick);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Image = global::LearningSpace.Properties.Resources.minus;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(1120, 0);
            this.pictureBoxMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 9;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // pictureBoxMaximaze
            // 
            this.pictureBoxMaximaze.Image = global::LearningSpace.Properties.Resources.maximize;
            this.pictureBoxMaximaze.Location = new System.Drawing.Point(1080, 0);
            this.pictureBoxMaximaze.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxMaximaze.Name = "pictureBoxMaximaze";
            this.pictureBoxMaximaze.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxMaximaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaximaze.TabIndex = 8;
            this.pictureBoxMaximaze.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.pictureBox1.BackgroundImage = global::LearningSpace.Properties.Resources.cancel;
            this.pictureBox1.Image = global::LearningSpace.Properties.Resources.cancel;
            this.pictureBox1.Location = new System.Drawing.Point(870, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClose_MouseDoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LearningSpace.Properties.Resources.minus;
            this.pictureBox2.Location = new System.Drawing.Point(840, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(900, 528);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxMaximaze);
            this.Controls.Add(this.pictureBoxMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuForm_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTestMenu;
        private System.Windows.Forms.Button buttonCalender;
        private System.Windows.Forms.Button buttonMaximaze;
        private System.Windows.Forms.Button buttonWeather;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxMaximaze;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}