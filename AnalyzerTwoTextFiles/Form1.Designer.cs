namespace AnalyzerTwoTextFiles
{
    partial class Form1
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
            this.btn_generation = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_generation
            // 
            this.btn_generation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_generation.FlatAppearance.BorderSize = 0;
            this.btn_generation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generation.Location = new System.Drawing.Point(288, 1);
            this.btn_generation.Name = "btn_generation";
            this.btn_generation.Size = new System.Drawing.Size(98, 34);
            this.btn_generation.TabIndex = 0;
            this.btn_generation.Text = "Проверить";
            this.btn_generation.UseVisualStyleBackColor = true;
            this.btn_generation.Click += new System.EventHandler(this.btn_generation_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.GridLines = true;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(288, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(395, 163);
            this.listView1.TabIndex = 2;
            this.listView1.TileSize = new System.Drawing.Size(3000, 42);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(-1, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 203);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "C# (произносится «си шарп») —\r\nРазработан группой инженеров\r\nпод руководством Анд" +
    "ерса Хейлсберга\r\nв компании Microsoft";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 206);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_generation);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа анализирует два текстовых файла.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generation;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

