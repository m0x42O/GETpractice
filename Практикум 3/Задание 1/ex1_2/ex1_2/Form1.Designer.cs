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
            this.inputX = new System.Windows.Forms.NumericUpDown();
            this.result = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите х:";
            // 
            // inputX
            // 
            this.inputX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.inputX.Location = new System.Drawing.Point(140, 48);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(71, 25);
            this.inputX.TabIndex = 1;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ControlDark;
            this.result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.result.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.result.FlatAppearance.BorderSize = 0;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.result.Location = new System.Drawing.Point(244, 48);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(102, 25);
            this.result.TabIndex = 3;
            this.result.Text = "вычислить";
            this.result.UseVisualStyleBackColor = false;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ControlDark;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Location = new System.Drawing.Point(378, 48);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(148, 25);
            this.output.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(613, 118);
            this.Controls.Add(this.output);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputX);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Практикум 3 | Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.inputX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputX;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.TextBox output;
    }
}

