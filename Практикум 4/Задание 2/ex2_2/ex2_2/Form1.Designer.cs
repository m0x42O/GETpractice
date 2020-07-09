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
            this.label1.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рекурсивный метод для вывода на экран цифр натурального числа в прямом порядке";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите диапазон:     от A =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "до B =";
            // 
            // inputA
            // 
            this.inputA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.inputA.Location = new System.Drawing.Point(349, 78);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(91, 26);
            this.inputA.TabIndex = 3;
            // 
            // inputB
            // 
            this.inputB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.inputB.Location = new System.Drawing.Point(502, 78);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(91, 26);
            this.inputB.TabIndex = 3;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button.Location = new System.Drawing.Point(302, 126);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(133, 26);
            this.button.TabIndex = 4;
            this.button.Text = "РЕЗУЛЬТАТ";
            this.button.UseVisualStyleBackColor = false;
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.outputBox.Location = new System.Drawing.Point(28, 167);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(681, 213);
            this.outputBox.TabIndex = 5;
            this.outputBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(737, 406);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Практикум 4 | Задание 2";
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

