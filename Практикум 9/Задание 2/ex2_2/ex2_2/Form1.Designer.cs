namespace ex2_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputK1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.inputK2 = new System.Windows.Forms.NumericUpDown();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputK1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputK2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный текст файла:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(15, 41);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(498, 170);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите k1 =";
            // 
            // inputK1
            // 
            this.inputK1.Location = new System.Drawing.Point(116, 228);
            this.inputK1.Name = "inputK1";
            this.inputK1.Size = new System.Drawing.Size(68, 26);
            this.inputK1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "и k2 =";
            // 
            // inputK2
            // 
            this.inputK2.Location = new System.Drawing.Point(247, 228);
            this.inputK2.Name = "inputK2";
            this.inputK2.Size = new System.Drawing.Size(68, 26);
            this.inputK2.TabIndex = 5;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 268);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(498, 144);
            this.outputBox.TabIndex = 6;
            this.outputBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(525, 424);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputK2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputK1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Практикум 9 | Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.inputK1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputK2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputK1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputK2;
        private System.Windows.Forms.RichTextBox outputBox;
    }
}

