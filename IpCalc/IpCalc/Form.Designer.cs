namespace IpCalc
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTipPaymentType = new System.Windows.Forms.ToolTip(this.components);
            this.priceAnnuitet = new System.Windows.Forms.RadioButton();
            this.priceDiffer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butPriceGo = new System.Windows.Forms.Button();
            this.butPriceClear = new System.Windows.Forms.Button();
            this.pricePeriodCombo = new System.Windows.Forms.ComboBox();
            this.pricePeriod = new System.Windows.Forms.NumericUpDown();
            this.priceProcent = new System.Windows.Forms.NumericUpDown();
            this.priceInitialType = new System.Windows.Forms.ComboBox();
            this.priceInitial = new System.Windows.Forms.NumericUpDown();
            this.pricePrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.itogPayment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.itogOverpayment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.itogSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvGrafik = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.priceCreditSum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceProcent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePrice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).BeginInit();
            this.SuspendLayout();
            // 
            // priceAnnuitet
            // 
            this.priceAnnuitet.AutoSize = true;
            this.priceAnnuitet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceAnnuitet.Location = new System.Drawing.Point(232, 220);
            this.priceAnnuitet.Name = "priceAnnuitet";
            this.priceAnnuitet.Size = new System.Drawing.Size(112, 23);
            this.priceAnnuitet.TabIndex = 15;
            this.priceAnnuitet.TabStop = true;
            this.priceAnnuitet.Text = "Аннуитетные";
            this.toolTipPaymentType.SetToolTip(this.priceAnnuitet, "Вариант ежемесячного платежа по кредиту, когда размер ежемесячного платежа остаёт" +
        "ся постоянным на всём периоде кредитования.");
            this.priceAnnuitet.UseVisualStyleBackColor = true;
            // 
            // priceDiffer
            // 
            this.priceDiffer.AutoSize = true;
            this.priceDiffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceDiffer.Location = new System.Drawing.Point(232, 245);
            this.priceDiffer.Name = "priceDiffer";
            this.priceDiffer.Size = new System.Drawing.Size(184, 23);
            this.priceDiffer.TabIndex = 16;
            this.priceDiffer.TabStop = true;
            this.priceDiffer.Text = "Дифференцированные";
            this.toolTipPaymentType.SetToolTip(this.priceDiffer, "Вариант ежемесячного платежа по кредиту, когда размер ежемесячного платежа по пог" +
        "ашению кредита постепенно уменьшается к концу периода кредитования.");
            this.priceDiffer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.priceCreditSum);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.butPriceGo);
            this.groupBox1.Controls.Add(this.butPriceClear);
            this.groupBox1.Controls.Add(this.priceDiffer);
            this.groupBox1.Controls.Add(this.priceAnnuitet);
            this.groupBox1.Controls.Add(this.pricePeriodCombo);
            this.groupBox1.Controls.Add(this.pricePeriod);
            this.groupBox1.Controls.Add(this.priceProcent);
            this.groupBox1.Controls.Add(this.priceInitialType);
            this.groupBox1.Controls.Add(this.priceInitial);
            this.groupBox1.Controls.Add(this.pricePrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // butPriceGo
            // 
            this.butPriceGo.BackColor = System.Drawing.SystemColors.Window;
            this.butPriceGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPriceGo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butPriceGo.Location = new System.Drawing.Point(274, 278);
            this.butPriceGo.Name = "butPriceGo";
            this.butPriceGo.Size = new System.Drawing.Size(165, 40);
            this.butPriceGo.TabIndex = 18;
            this.butPriceGo.Text = "Рассчитать стоимость";
            this.butPriceGo.UseVisualStyleBackColor = false;
            // 
            // butPriceClear
            // 
            this.butPriceClear.BackColor = System.Drawing.SystemColors.Window;
            this.butPriceClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPriceClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butPriceClear.Location = new System.Drawing.Point(89, 278);
            this.butPriceClear.Name = "butPriceClear";
            this.butPriceClear.Size = new System.Drawing.Size(166, 40);
            this.butPriceClear.TabIndex = 17;
            this.butPriceClear.Text = "Очистить расчеты";
            this.butPriceClear.UseVisualStyleBackColor = false;
            // 
            // pricePeriodCombo
            // 
            this.pricePeriodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pricePeriodCombo.FormattingEnabled = true;
            this.pricePeriodCombo.Items.AddRange(new object[] {
            "лет",
            "мес."});
            this.pricePeriodCombo.Location = new System.Drawing.Point(318, 186);
            this.pricePeriodCombo.Name = "pricePeriodCombo";
            this.pricePeriodCombo.Size = new System.Drawing.Size(75, 27);
            this.pricePeriodCombo.TabIndex = 14;
            // 
            // pricePeriod
            // 
            this.pricePeriod.Location = new System.Drawing.Point(232, 186);
            this.pricePeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pricePeriod.Name = "pricePeriod";
            this.pricePeriod.Size = new System.Drawing.Size(76, 26);
            this.pricePeriod.TabIndex = 13;
            this.pricePeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // priceProcent
            // 
            this.priceProcent.DecimalPlaces = 2;
            this.priceProcent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.priceProcent.Location = new System.Drawing.Point(232, 146);
            this.priceProcent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceProcent.Name = "priceProcent";
            this.priceProcent.Size = new System.Drawing.Size(76, 26);
            this.priceProcent.TabIndex = 12;
            // 
            // priceInitialType
            // 
            this.priceInitialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priceInitialType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceInitialType.FormattingEnabled = true;
            this.priceInitialType.Items.AddRange(new object[] {
            "руб.",
            "%"});
            this.priceInitialType.Location = new System.Drawing.Point(399, 65);
            this.priceInitialType.Name = "priceInitialType";
            this.priceInitialType.Size = new System.Drawing.Size(75, 27);
            this.priceInitialType.TabIndex = 11;
            // 
            // priceInitial
            // 
            this.priceInitial.Location = new System.Drawing.Point(232, 66);
            this.priceInitial.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.priceInitial.Name = "priceInitial";
            this.priceInitial.Size = new System.Drawing.Size(161, 26);
            this.priceInitial.TabIndex = 10;
            this.priceInitial.ThousandsSeparator = true;
            // 
            // pricePrice
            // 
            this.pricePrice.Location = new System.Drawing.Point(232, 27);
            this.pricePrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.pricePrice.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pricePrice.Name = "pricePrice";
            this.pricePrice.Size = new System.Drawing.Size(161, 26);
            this.pricePrice.TabIndex = 9;
            this.pricePrice.ThousandsSeparator = true;
            this.pricePrice.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Тип платежей:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Срок ипотеки:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "% годовых";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Процентная ставка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "руб.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Первоначальный взнос:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стоимость квартиры:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.itogPayment);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.itogOverpayment);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.itogSum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(552, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат расчетов";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(270, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "руб.";
            // 
            // itogPayment
            // 
            this.itogPayment.Location = new System.Drawing.Point(69, 228);
            this.itogPayment.Name = "itogPayment";
            this.itogPayment.ReadOnly = true;
            this.itogPayment.Size = new System.Drawing.Size(195, 26);
            this.itogPayment.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "Ежемесячный платеж:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(270, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "руб.";
            // 
            // itogOverpayment
            // 
            this.itogOverpayment.Location = new System.Drawing.Point(69, 164);
            this.itogOverpayment.Name = "itogOverpayment";
            this.itogOverpayment.ReadOnly = true;
            this.itogOverpayment.Size = new System.Drawing.Size(195, 26);
            this.itogOverpayment.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Переплата по кредиту:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "руб.";
            // 
            // itogSum
            // 
            this.itogSum.Location = new System.Drawing.Point(69, 100);
            this.itogSum.Name = "itogSum";
            this.itogSum.ReadOnly = true;
            this.itogSum.Size = new System.Drawing.Size(195, 26);
            this.itogSum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Итоговая стоимость:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvGrafik);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(910, 396);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "График платежей";
            // 
            // dgvGrafik
            // 
            this.dgvGrafik.BackgroundColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrafik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrafik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrafik.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrafik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrafik.GridColor = System.Drawing.SystemColors.Control;
            this.dgvGrafik.Location = new System.Drawing.Point(3, 22);
            this.dgvGrafik.Name = "dgvGrafik";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrafik.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGrafik.Size = new System.Drawing.Size(904, 371);
            this.dgvGrafik.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Месяц";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Сумма платежа";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Платеж по основному долгу, руб";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Платеж по процентам, руб.";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Остаток основного долга, руб.";
            this.Column5.Name = "Column5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 19);
            this.label14.TabIndex = 19;
            this.label14.Text = "Сумма ипотеки:";
            // 
            // priceCreditSum
            // 
            this.priceCreditSum.Location = new System.Drawing.Point(232, 106);
            this.priceCreditSum.Name = "priceCreditSum";
            this.priceCreditSum.ReadOnly = true;
            this.priceCreditSum.Size = new System.Drawing.Size(161, 26);
            this.priceCreditSum.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(399, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = "руб.";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(934, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form";
            this.Text = "Ипотечный калькулятор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceProcent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePrice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipPaymentType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox priceInitialType;
        private System.Windows.Forms.NumericUpDown priceInitial;
        private System.Windows.Forms.NumericUpDown pricePrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pricePeriod;
        private System.Windows.Forms.NumericUpDown priceProcent;
        private System.Windows.Forms.Button butPriceGo;
        private System.Windows.Forms.Button butPriceClear;
        private System.Windows.Forms.RadioButton priceDiffer;
        private System.Windows.Forms.RadioButton priceAnnuitet;
        private System.Windows.Forms.ComboBox pricePeriodCombo;
        private System.Windows.Forms.DataGridView dgvGrafik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox itogPayment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox itogOverpayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox itogSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox priceCreditSum;
        private System.Windows.Forms.Label label14;
    }
}

