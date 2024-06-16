using System;
using System.Data;
using System.Windows.Forms;
using Npgsql; // Dodaj namespace dla Npgsql

namespace gui
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Port=32769;Username=postgres;Password=mysecretpassword;Database=postgres";

        public Form1()
        {
            InitializeComponent();
        }

        private void but_Click_1(object sender, EventArgs e)
        {
            string Username = login.Text;
            string password = pass.Text;
            string userType = typ.SelectedItem.ToString();
            
            string query = "SELECT login, password, usertype FROM public.users WHERE \"login\" = @Username AND \"password\" = @Password AND \"usertype\" = @userType";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@userType", userType);

                try
                {
                    connection.Open();
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.Read()) 
                    {

                        string userTypeFromDB = reader["UserType"].ToString();


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

            typ.Items.AddRange(new string[] { "Client", "Mechanic", "dealer" });
            typ.SelectedIndex = 0; 
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void typ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
