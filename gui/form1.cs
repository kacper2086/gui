using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace gui
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Port=32768;Username=postgres;Password=mysecretpassword;Database=postgres";

        public Form1()
        {
            InitializeComponent();
        }

        private void but_Click_1(object sender, EventArgs e)
        {
            string Username = login.Text;
            string password = pass.Text;

            string query = "SELECT login, password, usertype FROM public.users WHERE \"login\" = @Username AND \"password\" = @Password";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string userTypeFromDB = reader["usertype"].ToString();
                        OpenUserForm(userTypeFromDB);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Niepoprawne dane logowania", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z bazą danych: " + ex.Message);
                }
            }
        }

        private void OpenUserForm(string userType)
        {
            switch (userType)
            {
                case "Client":
                    ClientForm clientForm = new ClientForm();
                    clientForm.Show();
                    break;
                case "Mechanic":
                    MechanicForm mechanicForm = new MechanicForm();
                    mechanicForm.Show();
                    break;
                case "dealer":
                    DealerForm dealerForm = new DealerForm();
                    dealerForm.Show();
                    break;
                default:
                    MessageBox.Show("Nieobsługiwany typ użytkownika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Usuwamy ComboBox i jego obsługę, ponieważ typ użytkownika jest teraz pobierany z bazy danych.
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
