using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testApp.SignDocument;
using System.Data.SqlClient;

namespace testApp
{
    public partial class SignForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\testApp1\testApp\Database.mdf;Integrated Security=True";
        
        public SignForm(SelectedDocument document)
        {
            InitializeComponent();
            //проверяем id документа, т.к. могут быть значения < 0
            int convertedId = Convert.ToInt32(document.id);
            if (convertedId > 0)
            {
                idTextBox.Text = document.id;
            }
            else
            {
                convertedId *= -1;
                idTextBox.Text = convertedId.ToString();
            }

            if (dateDateTimePicker.Text != "0:00:000")
            {
                dateDateTimePicker.Text = document.date;
            }

            descriptionTextBox.Text = document.description;
            statusComboBox.Text = document.status;
 
            if (document.signed == "true") {
                signedCheckBox.Checked = true;
            }
            else
            {
                signedCheckBox.Checked = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Подключение к серверу
            Service1Client localClient = new Service1Client();
            if (localClient.SignDocument(statusComboBox.Text) == true)
            {
                MessageBox.Show($"Документ {idTextBox.Text} успешно подписан", "Ответ", MessageBoxButtons.OK);
                signedCheckBox.Checked = true;
            } 
            else
            {
                MessageBox.Show($"Документ {idTextBox.Text} не одобрен", "Ответ", MessageBoxButtons.OK);
                signedCheckBox.Checked = false;
            }
            //Запись обновленных данных в БД
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlText = "UPDATE Documents SET Date = @Date, Description = @Description, Status = @Status, Signed = @Signed WHERE Id = @Id";
                    SqlCommand sqlCommand = new SqlCommand(sqlText, connection);

                    sqlCommand.Parameters.AddWithValue("Id", Convert.ToInt32(idTextBox.Text));
                    sqlCommand.Parameters.AddWithValue("Date", dateDateTimePicker.Value);
                    sqlCommand.Parameters.AddWithValue("Description", descriptionTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("Status", statusComboBox.SelectedItem);
                    sqlCommand.Parameters.AddWithValue("Signed", signedCheckBox.Checked);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show($"{exception}");
            }
        }

    }
}
