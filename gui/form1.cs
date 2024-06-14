using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gui
{
    public partial class form1 : Form
    {
        private Dictionary<string, (string, UserType)> users = new Dictionary<string, (string, UserType)>
    {
        { "client", ("client", UserType.Client) },
        { "mech", ("mech", UserType.Mechanic) },
        { "dealer", ("dealer", UserType.Dealer) }
    };
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbUsername.Text;
            if (users.ContainsKey(username))
            {
                var (storedPassword, userType) = users[username];

                if (password == storedPassword)
                {
                    // Logowanie powiodło się, przejdź do odpowiedniego formularza
                    OpenUserForm(userType);
                    this.Hide(); // Ukryj formularz logowania
                }
                else
                {
                    MessageBox.Show("Niepoprawne hasło", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Niepoprawny użytkownik", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public enum UserType
        {
            Client,
            Mechanic,
            Dealer
        }
        private void OpenUserForm(UserType userType)
        {
            switch (userType)
            {
                case UserType.Client:
                    ClientForm clientForm = new ClientForm();
                    clientForm.Show();
                    break;
                case UserType.Mechanic:
                    MechanicForm mechanicForm = new MechanicForm();
                    mechanicForm.Show();
                    break;
                case UserType.Dealer:
                    DealerForm dealerForm = new DealerForm();
                    dealerForm.Show();
                    break;
                default:
                    MessageBox.Show("Nieobsługiwany typ użytkownika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }


    }
}


