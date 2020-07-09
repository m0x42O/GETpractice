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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputA = new System.Windows.Forms.NumericUpDown();
            this.inputB = new System.Windows.Forms.NumericUpDown();
            this.inputH = new System.Windows.Forms.NumericUpDown();
            this.result = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заполните данные для построения таблицы значений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "a =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "b =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "h =";
            // 
            // inputA
            // 
            this.inputA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputA.Location = new System.Drawing.Point(74, 62);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(59, 26);
            this.inputA.TabIndex = 4;
            // 
            // inputB
            // 
            this.inputB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputB.Location = new System.Drawing.Point(74, 105);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(59, 26);
            this.inputB.TabIndex = 5;
            // 
            // inputH
            // 
            this.inputH.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputH.Location = new System.Drawing.Point(74, 148);
            this.inputH.Name = "inputH";
            this.inputH.Size = new System.Drawing.Size(59, 26);
            this.inputH.TabIndex = 6;
            // 
            // result
            // 
            this.result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.result.Location = new System.Drawing.Point(174, 103);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 28);
            this.result.TabIndex = 7;
            this.result.Text = "вычислить";
            this.result.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.output.Location = new System.Drawing.Point(312, 62);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(150, 112);
            this.output.TabIndex = 8;
            this.output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(498, 208);
            this.Controls.Add(this.output);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputH);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Практикум 3 | Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inputA;
        private System.Windows.Forms.NumericUpDown inputB;
        private System.Windows.Forms.NumericUpDown inputH;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.RichTextBox output;
    }
}

