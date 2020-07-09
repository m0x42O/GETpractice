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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputB = new System.Windows.Forms.NumericUpDown();
            this.inputH = new System.Windows.Forms.NumericUpDown();
            this.button = new System.Windows.Forms.Button();
            this.inputA = new System.Windows.Forms.NumericUpDown();
            this.output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите h =";
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(112, 59);
            this.inputB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(55, 26);
            this.inputB.TabIndex = 1;
            // 
            // inputH
            // 
            this.inputH.Location = new System.Drawing.Point(112, 95);
            this.inputH.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inputH.Name = "inputH";
            this.inputH.Size = new System.Drawing.Size(55, 26);
            this.inputH.TabIndex = 1;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button.Location = new System.Drawing.Point(197, 53);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(126, 37);
            this.button.TabIndex = 2;
            this.button.Text = "ВЫЧИСЛИТЬ";
            this.button.UseVisualStyleBackColor = false;
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(112, 23);
            this.inputA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(55, 26);
            this.inputA.TabIndex = 1;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(362, 23);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(240, 98);
            this.output.TabIndex = 3;
            this.output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(621, 142);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button);
            this.Controls.Add(this.inputH);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Практикум 5 | Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputB;
        private System.Windows.Forms.NumericUpDown inputH;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.NumericUpDown inputA;
        private System.Windows.Forms.RichTextBox output;
    }
}

