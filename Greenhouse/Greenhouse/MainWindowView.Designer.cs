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
            this.listsPlan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createNewPlan
            // 
            this.createNewPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewPlan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createNewPlan.Location = new System.Drawing.Point(84, 40);
            this.createNewPlan.Margin = new System.Windows.Forms.Padding(2);
            this.createNewPlan.Name = "createNewPlan";
            this.createNewPlan.Size = new System.Drawing.Size(182, 37);
            this.createNewPlan.TabIndex = 0;
            this.createNewPlan.Text = "Создать новый план";
            this.createNewPlan.UseVisualStyleBackColor = true;
            this.createNewPlan.Click += new System.EventHandler(this.button1_Click);
            // 
            // listsPlan
            // 
            this.listsPlan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listsPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listsPlan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listsPlan.FormattingEnabled = true;
            this.listsPlan.Location = new System.Drawing.Point(84, 81);
            this.listsPlan.Margin = new System.Windows.Forms.Padding(2);
            this.listsPlan.Name = "listsPlan";
            this.listsPlan.Size = new System.Drawing.Size(182, 21);
            this.listsPlan.TabIndex = 1;
            this.listsPlan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(26, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 119);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отобразить теплицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(197, 153);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 119);
            this.button2.TabIndex = 3;
            this.button2.Text = "   Стартовать     цикл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(356, 356);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listsPlan);
            this.Controls.Add(this.createNewPlan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "window";
            this.Text = "Теплица";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createNewPlan;
        private System.Windows.Forms.ComboBox listsPlan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

