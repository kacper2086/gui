using System;
using System.Windows.Forms;
using Npgsql;

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
            LoadComboBoxData();
            LoadComboBoxData2();
            LoadComboBoxDataprzyjmowanie();
            LoadComboBoxDataOrder();
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
            string connectionString = "Host=localhost;Port=32768;Username=postgres;Password=mysecretpassword;Database=postgres";
            string query = "SELECT Name FROM product";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        NpgsqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            part.Items.Add(reader["Name"].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void LoadComboBoxData2()
        {
            string connectionString = "Host=localhost;Port=32768;Username=postgres;Password=mysecretpassword;Database=postgres";
            string query = "SELECT login FROM users WHERE usertype='client'";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        NpgsqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            client.Items.Add(reader["login"].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string selectedPart = part.SelectedItem.ToString();
            string selectedClient = client.SelectedItem.ToString();
            int quantity = int.Parse(ilosc.Text); // Assuming you have a TextBox named quantityTextBox
            UpdateDatabase(selectedPart, selectedClient, quantity);
        }

        private void InsertIntoDatabase(string partName, string clientName, int quantity)
        {
            string connectionString = "Host=localhost;Port=32768;Username=postgres;Password=mysecretpassword;Database=postgres";
            string queryInsertProduct = "INSERT INTO product (Name, CustomerID) VALUES (@partName, (SELECT id FROM users WHERE login=@clientName)) RETURNING id";
            string queryInsertTransaction = "INSERT INTO transaction (customerid, productid, quantity, amount) VALUES ((SELECT id FROM users WHERE login=@clientName), @productid, @quantity, @amount)";
            string queryGetPrice = "SELECT price FROM product WHERE Name=@partName";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    decimal price;
                    using (NpgsqlCommand command = new NpgsqlCommand(queryGetPrice, connection))
                    {
                        command.Parameters.AddWithValue("@partName", partName);
                        price = (decimal)command.ExecuteScalar();
                    }

                    int productId;
                    using (NpgsqlCommand command = new NpgsqlCommand(queryInsertProduct, connection))
                    {
                        command.Parameters.AddWithValue("@partName", partName);
                        command.Parameters.AddWithValue("@clientName", clientName);
                        productId = (int)command.ExecuteScalar();
                    }

                    decimal amount = price * quantity;

                    using (NpgsqlCommand command = new NpgsqlCommand(queryInsertTransaction, connection))
                    {
                        command.Parameters.AddWithValue("@clientName", clientName);
                        command.Parameters.AddWithValue("@productid", productId);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@amount", amount);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Transakcja zakończona sukcesem! Produkt '{partName}' został przypisany do użytkownika '{clientName}'. Ilość: {quantity}, Kwota: {amount:C}.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void UpdateDatabase(string partName, string clientName, int quantity)
        {
            string connectionString = "Host=localhost;Port=32768;Username=postgres;Password=mysecretpassword;Database=postgres";
            string queryInsertTransaction = "INSERT INTO transaction (customerid, productid, quantity, amount) VALUES ((SELECT id FROM users WHERE login=@clientName), (SELECT productid FROM product WHERE Name=@partName), @quantity, @amount)";
            string queryUpdateProduct = "UPDATE product SET stan = stan - @quantity WHERE Name = @partName";
            string queryGetPrice = "SELECT price FROM product WHERE Name=@partName";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    decimal price;
                    using (NpgsqlCommand command = new NpgsqlCommand(queryGetPrice, connection))
                    {
                        command.Parameters.AddWithValue("@partName", partName);
                        price = (decimal)command.ExecuteScalar();
                    }


                    decimal amount = price * quantity;

                    using (NpgsqlCommand command = new NpgsqlCommand(queryInsertTransaction, connection))
                    {
                        command.Parameters.AddWithValue("@partName", partName);
                        command.Parameters.AddWithValue("@clientName", clientName);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@amount", amount);
                        command.ExecuteNonQuery();
                    }

                    using (NpgsqlCommand command = new NpgsqlCommand(queryUpdateProduct, connection))
                    {
                        command.Parameters.AddWithValue("@partName", partName);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.ExecuteNonQuery();
                    }


                    MessageBox.Show($"Transakcja zakończona sukcesem! Produkt '{partName}' został przypisany do użytkownika '{clientName}'. Ilość: {quantity}, Kwota: {amount:C}.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void czescprzyjm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadComboBoxDataprzyjmowanie()
        {
            string connectionString = "Host=localhost;Port=32768;Username=postgres;Password=mysecretpassword;Database=postgres";
            string query = @"
        SELECT p.Name AS ProductName, p.stan AS Quantity
        FROM product p 
    ";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        NpgsqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string productName = reader["ProductName"].ToString();
                            int quantity;
                            if (reader["Quantity"] != DBNull.Value)
                            {
                                quantity = Convert.ToInt32(reader["Quantity"]);
                            }
                            else
                            {
                                quantity = 0; // lub inna wartość domyślna, jeśli DBNull jest dopuszczalne
                            }

                            // Tworzymy tekst do wyświetlenia w ComboBoxie
                            string displayText = $"{productName} - {quantity}";
                            czescprzyjm.Items.Add(displayText);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void przyjmij_Click(object sender, EventArgs e)
        {
            int quantityToAdd = int.Parse(iloscprzyjm.Text);
            // Sprawdzamy, czy jest coś wybrane w ComboBoxie
            if (czescprzyjm.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać transakcję do przyjęcia.");
                return;
            }

            // Pobieramy zaznaczoną wartość z ComboBoxa
            string selectedTransaction = czescprzyjm.SelectedItem.ToString();

            // Rozdzielamy wartość na poszczególne części
            string[] parts = selectedTransaction.Split(new string[] { " - " }, StringSplitOptions.None);
            string productName = parts[0];


            // Wywołujemy funkcję do aktualizacji ilości produktu
            UpdateProductQuantity(productName, quantityToAdd);
        }

        private void UpdateProductQuantity(string productName, int quantityToAdd)
        {
            string connectionString = "Host=localhost;Port=32768;Username=postgres;Password=mysecretpassword;Database=postgres";
            string queryUpdateProduct = "UPDATE product SET stan = stan + @quantityToAdd WHERE Name = @productName";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(queryUpdateProduct, connection))
                    {
                        command.Parameters.AddWithValue("@productName", productName);
                        command.Parameters.AddWithValue("@quantityToAdd", quantityToAdd);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Przyjęcie produktu '{productName}', stan zwiększony o {quantityToAdd} sztuk.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void RefreshData()
        {
            czescprzyjm.Items.Clear();
            client.Items.Clear();
            part.Items.Clear();
            ordername.Items.Clear();


           LoadComboBoxData();
            LoadComboBoxData2();
            LoadComboBoxDataprzyjmowanie();
            LoadComboBoxDataOrder();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshData(); // Wywołujemy odświeżenie danych po kliknięciu przycisku

        }

        private void ordername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadComboBoxDataOrder()
        {
            string connectionString = "Host=localhost;Port=32768;Username=postgres;Password=mysecretpassword;Database=postgres";
            string query = @"
        SELECT Name, price from public.shop
    ";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        NpgsqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string name = reader["name"].ToString();
                            int price;
                            if (reader["price"] != DBNull.Value)
                            {
                                price = Convert.ToInt32(reader["price"]);
                            }
                            else
                            {
                                price = 0; // lub inna wartość domyślna, jeśli DBNull jest dopuszczalne
                            }

                            // Tworzymy tekst do wyświetlenia w ComboBoxie
                            string displayText = $"{name} - {price}";
                            ordername.Items.Add(displayText);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void orderb_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ordername ComboBox
            if (ordername.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać produkt do zamówienia.");
                return;
            }


            // Get the selected value from ordername ComboBox
            string selectedOrder = ordername.SelectedItem.ToString();

            // Split the selected value to get name and price
            string[] parts = selectedOrder.Split(new string[] { " - " }, StringSplitOptions.None);
            string productName = parts[0];
            decimal productPrice = decimal.Parse(parts[1]); // Assuming price is decimal type
            int quantity = int.Parse(orderq.Text);

            decimal catPrice;
            if (!decimal.TryParse(catalogprice.Text, out catPrice))
            {
                MessageBox.Show("Niepoprawna wartość ceny katalogowej.");
                return;
            }

            // Insert into the product table
            InsertIntoProduct(productName, catPrice, quantity);
            InsertIntoBills(productName, quantity);
        }

        private void InsertIntoProduct(string productName, decimal catPrice, int quantity)
        {
            string connectionString = "Host=localhost;Port=32768;Username=postgres;Password=mysecretpassword;Database=postgres";
            string queryCheckIfExists = "SELECT productid FROM product WHERE Name = @productName AND price = @catPrice";
            string queryInsertProduct = "INSERT INTO product (Name, price, stan) VALUES (@productName, @catPrice, @quantity)";
            string queryUpdateProduct = "UPDATE product SET stan = stan + @quantity WHERE Name = @productName AND price = @catPrice";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int productId = -1;

                    // Check if product already exists
                    using (NpgsqlCommand command = new NpgsqlCommand(queryCheckIfExists, connection))
                    {
                        command.Parameters.AddWithValue("@productName", productName);
                        command.Parameters.AddWithValue("@catPrice", catPrice);
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            productId = (int)result;
                        }
                    }

                    if (productId == -1)
                    {
                        // If product does not exist, insert new product
                        using (NpgsqlCommand command = new NpgsqlCommand(queryInsertProduct, connection))
                        {
                            command.Parameters.AddWithValue("@productName", productName);
                            command.Parameters.AddWithValue("@catPrice", catPrice);
                            command.Parameters.AddWithValue("@quantity", quantity);
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // If product exists, update quantity
                        using (NpgsqlCommand command = new NpgsqlCommand(queryUpdateProduct, connection))
                        {
                            command.Parameters.AddWithValue("@productName", productName);
                            command.Parameters.AddWithValue("@catPrice", catPrice); // Correct parameter name
                            command.Parameters.AddWithValue("@quantity", quantity);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show($"Dodano/aktualizowano produkt '{productName}' w tabeli product.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void InsertIntoBills(string productName, int quantity)
        {
            string connectionString = "Host=localhost;Port=32768;Username=postgres;Password=mysecretpassword;Database=postgres";

            // Query to get product ID and price from shop table
            string queryGetProduct = "SELECT productid, price FROM public.shop WHERE name = @productName";

            // Query to insert into bills table
            string queryInsertBill = @"
        INSERT INTO public.bills (name, productid, price, quantity)
        VALUES (@productName, @productId, @productPrice, @quantity)
    ";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    int productId;
                    decimal productPrice;

                    // Retrieve product ID and price based on product name from shop table
                    using (NpgsqlCommand command = new NpgsqlCommand(queryGetProduct, connection))
                    {
                        command.Parameters.AddWithValue("@productName", productName);
                        NpgsqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            productId = Convert.ToInt32(reader["productid"]);
                            productPrice = Convert.ToDecimal(reader["price"]);
                        }
                        else
                        {
                            throw new Exception($"Product '{productName}' not found in the shop table.");
                        }
                        reader.Close();
                    }

                    // Calculate total price based on product price and quantity
                    decimal totalPrice = productPrice * quantity;

                    // Insert into bills table
                    using (NpgsqlCommand command = new NpgsqlCommand(queryInsertBill, connection))
                    {
                        command.Parameters.AddWithValue("@productName", productName);
                        command.Parameters.AddWithValue("@productId", productId);
                        command.Parameters.AddWithValue("@productPrice", productPrice); // Use original product price
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Dodano wpis do faktury dla produktu '{productName}'.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    
    }


    }

