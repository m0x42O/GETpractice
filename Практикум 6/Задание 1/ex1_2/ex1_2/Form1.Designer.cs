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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputM = new System.Windows.Forms.NumericUpDown();
            this.inputN = new System.Windows.Forms.NumericUpDown();
            this.labelM = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputA = new System.Windows.Forms.NumericUpDown();
            this.autoFill = new System.Windows.Forms.CheckBox();
            this.button = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inputB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Controls.Add(this.radio2);
            this.groupBox1.Controls.Add(this.radio1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип массива";
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2.Location = new System.Drawing.Point(13, 49);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(110, 20);
            this.radio2.TabIndex = 0;
            this.radio2.TabStop = true;
            this.radio2.Text = "Двумерный";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.Location = new System.Drawing.Point(13, 23);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(120, 20);
            this.radio1.TabIndex = 0;
            this.radio1.TabStop = true;
            this.radio1.Text = "Одномерный";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputM);
            this.groupBox2.Controls.Add(this.inputN);
            this.groupBox2.Controls.Add(this.labelM);
            this.groupBox2.Controls.Add(this.labelN);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(264, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размер массива";
            // 
            // inputM
            // 
            this.inputM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputM.Location = new System.Drawing.Point(61, 48);
            this.inputM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputM.Name = "inputM";
            this.inputM.Size = new System.Drawing.Size(69, 24);
            this.inputM.TabIndex = 1;
            this.inputM.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // inputN
            // 
            this.inputN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputN.Location = new System.Drawing.Point(61, 22);
            this.inputN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(69, 24);
            this.inputN.TabIndex = 1;
            this.inputN.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.Location = new System.Drawing.Point(26, 51);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(32, 16);
            this.labelM.TabIndex = 0;
            this.labelM.Text = "M =";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.Location = new System.Drawing.Point(26, 25);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(31, 16);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "N =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "A =";
            // 
            // inputA
            // 
            this.inputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputA.Location = new System.Drawing.Point(59, 22);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(69, 24);
            this.inputA.TabIndex = 1;
            this.inputA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // autoFill
            // 
            this.autoFill.AutoSize = true;
            this.autoFill.Checked = true;
            this.autoFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoFill.Location = new System.Drawing.Point(205, 117);
            this.autoFill.Name = "autoFill";
            this.autoFill.Size = new System.Drawing.Size(269, 20);
            this.autoFill.TabIndex = 2;
            this.autoFill.Text = "Заполнить случайными числами";
            this.autoFill.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button.Location = new System.Drawing.Point(281, 144);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(125, 25);
            this.button.TabIndex = 3;
            this.button.Text = "РЕЗУЛЬТАТ";
            this.button.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(27, 183);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(640, 224);
            this.output.TabIndex = 4;
            this.output.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.inputB);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.inputA);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(507, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 84);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Интервал от A до B";
            // 
            // inputB
            // 
            this.inputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputB.Location = new System.Drawing.Point(59, 48);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(69, 24);
            this.inputB.TabIndex = 1;
            this.inputB.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "B =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(689, 429);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button);
            this.Controls.Add(this.autoFill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Практикум 6 | Задание 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.NumericUpDown inputM;
        private System.Windows.Forms.NumericUpDown inputN;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.NumericUpDown inputA;
        private System.Windows.Forms.CheckBox autoFill;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputB;
    }
}

