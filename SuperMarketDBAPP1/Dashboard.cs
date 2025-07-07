using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SuperMarketDBAPP1
{
    public partial class Dashboard : Form
    {
        static String sql = "Data Source=DESKTOP-9DE49G5;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        
        private int _customerId;
        private decimal _currentTotalPrice = 0;
        private int? _selectedVoucherId = null;
        private decimal _selectedVoucherAmount = 0;

        public Dashboard(int customerId)

        {
            InitializeComponent();
            _customerId = customerId;
            // Attach Load event
            this.Load += Dashboard_Load;

            // Enable Save button when any text changes
            txtName.TextChanged += EnableSaveButton;
            txtEmail.TextChanged += EnableSaveButton;
            txtAddress.TextChanged += EnableSaveButton;
            txtPhone.TextChanged += EnableSaveButton;
            txtPassword.TextChanged += EnableSaveButton;

            // Save button click event
            saveBtn.Click += BtnSave_Click;
            saveBtn.Enabled = false; // Disabled by default

            // Delete button click event
            DeleteBtn.Click += DeleteBtn_Click; // delete account

        }

        // Load the first customer record into the textboxes
        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                int customerId = Session.CurrentCustomerId;

                string query = "SELECT * FROM Customer WHERE Customer_id = @id";

                using (SqlConnection con = new SqlConnection(sql))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", customerId);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Name"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            txtPhone.Text = reader["Phone"].ToString();
                            txtPassword.Text = reader["Password"].ToString(); // Optional: hide or mask
                        }
                        else
                        {
                            MessageBox.Show("Customer record not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }


        // Enable the Save button when any field is edited
        private void EnableSaveButton(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
        }

        // Update the customer record using Email as the unique identifier
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required to update the record.");
                return;
            }

            try
            {
                string query = @"UPDATE Customer 
                                 SET Name = @Name, Address = @Address, 
                                     Phone = @Phone, Password = @Password
                                 WHERE Email = @Email";

                using (SqlConnection con = new SqlConnection(sql))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer data updated successfully.");
                        saveBtn.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No matching customer found with that email.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }



        private int GetOrCreateCurrentOrderId(int customerId)
        {
            using (SqlConnection con = new SqlConnection(sql))
            {
                con.Open();

                // Check for existing pending order
                string selectQuery = @"
            SELECT Order_id FROM [Order]
            WHERE Customer_id = @CustomerId AND Status = 'Pending'";

                using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
                {
                    selectCmd.Parameters.AddWithValue("@CustomerId", customerId);
                    object result = selectCmd.ExecuteScalar();

                    if (result != null)
                        return Convert.ToInt32(result);
                }

                // If no pending order, create a new one
                string insertQuery = @"
            INSERT INTO [Order] (Customer_id)
            VALUES (@CustomerId);
            SELECT SCOPE_IDENTITY();";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@CustomerId", customerId);
                    return Convert.ToInt32(insertCmd.ExecuteScalar());
                }
            }
        }

        private void UpdateTotalPrice()
        {
            decimal total = 0;





            using (SqlConnection con = new SqlConnection(sql))
            {
                con.Open();

                string query = @"
            SELECT SUM(U_Price * Quantity)
            FROM OrderItem
            WHERE Order_id = @OrderId";

                int orderId = GetOrCreateCurrentOrderId(_customerId);

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                        total = Convert.ToDecimal(result);
                }
            }
            _currentTotalPrice = total;
            lblTotalPrice.Text = $"Total: ${total:F2}";
        }



        // LoadProducts with optional search term
        private void LoadProducts(string searchTerm = "")
        {
            flowLayoutPanelProducts.Controls.Clear(); // Clear old items

            string query = "SELECT P_Name, Description, Price, Quantity FROM Product";
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query += " WHERE P_Name LIKE @search";
            }

            using (SqlConnection con = new SqlConnection(sql))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                }

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int quantity = Convert.ToInt32(reader["Quantity"]);

                        // panel for each product
                        Panel card = new Panel();
                        card.Size = new Size(200, 200);
                        card.BorderStyle = BorderStyle.FixedSingle;
                        card.Margin = new Padding(10);

                        // product name
                        Label nameLabel = new Label();
                        //nameLabel.Text = quantity > 0 ? reader["P_Name"].ToString() : "Out Of Stock";

                        string productName = reader["P_Name"].ToString();
                        nameLabel.Text = quantity > 0 ? productName : $"{productName}\nOut of Stock";


                        nameLabel.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                        nameLabel.ForeColor = quantity > 0 ? Color.Black : Color.Red;
                        nameLabel.Location = new Point(10, 10);
                        nameLabel.Size = new Size(180, 40); // Set width to allow line wrap
                        nameLabel.AutoSize = false;         // Needed for multiline
                        nameLabel.TextAlign = ContentAlignment.TopLeft;


                        // price label
                        Label priceLabel = new Label();
                        priceLabel.Text = "$" + Convert.ToDecimal(reader["Price"]).ToString("F2");
                        priceLabel.Font = new Font("Century Gothic", 9);
                        priceLabel.Location = new Point(10, 50);
                        priceLabel.AutoSize = true;

                        // description label
                        Label descLabel = new Label();
                        descLabel.Text = reader["Description"].ToString();
                        descLabel.Font = new Font("Century Gothic", 8);
                        descLabel.Location = new Point(10, 70);
                        descLabel.Size = new Size(180, 100);

                        // add to cart button
                        Button addToCartBtn = new Button();
                        addToCartBtn.Text = "Add to Cart";
                        addToCartBtn.BackColor = Color.LightSeaGreen;
                        addToCartBtn.ForeColor = Color.White;
                        addToCartBtn.FlatStyle = FlatStyle.Flat;
                        addToCartBtn.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        addToCartBtn.Size = new Size(150, 30);
                        addToCartBtn.Location = new Point(40, 170);
                        addToCartBtn.Tag = reader["P_Name"].ToString();



                        if (quantity == 0)
                        {
                            addToCartBtn.Enabled = false;
                            addToCartBtn.BackColor = Color.Gray;
                        }
                        else
                        {
                            addToCartBtn.Click += (s, ev) =>
                            {
                                string productName = (string)((Button)s).Tag;

                                using (SqlConnection con = new SqlConnection(sql))
                                {
                                    con.Open();

                                    // Get Product ID and Price
                                    string prodQuery = "SELECT Product_id, Price FROM Product WHERE P_Name = @PName";
                                    int productId = -1;
                                    decimal price = 0;
                                    using (SqlCommand cmd = new SqlCommand(prodQuery, con))
                                    {
                                        cmd.Parameters.AddWithValue("@PName", productName);
                                        using (SqlDataReader rdr = cmd.ExecuteReader())
                                        {
                                            if (rdr.Read())
                                            {
                                                productId = Convert.ToInt32(rdr["Product_id"]);
                                                price = Convert.ToDecimal(rdr["Price"]);
                                            }
                                        }
                                    }

                                    if (productId == -1)
                                    {
                                        MessageBox.Show("Product not found!");
                                        return;
                                    }

                                    int orderId = GetOrCreateCurrentOrderId(_customerId);

                                    // Check if item already in cart
                                    string checkItemQuery = "SELECT Quantity FROM OrderItem WHERE Order_id = @OrderId AND Product_id = @ProductId";
                                    using (SqlCommand cmd = new SqlCommand(checkItemQuery, con))
                                    {
                                        cmd.Parameters.AddWithValue("@OrderId", orderId);
                                        cmd.Parameters.AddWithValue("@ProductId", productId);

                                        object result = cmd.ExecuteScalar();

                                        if (result != null)
                                        {
                                            // Update quantity
                                            int currentQty = Convert.ToInt32(result);
                                            string updateQuery = "UPDATE OrderItem SET Quantity = @Qty WHERE Order_id = @OrderId AND Product_id = @ProductId";
                                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                                            {
                                                updateCmd.Parameters.AddWithValue("@Qty", currentQty + 1);
                                                updateCmd.Parameters.AddWithValue("@OrderId", orderId);
                                                updateCmd.Parameters.AddWithValue("@ProductId", productId);
                                                updateCmd.ExecuteNonQuery();
                                            }
                                        }
                                        else
                                        {
                                            // Insert new item
                                            string insertQuery = "INSERT INTO OrderItem(Order_id, Product_id, U_Price, Quantity) VALUES (@OrderId, @ProductId, @UPrice, @Qty)";
                                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                                            {
                                                insertCmd.Parameters.AddWithValue("@OrderId", orderId);
                                                insertCmd.Parameters.AddWithValue("@ProductId", productId);
                                                insertCmd.Parameters.AddWithValue("@UPrice", price);
                                                insertCmd.Parameters.AddWithValue("@Qty", 1);
                                                insertCmd.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                }

                                MessageBox.Show($"{productName} added to cart!");
                                UpdateTotalPrice(); // Update total price after adding to cart
                            };
                        }

                        card.Controls.Add(nameLabel);
                        card.Controls.Add(priceLabel);
                        card.Controls.Add(descLabel);
                        card.Controls.Add(addToCartBtn);

                        flowLayoutPanelProducts.Controls.Add(card);
                    }
                }
            }
        }


        //Delete button
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete your account? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                int customerId = Session.CurrentCustomerId;
                string query = "DELETE FROM Customer WHERE Customer_id = @id";

                using (SqlConnection con = new SqlConnection(sql))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", customerId);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account deleted successfully.");

                        // Optionally return to login screen or close app
                        Application.Restart(); // or navigate to Login form
                    }
                    else
                    {
                        MessageBox.Show("No matching account found to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting account: " + ex.Message);
            }
        }




        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelProducts_Enter(object sender, EventArgs e)
        {
            //LoadProducts();
        }

        private void flowLayoutPanelProducts_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void shoptab_Click(object sender, EventArgs e)
        {

        }


        // tab switch
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == shoptab)
            {
                LoadProducts(); // Load all products initially
            }
            if (tabControl1.SelectedTab == tabPage3) // Assuming you have a tab for orders
            {
                LoadOrder();
                LoadCustomerVouchers();
                UpdateTotalPrice(); // Update total price when switching to the order tab

            }
        }



        // search text box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // search button
        // Search button click
        private void button2_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadProducts(searchTerm);
        }
        void LoadOrder()
        {
            flowLayoutPanelCartProducts.Controls.Clear();

            string query = @"
        SELECT 
            O.Order_id,
            P.P_Name,
            OI.Quantity,
            OI.U_Price,
            (OI.Quantity * OI.U_Price) AS TotalPrice
        FROM [Order] O
        JOIN OrderItem OI ON O.Order_id = OI.Order_id
        JOIN Product P ON P.Product_id = OI.Product_id
        WHERE O.Customer_id = @customerId AND  O.Status = 'Pending'";

            using (SqlConnection con = new SqlConnection(sql))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@customerId", _customerId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Panel card = new Panel();
                    card.Size = new Size(250, 150);
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.Margin = new Padding(10);

                    Label nameLabel = new Label();
                    nameLabel.Text = "Product: " + reader["P_Name"].ToString();
                    nameLabel.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                    nameLabel.Location = new Point(10, 10);
                    nameLabel.AutoSize = true;

                    Label quantityLabel = new Label();
                    quantityLabel.Text = "Quantity: " + reader["Quantity"].ToString();
                    quantityLabel.Location = new Point(10, 40);
                    quantityLabel.AutoSize = true;

                    Label priceLabel = new Label();
                    priceLabel.Text = "Unit Price: $" + Convert.ToDecimal(reader["U_Price"]).ToString("F2");
                    priceLabel.Location = new Point(10, 60);
                    priceLabel.AutoSize = true;

                    Label totalLabel = new Label();
                    totalLabel.Text = "Total: $" + Convert.ToDecimal(reader["TotalPrice"]).ToString("F2");
                    totalLabel.Location = new Point(10, 80);
                    totalLabel.AutoSize = true;

                    Button removeBtn = new Button();
                    removeBtn.Text = "Remove";
                    removeBtn.BackColor = Color.IndianRed;
                    removeBtn.ForeColor = Color.White;
                    removeBtn.FlatStyle = FlatStyle.Flat;
                    removeBtn.Location = new Point(10, 110);
                    removeBtn.Size = new Size(100, 30);
                    int orderId = Convert.ToInt32(reader["Order_id"]);
                    string productName = reader["P_Name"].ToString();

                    // Store orderId and productName in the Tag
                    removeBtn.Tag = new Tuple<int, string>(orderId, productName);
                    removeBtn.Click += RemoveOrderItem_Click;

                    card.Controls.Add(nameLabel);
                    card.Controls.Add(quantityLabel);
                    card.Controls.Add(priceLabel);
                    card.Controls.Add(totalLabel);
                    card.Controls.Add(removeBtn);

                    flowLayoutPanelCartProducts.Controls.Add(card);
                }

                reader.Close();
            }
        }
        private void RemoveOrderItem_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var tag = (Tuple<int, string>)btn.Tag;
            int orderId = tag.Item1;
            string productName = tag.Item2;

            // Get product id from name (you can optimize this)
            int productId = -1;
            using (SqlConnection con = new SqlConnection(sql))
            {
                string getProductIdQuery = "SELECT Product_id FROM Product WHERE P_Name = @name";
                using (SqlCommand cmd = new SqlCommand(getProductIdQuery, con))
                {
                    cmd.Parameters.AddWithValue("@name", productName);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        productId = Convert.ToInt32(result);
                }
            }

            if (productId == -1)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            using (SqlConnection con = new SqlConnection(sql))
            {
                string deleteQuery = "DELETE FROM OrderItem WHERE Order_id = @orderId AND Product_id = @productId";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Item removed from order.");
                        LoadOrder(); // Refresh the panel
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove item.");
                    }
                }
            }
        }


        private void LoadCustomerVouchers()
        {
            flowLayoutPanelVouchers.Controls.Clear();

            using (SqlConnection con = new SqlConnection(sql))
            {
                string query = @"SELECT VoucherId, VoucherCode, Amount, ExpiryDate 
                         FROM Voucher 
                         WHERE CustomerId = @CustomerId AND Status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", _customerId);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int voucherId = Convert.ToInt32(reader["VoucherId"]);
                            string voucherCode = reader["VoucherCode"].ToString();
                            decimal amount = Convert.ToDecimal(reader["Amount"]);

                            Panel voucherCard = new Panel
                            {
                                Size = new Size(200, 120),
                                BorderStyle = BorderStyle.FixedSingle,
                                Margin = new Padding(10)
                            };

                            Label codeLabel = new Label
                            {
                                Text = $"Code: {voucherCode}",
                                Location = new Point(10, 10),
                                AutoSize = true
                            };

                            Label amountLabel = new Label
                            {
                                Text = $"Amount: ${amount:F2}",
                                Location = new Point(10, 35),
                                AutoSize = true
                            };

                            Button applyBtn = new Button
                            {
                                Text = "Apply",
                                Location = new Point(10, 70),
                                Size = new Size(180, 30),
                                BackColor = Color.SeaGreen,
                                ForeColor = Color.White
                            };

                            applyBtn.Click += (s, ev) =>
                            {
                                _selectedVoucherId = voucherId;
                                _selectedVoucherAmount = amount;
                                decimal newTotal = Math.Max(0, _currentTotalPrice - amount);
                                lblTotalPrice.Text = $"Total: ${newTotal:F2}";
                                MessageBox.Show($"Voucher applied: -${amount:F2}");
                            };

                            voucherCard.Controls.Add(codeLabel);
                            voucherCard.Controls.Add(amountLabel);
                            voucherCard.Controls.Add(applyBtn);

                            flowLayoutPanelVouchers.Controls.Add(voucherCard);
                        }
                    }
                }
            }
        }











        private void flowLayoutPanelCartProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelVouchers_Paint(object sender, PaintEventArgs e)
        {

        }

        // buy button
        private void button1_Click(object sender, EventArgs e)
        {
            int orderId = GetOrCreateCurrentOrderId(_customerId);

            using (SqlConnection con = new SqlConnection(sql))
            {
                con.Open();

                if (_selectedVoucherId != null)
                {
                    // Optional: Update order with voucher info (only if you added Voucher_id column)
                    string applyVoucherQuery = @"
                UPDATE [Order]
                SET Voucher_id = @VoucherId
                WHERE Order_id = @OrderId";

                    using (SqlCommand cmd = new SqlCommand(applyVoucherQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@VoucherId", _selectedVoucherId);
                        cmd.Parameters.AddWithValue("@OrderId", orderId);
                        cmd.ExecuteNonQuery();
                    }

                    // Mark voucher as used
                    string markVoucherUsedQuery = @"
                UPDATE Voucher
                SET Status = 'Used'
                WHERE VoucherId = @VoucherId";

                    using (SqlCommand cmd = new SqlCommand(markVoucherUsedQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@VoucherId", _selectedVoucherId);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Finalize the order
                string finalizeQuery = @"
            UPDATE [Order]
            SET Status = 'Completed', Order_Date = @Now
            WHERE Order_id = @OrderId";

                using (SqlCommand cmd = new SqlCommand(finalizeQuery, con))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    cmd.Parameters.AddWithValue("@Now", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Order completed!");

            // Refresh UI
            LoadCustomerVouchers();
            LoadOrder();
            _selectedVoucherId = null;
            _selectedVoucherAmount = 0;

            // Clear order display and reset total
            flowLayoutPanelCartProducts.Controls.Clear();
            lblTotalPrice.Text = "Total: $0.00";
        }
    }
}
