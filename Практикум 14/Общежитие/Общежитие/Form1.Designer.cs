namespace Общежитие
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.общежитиеDataSet = new Общежитие.ОбщежитиеDataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.комнатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.льготыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.расселениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.общежитиеDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.общежитиеDataSet;
            this.bindingSource1.Position = 0;
            // 
            // общежитиеDataSet
            // 
            this.общежитиеDataSet.DataSetName = "ОбщежитиеDataSet";
            this.общежитиеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Schadow BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.tableButton,
            this.viewButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(637, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.fileButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.fileButton.Image = ((System.Drawing.Image)(resources.GetObject("fileButton.Image")));
            this.fileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(56, 22);
            this.fileButton.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tableButton
            // 
            this.tableButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tableButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.комнатыToolStripMenuItem,
            this.льготыToolStripMenuItem,
            this.студентыToolStripMenuItem});
            this.tableButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tableButton.Image = ((System.Drawing.Image)(resources.GetObject("tableButton.Image")));
            this.tableButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tableButton.Name = "tableButton";
            this.tableButton.Size = new System.Drawing.Size(79, 22);
            this.tableButton.Text = "Таблицы";
            // 
            // комнатыToolStripMenuItem
            // 
            this.комнатыToolStripMenuItem.Name = "комнатыToolStripMenuItem";
            this.комнатыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.комнатыToolStripMenuItem.Text = "Комнаты";
            this.комнатыToolStripMenuItem.Click += new System.EventHandler(this.комнатыToolStripMenuItem_Click);
            // 
            // льготыToolStripMenuItem
            // 
            this.льготыToolStripMenuItem.Name = "льготыToolStripMenuItem";
            this.льготыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.льготыToolStripMenuItem.Text = "Льготы";
            this.льготыToolStripMenuItem.Click += new System.EventHandler(this.льготыToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.студентыToolStripMenuItem.Text = "Студенты";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // viewButton
            // 
            this.viewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расселениеToolStripMenuItem});
            this.viewButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.viewButton.Image = ((System.Drawing.Image)(resources.GetObject("viewButton.Image")));
            this.viewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(86, 22);
            this.viewButton.Text = "Просмотр";
            // 
            // расселениеToolStripMenuItem
            // 
            this.расселениеToolStripMenuItem.Name = "расселениеToolStripMenuItem";
            this.расселениеToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.расселениеToolStripMenuItem.Text = "Расселение";
            this.расселениеToolStripMenuItem.Click += new System.EventHandler(this.расселениеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(637, 310);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Schadow BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Общежитие";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.общежитиеDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private ОбщежитиеDataSet общежитиеDataSet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileButton;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tableButton;
        private System.Windows.Forms.ToolStripMenuItem комнатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem льготыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton viewButton;
        private System.Windows.Forms.ToolStripMenuItem расселениеToolStripMenuItem;
    }
}

