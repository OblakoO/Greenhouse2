namespace Greenhouse
{
    partial class MainWindowView
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowView));
            this.createNewPlan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createNewPlan
            // 
            this.createNewPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewPlan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createNewPlan.Location = new System.Drawing.Point(87, 84);
            this.createNewPlan.Margin = new System.Windows.Forms.Padding(2);
            this.createNewPlan.Name = "createNewPlan";
            this.createNewPlan.Size = new System.Drawing.Size(182, 182);
            this.createNewPlan.TabIndex = 0;
            this.createNewPlan.Text = "Создать новый план";
            this.createNewPlan.UseVisualStyleBackColor = true;
            this.createNewPlan.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(356, 356);
            this.Controls.Add(this.createNewPlan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindowView";
            this.Text = "Теплица";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createNewPlan;
    }
}

