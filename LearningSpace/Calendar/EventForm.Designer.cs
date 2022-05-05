namespace LearningSpace
{
    partial class EventForm
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
            this.textDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.BOXperformanceEvaluation = new System.Windows.Forms.ComboBox();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonGoTOGrath = new System.Windows.Forms.Button();
            this.buttonGoToCreateEvent = new System.Windows.Forms.Button();
            this.labelCountEvent = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.comboBoxEvent = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // textDate
            // 
            this.textDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.textDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDate.Enabled = false;
            this.textDate.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.textDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.textDate.Location = new System.Drawing.Point(55, 35);
            this.textDate.Margin = new System.Windows.Forms.Padding(4);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(433, 31);
            this.textDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(51, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.buttonSave.Location = new System.Drawing.Point(701, 332);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 55);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // BOXperformanceEvaluation
            // 
            this.BOXperformanceEvaluation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.BOXperformanceEvaluation.DropDownHeight = 100;
            this.BOXperformanceEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOXperformanceEvaluation.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.BOXperformanceEvaluation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.BOXperformanceEvaluation.IntegralHeight = false;
            this.BOXperformanceEvaluation.ItemHeight = 23;
            this.BOXperformanceEvaluation.Location = new System.Drawing.Point(500, 99);
            this.BOXperformanceEvaluation.MaxDropDownItems = 5;
            this.BOXperformanceEvaluation.Name = "BOXperformanceEvaluation";
            this.BOXperformanceEvaluation.Size = new System.Drawing.Size(90, 31);
            this.BOXperformanceEvaluation.TabIndex = 18;
            this.BOXperformanceEvaluation.Text = "Hours";
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.buttonADD.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonADD.FlatAppearance.BorderSize = 0;
            this.buttonADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonADD.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonADD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.buttonADD.Location = new System.Drawing.Point(607, 332);
            this.buttonADD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(90, 55);
            this.buttonADD.TabIndex = 19;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonGoTOGrath
            // 
            this.buttonGoTOGrath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.buttonGoTOGrath.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonGoTOGrath.FlatAppearance.BorderSize = 0;
            this.buttonGoTOGrath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoTOGrath.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoTOGrath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.buttonGoTOGrath.Location = new System.Drawing.Point(607, 108);
            this.buttonGoTOGrath.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGoTOGrath.Name = "buttonGoTOGrath";
            this.buttonGoTOGrath.Size = new System.Drawing.Size(184, 105);
            this.buttonGoTOGrath.TabIndex = 20;
            this.buttonGoTOGrath.Text = "SHOW GRAPH";
            this.buttonGoTOGrath.UseVisualStyleBackColor = false;
            // 
            // buttonGoToCreateEvent
            // 
            this.buttonGoToCreateEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.buttonGoToCreateEvent.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonGoToCreateEvent.FlatAppearance.BorderSize = 0;
            this.buttonGoToCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoToCreateEvent.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoToCreateEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.buttonGoToCreateEvent.Location = new System.Drawing.Point(607, 221);
            this.buttonGoToCreateEvent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGoToCreateEvent.Name = "buttonGoToCreateEvent";
            this.buttonGoToCreateEvent.Size = new System.Drawing.Size(184, 105);
            this.buttonGoToCreateEvent.TabIndex = 21;
            this.buttonGoToCreateEvent.Text = "CREATE NEW EVENT";
            this.buttonGoToCreateEvent.UseVisualStyleBackColor = false;
            this.buttonGoToCreateEvent.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCountEvent
            // 
            this.labelCountEvent.AutoSize = true;
            this.labelCountEvent.BackColor = System.Drawing.Color.Transparent;
            this.labelCountEvent.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.labelCountEvent.Location = new System.Drawing.Point(15, 100);
            this.labelCountEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountEvent.Name = "labelCountEvent";
            this.labelCountEvent.Size = new System.Drawing.Size(30, 33);
            this.labelCountEvent.TabIndex = 23;
            this.labelCountEvent.Text = "1";
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
            this.pictureBoxClose.TabIndex = 16;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_);
            // 
            // comboBoxEvent
            // 
            this.comboBoxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.comboBoxEvent.DropDownHeight = 100;
            this.comboBoxEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEvent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.comboBoxEvent.IntegralHeight = false;
            this.comboBoxEvent.ItemHeight = 23;
            this.comboBoxEvent.Location = new System.Drawing.Point(52, 99);
            this.comboBoxEvent.MaxDropDownItems = 5;
            this.comboBoxEvent.Name = "comboBoxEvent";
            this.comboBoxEvent.Size = new System.Drawing.Size(438, 31);
            this.comboBoxEvent.TabIndex = 24;
            this.comboBoxEvent.Text = "Your event";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.button1.Location = new System.Drawing.Point(607, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 55);
            this.button1.TabIndex = 25;
            this.button1.Text = "DELETE ALL ?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(102)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxEvent);
            this.Controls.Add(this.labelCountEvent);
            this.Controls.Add(this.buttonGoToCreateEvent);
            this.Controls.Add(this.buttonGoTOGrath);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.BOXperformanceEvaluation);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.ComboBox BOXperformanceEvaluation;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonGoTOGrath;
        private System.Windows.Forms.Button buttonGoToCreateEvent;
        private System.Windows.Forms.Label labelCountEvent;
        private System.Windows.Forms.ComboBox comboBoxEvent;
        private System.Windows.Forms.Button button1;
    }
}