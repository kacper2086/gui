using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gui
{
    public partial class DealerForm : Form
    {
        public DealerForm()
        {
            InitializeComponent();
        }

        private void DealerForm_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxData()
        {
            // Connection string do twojej bazy danych
            string connectionString = "Host=localhost;Port=32769;Username=postgres;Password=mysecretpassword;Database=postgres";

            // Zapytanie SQL do pobrania danych
            string query = "SELECT Name FROM products";

            // Utworzenie połączenia z bazą danych
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Otwórz połączenie
                    connection.Open();

                    // Utworzenie obiektu SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Wykonanie zapytania i pobranie danych
                        SqlDataReader reader = command.ExecuteReader();

                        // Wypełnienie ComboBox danymi
                        while (reader.Read())
                        {
                            part.Items.Add(reader["Name"].ToString());
                        }

                        // Zamknięcie readera
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
                finally
                {
                    // Zamknięcie połączenia
                    connection.Close();
                }
            }
        }
    }
}