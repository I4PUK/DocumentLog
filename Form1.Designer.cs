namespace testApp
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
            this.databaseDataSet = new testApp.DatabaseDataSet();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentsTableAdapter = new testApp.DatabaseDataSetTableAdapters.DocumentsTableAdapter();
            this.номерДокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаДокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.подписанDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номерДокументаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаДокументаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.подписанDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "Documents";
            this.documentsBindingSource.DataSource = this.databaseDataSet;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // номерДокументаDataGridViewTextBoxColumn
            // 
            this.номерДокументаDataGridViewTextBoxColumn.DataPropertyName = "Номер документа";
            this.номерДокументаDataGridViewTextBoxColumn.HeaderText = "Номер документа";
            this.номерДокументаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерДокументаDataGridViewTextBoxColumn.Name = "номерДокументаDataGridViewTextBoxColumn";
            this.номерДокументаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаДокументаDataGridViewTextBoxColumn
            // 
            this.датаДокументаDataGridViewTextBoxColumn.DataPropertyName = "Дата документа";
            this.датаДокументаDataGridViewTextBoxColumn.HeaderText = "Дата документа";
            this.датаДокументаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаДокументаDataGridViewTextBoxColumn.Name = "датаДокументаDataGridViewTextBoxColumn";
            this.датаДокументаDataGridViewTextBoxColumn.Width = 125;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание ";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание ";
            this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.Width = 125;
            // 
            // подписанDataGridViewCheckBoxColumn
            // 
            this.подписанDataGridViewCheckBoxColumn.DataPropertyName = "Подписан";
            this.подписанDataGridViewCheckBoxColumn.HeaderText = "Подписан";
            this.подписанDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.подписанDataGridViewCheckBoxColumn.Name = "подписанDataGridViewCheckBoxColumn";
            this.подписанDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Номер документа";
            this.Column1.HeaderText = "Номер документа";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Номер документа";
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДокументаDataGridViewTextBoxColumn1,
            this.датаДокументаDataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn1,
            this.подписанDataGridViewCheckBoxColumn1});
            this.dataGridView1.DataSource = this.documentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // номерДокументаDataGridViewTextBoxColumn1
            // 
            this.номерДокументаDataGridViewTextBoxColumn1.DataPropertyName = "Номер документа";
            this.номерДокументаDataGridViewTextBoxColumn1.HeaderText = "Номер документа";
            this.номерДокументаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.номерДокументаDataGridViewTextBoxColumn1.Name = "номерДокументаDataGridViewTextBoxColumn1";
            this.номерДокументаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // датаДокументаDataGridViewTextBoxColumn1
            // 
            this.датаДокументаDataGridViewTextBoxColumn1.DataPropertyName = "Дата документа";
            this.датаДокументаDataGridViewTextBoxColumn1.HeaderText = "Дата документа";
            this.датаДокументаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.датаДокументаDataGridViewTextBoxColumn1.Name = "датаДокументаDataGridViewTextBoxColumn1";
            this.датаДокументаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Статус ";
            this.dataGridViewComboBoxColumn1.HeaderText = "Статус ";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            // 
            // подписанDataGridViewCheckBoxColumn1
            // 
            this.подписанDataGridViewCheckBoxColumn1.DataPropertyName = "Подписан";
            this.подписанDataGridViewCheckBoxColumn1.HeaderText = "Подписан";
            this.подписанDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.подписанDataGridViewCheckBoxColumn1.Name = "подписанDataGridViewCheckBoxColumn1";
            this.подписанDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private DatabaseDataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаДокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn подписанDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДокументаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаДокументаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn подписанDataGridViewCheckBoxColumn1;
    }
}

