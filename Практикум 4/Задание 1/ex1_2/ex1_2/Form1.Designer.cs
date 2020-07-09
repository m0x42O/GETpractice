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
            this.inputM = new System.Windows.Forms.NumericUpDown();
            this.inputK = new System.Windows.Forms.NumericUpDown();
            this.button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите m =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите  k =";
            // 
            // inputM
            // 
            this.inputM.Location = new System.Drawing.Point(132, 30);
            this.inputM.Name = "inputM";
            this.inputM.Size = new System.Drawing.Size(54, 26);
            this.inputM.TabIndex = 2;
            // 
            // inputK
            // 
            this.inputK.Location = new System.Drawing.Point(132, 64);
            this.inputK.Name = "inputK";
            this.inputK.Size = new System.Drawing.Size(54, 26);
            this.inputK.TabIndex = 3;
            // 
            // button
            // 
            this.button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button.Location = new System.Drawing.Point(219, 44);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(93, 34);
            this.button.TabIndex = 4;
            this.button.Text = "вычислить";
            this.button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат:";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(346, 36);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(173, 60);
            this.output.TabIndex = 6;
            this.output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(555, 123);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button);
            this.Controls.Add(this.inputK);
            this.Controls.Add(this.inputM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Практикум 4 | Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.inputM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputM;
        private System.Windows.Forms.NumericUpDown inputK;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox output;
    }
}

