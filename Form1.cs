using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Documents". При необходимости она может быть перемещена или удалена.
            this.documentsTableAdapter.Fill(this.databaseDataSet.Documents);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            string selectedId = selectedRow.Cells[0].Value.ToString();
            string selectedData = selectedRow.Cells[1].Value.ToString();
            string selectedDescription = selectedRow.Cells[2].Value.ToString();
            string selectedStatus = selectedRow.Cells[3].Value.ToString();
            string selectedSign = selectedRow.Cells[4].Value.ToString();

            var selectedDocument = new SelectedDocument(selectedId,selectedData,selectedDescription,selectedStatus,selectedSign);
           
            //MessageBox.Show($"{selectedId},{selectedData},{selectedDescription},{selectedStatus},{selectedSign}");
            SignForm signForm = new SignForm(selectedDocument);
            
            signForm.ShowDialog();
            this.Hide();
        }
    }
}
