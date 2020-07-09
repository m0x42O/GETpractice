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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.searchLM = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(208, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по фамилии:";
            // 
            // searchLM
            // 
            this.searchLM.Location = new System.Drawing.Point(362, 37);
            this.searchLM.Margin = new System.Windows.Forms.Padding(4);
            this.searchLM.Name = "searchLM";
            this.searchLM.Size = new System.Drawing.Size(215, 26);
            this.searchLM.TabIndex = 1;
            // 
            // grid
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.Birthday,
            this.Phone,
            this.Address,
            this.Name,
            this.Fax,
            this.ContactPerson});
            this.grid.Location = new System.Drawing.Point(12, 97);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(760, 295);
            this.grid.TabIndex = 2;
            // 
            // LastName
            // 
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.LastName.DefaultCellStyle = dataGridViewCellStyle10;
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            // 
            // Birthday
            // 
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Birthday.DefaultCellStyle = dataGridViewCellStyle11;
            this.Birthday.HeaderText = "Дата рождения";
            this.Birthday.Name = "Birthday";
            // 
            // Phone
            // 
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.Phone.DefaultCellStyle = dataGridViewCellStyle12;
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            // 
            // Address
            // 
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.Address.DefaultCellStyle = dataGridViewCellStyle13;
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            // 
            // Name
            // 
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.Name.DefaultCellStyle = dataGridViewCellStyle14;
            this.Name.HeaderText = "Название";
            this.Name.Name = "Name";
            // 
            // Fax
            // 
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.Fax.DefaultCellStyle = dataGridViewCellStyle15;
            this.Fax.HeaderText = "Факс";
            this.Fax.Name = "Fax";
            // 
            // ContactPerson
            // 
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.ContactPerson.DefaultCellStyle = dataGridViewCellStyle16;
            this.ContactPerson.HeaderText = "Контакное лицо";
            this.ContactPerson.Name = "ContactPerson";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 404);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.searchLM);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Text = "Практикум 13 | Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchLM;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPerson;
    }
}

