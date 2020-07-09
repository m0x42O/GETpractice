namespace ex3_2
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
            this.inputA = new System.Windows.Forms.NumericUpDown();
            this.inputB = new System.Windows.Forms.NumericUpDown();
            this.button = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кубы всех целых чисел из диапазона от A до B в обратном порядке";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "A =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "B =";
            // 
            // inputA
            // 
            this.inputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputA.Location = new System.Drawing.Point(82, 59);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(71, 22);
            this.inputA.TabIndex = 3;
            // 
            // inputB
            // 
            this.inputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputB.Location = new System.Drawing.Point(82, 95);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(71, 22);
            this.inputB.TabIndex = 4;
            // 
            // button
            // 
            this.button.AutoSize = true;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(53, 134);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 26);
            this.button.TabIndex = 5;
            this.button.Text = "вывести";
            this.button.UseVisualStyleBackColor = true;
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.ForeColor = System.Drawing.SystemColors.Window;
            this.outputBox.Location = new System.Drawing.Point(200, 58);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(389, 102);
            this.outputBox.TabIndex = 6;
            this.outputBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 195);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Практикум 2 | Задание 3";
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputA;
        private System.Windows.Forms.NumericUpDown inputB;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.RichTextBox outputBox;
    }
}

