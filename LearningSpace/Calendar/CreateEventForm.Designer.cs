namespace LearningSpace.CreateEvent
{
    partial class CreateEventForm
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
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usersEvent = new System.Windows.Forms.TextBox();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonGoToCalender = new yt_DesignUI.yt_Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.BackgroundImage = global::LearningSpace.Properties.Resources.cancel;
            this.pictureBoxClose.Image = global::LearningSpace.Properties.Resources.cancel;
            this.pictureBoxClose.Location = new System.Drawing.Point(760, 0);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 17;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.DoubleClick += new System.EventHandler(this.pictureBoxClose_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter your event";
            // 
            // usersEvent
            // 
            this.usersEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.usersEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersEvent.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.usersEvent.Location = new System.Drawing.Point(50, 59);
            this.usersEvent.Margin = new System.Windows.Forms.Padding(4);
            this.usersEvent.Name = "usersEvent";
            this.usersEvent.Size = new System.Drawing.Size(382, 39);
            this.usersEvent.TabIndex = 18;
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.buttonADD.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonADD.FlatAppearance.BorderSize = 0;
            this.buttonADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonADD.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonADD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.buttonADD.Location = new System.Drawing.Point(524, 332);
            this.buttonADD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(121, 55);
            this.buttonADD.TabIndex = 21;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.buttonSave.Location = new System.Drawing.Point(666, 332);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 55);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.labelCount.Location = new System.Drawing.Point(12, 59);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(35, 38);
            this.labelCount.TabIndex = 22;
            this.labelCount.Text = "1";
            // 
            // buttonGoToCalender
            // 
            this.buttonGoToCalender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.buttonGoToCalender.BackColorAdditional = System.Drawing.Color.Transparent;
            this.buttonGoToCalender.BackColorGradientEnabled = false;
            this.buttonGoToCalender.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonGoToCalender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.buttonGoToCalender.BorderColorEnabled = true;
            this.buttonGoToCalender.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.buttonGoToCalender.BorderColorOnHoverEnabled = true;
            this.buttonGoToCalender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoToCalender.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoToCalender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.buttonGoToCalender.Location = new System.Drawing.Point(524, 161);
            this.buttonGoToCalender.Name = "buttonGoToCalender";
            this.buttonGoToCalender.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.buttonGoToCalender.Rounding = 60;
            this.buttonGoToCalender.RoundingEnable = true;
            this.buttonGoToCalender.Size = new System.Drawing.Size(263, 152);
            this.buttonGoToCalender.TabIndex = 23;
            this.buttonGoToCalender.Text = "Go To Calendar";
            this.buttonGoToCalender.TextHover = "Откроется календарь";
            this.buttonGoToCalender.UseDownPressEffectOnClick = false;
            this.buttonGoToCalender.UseRippleEffect = true;
            this.buttonGoToCalender.UseZoomEffectOnHover = false;
            this.buttonGoToCalender.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.button1.Location = new System.Drawing.Point(524, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 55);
            this.button1.TabIndex = 24;
            this.button1.Text = "DELETE ALL ?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(102)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGoToCalender);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersEvent);
            this.Controls.Add(this.pictureBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateEventForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usersEvent;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCount;
        private yt_DesignUI.yt_Button buttonGoToCalender;
        private System.Windows.Forms.Button button1;
    }
}