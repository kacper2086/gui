using static gui.form1;
using System.Windows.Forms;
using System.Drawing;

public partial class MainForm : Form
{
    private string loggedInUsername;
    private UserType userType;

    public MainForm(string username, UserType userType)
    { 


        this.loggedInUsername = username;
        this.userType = userType;

        // Przykładowe dostosowanie interfejsu na podstawie userType
        if (userType == UserType.Client)
        {
            // Działania dla klienta
            this.Text = "Panel klienta";
            // Dodatkowe inicjalizacje dla klienta
        }
        else if (userType == UserType.Mechanic)
        {
            // Działania dla mechanika
            this.Text = "Panel mechanika";
            // Dodatkowe inicjalizacje dla mechanika
        }
        else if (userType == UserType.Dealer)
        {
            // Działania dla handlarza
            this.Text = "Panel handlarza";

            // Przykładowe dodanie kontrolki TextBox dla handlarza
            TextBox dealerTextBox = new TextBox();
            dealerTextBox.Location = new Point(20, 50);
            dealerTextBox.Size = new Size(200, 30);
            dealerTextBox.Text = "To jest panel handlarza.";
            this.Controls.Add(dealerTextBox);

            // Przykładowe dodanie przycisku dla handlarza
            Button dealerButton = new Button();
            dealerButton.Location = new Point(20, 100);
            dealerButton.Size = new Size(100, 30);
            dealerButton.Text = "Akcja dla handlarza";
            this.Controls.Add(dealerButton);

            {

            }
        // Dodatkowe inicjalizacje dla handlarza
    }
    }
}
