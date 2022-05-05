namespace LearningSpace
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDays = new System.Windows.Forms.Label();
            this.labelCountOfEvenr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDays.Location = new System.Drawing.Point(13, 11);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(32, 23);
            this.labelDays.TabIndex = 0;
            this.labelDays.Text = "00";
            // 
            // labelCountOfEvenr
            // 
            this.labelCountOfEvenr.AutoSize = true;
            this.labelCountOfEvenr.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelCountOfEvenr.Location = new System.Drawing.Point(57, 44);
            this.labelCountOfEvenr.Name = "labelCountOfEvenr";
            this.labelCountOfEvenr.Size = new System.Drawing.Size(0, 23);
            this.labelCountOfEvenr.TabIndex = 1;
            this.labelCountOfEvenr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.labelCountOfEvenr);
            this.Controls.Add(this.labelDays);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(150, 82);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserControlDays_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelCountOfEvenr;
    }
}
