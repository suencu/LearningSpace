namespace LearningSpace
{
    partial class Nodes
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
            this.nodesToMenu = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonNewNotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nodesToMenu
            // 
            this.nodesToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nodesToMenu.Font = new System.Drawing.Font("Algerian", 27.75F);
            this.nodesToMenu.ForeColor = System.Drawing.SystemColors.Info;
            this.nodesToMenu.Location = new System.Drawing.Point(500, 306);
            this.nodesToMenu.Name = "nodesToMenu";
            this.nodesToMenu.Size = new System.Drawing.Size(150, 50);
            this.nodesToMenu.TabIndex = 0;
            this.nodesToMenu.Text = "Menu";
            this.nodesToMenu.UseVisualStyleBackColor = false;
            this.nodesToMenu.Click += new System.EventHandler(this.nodesToMenu_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(2, 27);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // buttonNewNotes
            // 
            this.buttonNewNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNewNotes.Font = new System.Drawing.Font("Algerian", 27.75F);
            this.buttonNewNotes.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonNewNotes.Location = new System.Drawing.Point(500, 247);
            this.buttonNewNotes.Name = "buttonNewNotes";
            this.buttonNewNotes.Size = new System.Drawing.Size(150, 50);
            this.buttonNewNotes.TabIndex = 2;
            this.buttonNewNotes.Text = "new";
            this.buttonNewNotes.UseVisualStyleBackColor = false;
            this.buttonNewNotes.Click += new System.EventHandler(this.buttonNewNotes_Click);
            // 
            // Nodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(662, 368);
            this.Controls.Add(this.buttonNewNotes);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.nodesToMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Nodes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nodes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nodesToMenu;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonNewNotes;
    }
}