namespace ex1_2
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
            this.inputN = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputA = new System.Windows.Forms.NumericUpDown();
            this.inputB = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество вещественных чисел:    n =";
            // 
            // inputN
            // 
            this.inputN.Location = new System.Drawing.Point(391, 19);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(60, 26);
            this.inputN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите диапазон от A =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "до B =";
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(247, 62);
            this.inputA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(60, 26);
            this.inputA.TabIndex = 4;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(371, 62);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(60, 26);
            this.inputB.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(132, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "ВЫВЕСТИ РЕЗУЛЬТАТ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 149);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(466, 318);
            this.outputBox.TabIndex = 7;
            this.outputBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(490, 479);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Практикум 9 | Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.inputN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputA;
        private System.Windows.Forms.NumericUpDown inputB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox outputBox;
    }
}

