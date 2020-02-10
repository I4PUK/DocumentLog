namespace testApp
{
    partial class SignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label номер_документаLabel;
            System.Windows.Forms.Label дата_документаLabel;
            System.Windows.Forms.Label описание_Label;
            System.Windows.Forms.Label статус_Label;
            System.Windows.Forms.Label подписанLabel;
            this.databaseDataSet = new testApp.DatabaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentsTableAdapter = new testApp.DatabaseDataSetTableAdapters.DocumentsTableAdapter();
            this.tableAdapterManager = new testApp.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.номер_документаTextBox = new System.Windows.Forms.TextBox();
            this.дата_документаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.описание_TextBox = new System.Windows.Forms.TextBox();
            this.статус_ComboBox = new System.Windows.Forms.ComboBox();
            this.подписанCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            номер_документаLabel = new System.Windows.Forms.Label();
            дата_документаLabel = new System.Windows.Forms.Label();
            описание_Label = new System.Windows.Forms.Label();
            статус_Label = new System.Windows.Forms.Label();
            подписанLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DocumentsTableAdapter = this.documentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = testApp.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // номер_документаLabel
            // 
            номер_документаLabel.AutoSize = true;
            номер_документаLabel.Location = new System.Drawing.Point(214, 82);
            номер_документаLabel.Name = "номер_документаLabel";
            номер_документаLabel.Size = new System.Drawing.Size(129, 17);
            номер_документаLabel.TabIndex = 0;
            номер_документаLabel.Text = "Номер документа:";
            // 
            // номер_документаTextBox
            // 
            this.номер_документаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentsBindingSource, "Номер документа", true));
            this.номер_документаTextBox.Location = new System.Drawing.Point(349, 79);
            this.номер_документаTextBox.Name = "номер_документаTextBox";
            this.номер_документаTextBox.Size = new System.Drawing.Size(200, 22);
            this.номер_документаTextBox.TabIndex = 1;
            // 
            // дата_документаLabel
            // 
            дата_документаLabel.AutoSize = true;
            дата_документаLabel.Location = new System.Drawing.Point(214, 111);
            дата_документаLabel.Name = "дата_документаLabel";
            дата_документаLabel.Size = new System.Drawing.Size(120, 17);
            дата_документаLabel.TabIndex = 2;
            дата_документаLabel.Text = "Дата документа:";
            // 
            // дата_документаDateTimePicker
            // 
            this.дата_документаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.documentsBindingSource, "Дата документа", true));
            this.дата_документаDateTimePicker.Location = new System.Drawing.Point(349, 107);
            this.дата_документаDateTimePicker.Name = "дата_документаDateTimePicker";
            this.дата_документаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_документаDateTimePicker.TabIndex = 3;
            // 
            // описание_Label
            // 
            описание_Label.AutoSize = true;
            описание_Label.Location = new System.Drawing.Point(214, 138);
            описание_Label.Name = "описание_Label";
            описание_Label.Size = new System.Drawing.Size(82, 17);
            описание_Label.TabIndex = 4;
            описание_Label.Text = "Описание :";
            // 
            // описание_TextBox
            // 
            this.описание_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentsBindingSource, "Описание ", true));
            this.описание_TextBox.Location = new System.Drawing.Point(349, 135);
            this.описание_TextBox.Multiline = true;
            this.описание_TextBox.Name = "описание_TextBox";
            this.описание_TextBox.Size = new System.Drawing.Size(200, 107);
            this.описание_TextBox.TabIndex = 5;
            // 
            // статус_Label
            // 
            статус_Label.AutoSize = true;
            статус_Label.Location = new System.Drawing.Point(214, 251);
            статус_Label.Name = "статус_Label";
            статус_Label.Size = new System.Drawing.Size(61, 17);
            статус_Label.TabIndex = 6;
            статус_Label.Text = "Статус :";
            // 
            // статус_ComboBox
            // 
            this.статус_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentsBindingSource, "Статус ", true));
            this.статус_ComboBox.FormattingEnabled = true;
            this.статус_ComboBox.Items.AddRange(new object[] {
            "Новый",
            "В работе",
            "Занят"});
            this.статус_ComboBox.Location = new System.Drawing.Point(349, 248);
            this.статус_ComboBox.Name = "статус_ComboBox";
            this.статус_ComboBox.Size = new System.Drawing.Size(200, 24);
            this.статус_ComboBox.TabIndex = 7;
            // 
            // подписанLabel
            // 
            подписанLabel.AutoSize = true;
            подписанLabel.Location = new System.Drawing.Point(214, 284);
            подписанLabel.Name = "подписанLabel";
            подписанLabel.Size = new System.Drawing.Size(77, 17);
            подписанLabel.TabIndex = 8;
            подписанLabel.Text = "Подписан:";
            // 
            // подписанCheckBox
            // 
            this.подписанCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.documentsBindingSource, "Подписан", true));
            this.подписанCheckBox.Enabled = false;
            this.подписанCheckBox.Location = new System.Drawing.Point(349, 279);
            this.подписанCheckBox.Name = "подписанCheckBox";
            this.подписанCheckBox.Size = new System.Drawing.Size(200, 24);
            this.подписанCheckBox.TabIndex = 9;
            this.подписанCheckBox.Text = "Подпись";
            this.подписанCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Подписать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(номер_документаLabel);
            this.Controls.Add(this.номер_документаTextBox);
            this.Controls.Add(дата_документаLabel);
            this.Controls.Add(this.дата_документаDateTimePicker);
            this.Controls.Add(описание_Label);
            this.Controls.Add(this.описание_TextBox);
            this.Controls.Add(статус_Label);
            this.Controls.Add(this.статус_ComboBox);
            this.Controls.Add(подписанLabel);
            this.Controls.Add(this.подписанCheckBox);
            this.Name = "SignForm";
            this.Text = "SignForm";
            this.Load += new System.EventHandler(this.SignForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private DatabaseDataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox номер_документаTextBox;
        private System.Windows.Forms.DateTimePicker дата_документаDateTimePicker;
        private System.Windows.Forms.TextBox описание_TextBox;
        private System.Windows.Forms.ComboBox статус_ComboBox;
        private System.Windows.Forms.CheckBox подписанCheckBox;
        private System.Windows.Forms.Button button1;
    }
}