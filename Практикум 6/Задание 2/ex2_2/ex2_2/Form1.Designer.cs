﻿namespace ex2_2
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
            this.button = new System.Windows.Forms.Button();
            this.random = new System.Windows.Forms.CheckBox();
            this.output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размер массива:  n =";
            // 
            // inputN
            // 
            this.inputN.Location = new System.Drawing.Point(329, 9);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(59, 26);
            this.inputN.TabIndex = 1;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button.Location = new System.Drawing.Point(180, 68);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(112, 28);
            this.button.TabIndex = 2;
            this.button.Text = "вычислить";
            this.button.UseVisualStyleBackColor = false;
            // 
            // random
            // 
            this.random.AutoSize = true;
            this.random.Font = new System.Drawing.Font("Schadow BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random.Location = new System.Drawing.Point(96, 40);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(291, 20);
            this.random.TabIndex = 3;
            this.random.Text = "Заполнить массив случайными числами";
            this.random.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 108);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(448, 154);
            this.output.TabIndex = 4;
            this.output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(472, 274);
            this.Controls.Add(this.output);
            this.Controls.Add(this.random);
            this.Controls.Add(this.button);
            this.Controls.Add(this.inputN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Практикум 6 | Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.inputN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputN;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.CheckBox random;
        private System.Windows.Forms.RichTextBox output;
    }
}

