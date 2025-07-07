using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SuperMarketDBAPP1
{
    public partial class AdminDashboard : Form
    {
        static string sql = "Data Source=DESKTOP-9DE49G5;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        
        public AdminDashboard()
        {
            InitializeComponent();
        }


        //phone label
        private void label5_Click(object sender, EventArgs e)
        {

        }

        //======================================
        // Products tab
        private void LoadAllProducts()
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = "SELECT * FROM Product";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }

        private void LoadLowStockProducts()
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = "SELECT * FROM Product WHERE StockQuantity < MinStockThreshold";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }



        //======================================



        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = textBoxName.Text.Trim();
            string password = textBox3Pass.Text.Trim();
            string email = textBox2Email.Text.Trim();
            string address = textBox5Address.Text.Trim();
            string phone = textBox4Phone.Text.Trim();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    conn.Open();

                    string query = @"INSERT INTO Customer (Name, Email, Password, Address, Phone)
                          VALUES (@Username, @Email, @Password, @Address, @Phone)";





                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"{username} registered successfully!");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void OrdersPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    conn.Open();
                    string query = "SELECT * FROM [Order]";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewOrders.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load orders: " + ex.Message);
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPageOrders.SelectedTab == tabPage3)
            {
                LoadOrders();
            }

            if (tabPageOrders.SelectedTab == tabPagefreqCustomers)
            {
                LoadFrequentCustomers();
            }


            if (tabPageOrders.SelectedTab == tabPageProducts)
            {
                LoadAllProducts();
            }
            if (tabPageOrders.SelectedTab == tabPageCategories)
            {
                LoadCategories();
            }
            if (tabPageOrders.SelectedTab == tabPageSuppliers)
            {
                LoadSuppliers();
            }

        }

        private void LoadFrequentCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    c.Customer_id,
                    c.Name,
                    c.Email,
                    COUNT(o.Order_id) AS NumberOfOrders
                FROM 
                    Customer c
                LEFT JOIN 
                    [Order] o ON c.Customer_id = o.Customer_id
                GROUP BY 
                    c.Customer_id, c.Name, c.Email
                ORDER BY 
                    NumberOfOrders DESC;";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvFreqCustomers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load frequent customers: " + ex.Message);
            }
        }

        private void dgvFreqCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCID.Text = dgvFreqCustomers.Rows[e.RowIndex].Cells["Customer_id"].Value.ToString();
            }
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            // Read values from inputs
            string customerIdText = txtCID.Text.Trim();
            string amountText = txtAmount.Text.Trim();
            string code = txtCode.Text.Trim();
            DateTime expiryDate = dateTimePicker1.Value;

            // Basic validation
            if (string.IsNullOrEmpty(customerIdText) || string.IsNullOrEmpty(amountText) || string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(customerIdText, out int customerId))
            {
                MessageBox.Show("Customer ID must be a valid number.");
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Amount must be a valid positive number.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    conn.Open();

                    string insertQuery = @"
                INSERT INTO Voucher (CustomerId, VoucherCode, Amount, ExpiryDate, Status)
                VALUES (@CustomerId, @VoucherCode, @Amount, @ExpiryDate, 'Active')";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        cmd.Parameters.AddWithValue("@VoucherCode", code);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Voucher added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add voucher.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tabPagefreqCustomers_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadAllCustomers()
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = "SELECT * FROM Customer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
        }
        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            LoadAllCustomers();
        }

        private void btnViewFreqCustomers_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"
                    SELECT 
                    c.Customer_id,
                    c.Name,
                    c.Email,
                    COUNT(o.Order_id) AS NumberOfOrders
                    FROM 
                        Customer c
                    INNER JOIN 
                        [Order] o ON c.Customer_id = o.Customer_id
                    GROUP BY 
                        c.Customer_id, c.Name, c.Email
                    ORDER BY 
                        NumberOfOrders DESC;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCustomers.DataSource = dt;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtCIDDel.Text))
            {
                MessageBox.Show("Please enter a Customer ID to delete.", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId;
            if (!int.TryParse(txtCIDDel.Text, out customerId))
            {
                MessageBox.Show("Invalid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this customer and all related data?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(sql))
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // 1. Delete OrderItems
                    string deleteOrderItemsQuery = @"
                DELETE FROM OrderItem 
                WHERE Order_id IN (SELECT Order_id FROM [Order] WHERE Customer_id = @Id)";
                    using (SqlCommand cmd = new SqlCommand(deleteOrderItemsQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Id", customerId);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Delete Orders
                    string deleteOrdersQuery = "DELETE FROM [Order] WHERE Customer_id = @Id";
                    using (SqlCommand cmd = new SqlCommand(deleteOrdersQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Id", customerId);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. Delete Customer
                    string deleteCustomerQuery = "DELETE FROM Customer WHERE Customer_id = @Id";
                    using (SqlCommand cmd = new SqlCommand(deleteCustomerQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Id", customerId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Customer not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            transaction.Rollback();
                            return;
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Customer and all related data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllCustomers();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = "INSERT INTO Customer (Name, Email, Phone, Password, Address) VALUES (@Name, @Email, @Phone, @Password, @Address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtCName.Text);
                cmd.Parameters.AddWithValue("@Email", txtCEmail.Text);
                cmd.Parameters.AddWithValue("@Phone", txtCPhone.Text);
                cmd.Parameters.AddWithValue("@Password", txtCPass.Text);
                cmd.Parameters.AddWithValue("@Address", txtCAddress.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAllCustomers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure we have a valid ID to edit
                if (string.IsNullOrWhiteSpace(txtCIDDel.Text))
                {
                    MessageBox.Show("Please enter the Customer ID to edit.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(sql))
                {
                    List<string> setClauses = new List<string>();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (!string.IsNullOrWhiteSpace(txtCName.Text))
                    {
                        setClauses.Add("Name = @Name");
                        cmd.Parameters.AddWithValue("@Name", txtCName.Text);
                    }

                    if (!string.IsNullOrWhiteSpace(txtCEmail.Text))
                    {
                        setClauses.Add("Email = @Email");
                        cmd.Parameters.AddWithValue("@Email", txtCEmail.Text);
                    }

                    if (!string.IsNullOrWhiteSpace(txtCPhone.Text))
                    {
                        setClauses.Add("Phone = @Phone");
                        cmd.Parameters.AddWithValue("@Phone", txtCPhone.Text);
                    }

                    if (!string.IsNullOrWhiteSpace(txtCPass.Text))
                    {
                        setClauses.Add("Password = @Password");
                        cmd.Parameters.AddWithValue("@Password", txtCPass.Text);
                    }

                    if (!string.IsNullOrWhiteSpace(txtCAddress.Text))
                    {
                        setClauses.Add("Address = @Address");
                        cmd.Parameters.AddWithValue("@Address", txtCAddress.Text);
                    }

                    if (setClauses.Count == 0)
                    {
                        MessageBox.Show("Please fill in at least one field to update.");
                        return;
                    }

                    cmd.Parameters.AddWithValue("@Id", txtCIDDel.Text);

                    string query = "UPDATE Customer SET " + string.Join(", ", setClauses) + " WHERE Customer_id = @Id";
                    cmd.CommandText = query;

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                        MessageBox.Show("No customer found with that ID.");
                    else
                        MessageBox.Show("Customer updated successfully.");
                }

                LoadAllCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddV_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text) ||
                string.IsNullOrWhiteSpace(txtVCode.Text) ||
                string.IsNullOrWhiteSpace(txtVAmount.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            // Parse and validate inputs
            if (!int.TryParse(txtCustomerID.Text, out int customerId))
            {
                MessageBox.Show("Customer ID must be a valid number.");
                return;
            }

            if (!decimal.TryParse(txtVAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Amount must be a valid positive number.");
                return;
            }

            string vCode = txtVCode.Text.Trim();
            DateTime expiryDate = dateTimePicker2.Value;


            using (SqlConnection conn = new SqlConnection(sql))
            {
                try
                {
                    conn.Open();

                    string query = @"
                INSERT INTO Voucher (CustomerId, VoucherCode, Amount, ExpiryDate, Status)
                VALUES (@CustomerId, @VoucherCode, @Amount, @ExpiryDate, 'Active')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);
                        cmd.Parameters.AddWithValue("@VoucherCode", vCode);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Voucher added successfully.");
                        else
                            MessageBox.Show("Failed to add voucher.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"INSERT INTO Product (P_Name, Description, Price, Quantity, StockQuantity, MinStockThreshold, Category_id, Supplier_id) 
                         VALUES (@Name, @Desc, @Price, @Qty, @Stock, @Min, @CatId, @SupId)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtPname.Text);
                cmd.Parameters.AddWithValue("@Desc", txtPdesc.Text);
                if (string.IsNullOrWhiteSpace(txtPprice.Text))
                {
                    MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal price;
                if (!decimal.TryParse(txtPprice.Text, out price))
                {
                    MessageBox.Show("Invalid format for price. Please enter a numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPprice.Text));
                cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(txtPquantity.Text));
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtPquantity.Text));
                cmd.Parameters.AddWithValue("@Min", Convert.ToInt32(txtPminThres.Text));
                cmd.Parameters.AddWithValue("@CatId", Convert.ToInt32(txtPcategory.Text));
                cmd.Parameters.AddWithValue("@SupId", Convert.ToInt32(txtPsupplier.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadAllProducts();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Product_id"].Value);
                List<string> updates = new List<string>();
                SqlCommand cmd = new SqlCommand();

                if (!string.IsNullOrWhiteSpace(txtPname.Text))
                {
                    updates.Add("P_Name = @Name");
                    cmd.Parameters.AddWithValue("@Name", txtPname.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtPdesc.Text))
                {
                    updates.Add("Description = @Desc");
                    cmd.Parameters.AddWithValue("@Desc", txtPdesc.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtPprice.Text))
                {
                    updates.Add("Price = @Price");
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPprice.Text));
                }
                if (!string.IsNullOrWhiteSpace(txtPquantity.Text))
                {
                    updates.Add("Quantity = @Qty");
                    updates.Add("StockQuantity = @Stock");
                    int qty = Convert.ToInt32(txtPquantity.Text);
                    cmd.Parameters.AddWithValue("@Qty", qty);
                    cmd.Parameters.AddWithValue("@Stock", qty); // same value
                }
                if (!string.IsNullOrWhiteSpace(txtPminThres.Text))
                {
                    updates.Add("MinStockThreshold = @Min");
                    cmd.Parameters.AddWithValue("@Min", Convert.ToInt32(txtPminThres.Text));
                }
                if (!string.IsNullOrWhiteSpace(txtPcategory.Text))
                {
                    updates.Add("Category_id = @CatId");
                    cmd.Parameters.AddWithValue("@CatId", Convert.ToInt32(txtPcategory.Text));
                }
                if (!string.IsNullOrWhiteSpace(txtPsupplier.Text))
                {
                    updates.Add("Supplier_id = @SupId");
                    cmd.Parameters.AddWithValue("@SupId", Convert.ToInt32(txtPsupplier.Text));
                }

                if (updates.Count == 0)
                {
                    MessageBox.Show("Please fill at least one field to update.", "No Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string query = $"UPDATE Product SET {string.Join(", ", updates)} WHERE Product_id = @Id";
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id", productId);

                using (SqlConnection conn = new SqlConnection(sql))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadAllProducts();
                MessageBox.Show("Product updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int productId = -1;

            // Try getting ID from txtPID
            if (!string.IsNullOrWhiteSpace(txtPID.Text))
            {
                if (!int.TryParse(txtPID.Text, out productId))
                {
                    MessageBox.Show("Invalid Product ID. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (dgvProducts.CurrentRow != null)
            {
                // Try getting ID from selected row if textbox is empty
                productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Product_id"].Value);
            }
            else
            {
                MessageBox.Show("Please select a product or enter a valid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm delete
            var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(sql))
                    {
                        string query = "DELETE FROM Product WHERE Product_id = @Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", productId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllProducts();
                            txtPID.Clear(); // optional: clear textbox
                        }
                        else
                        {
                            MessageBox.Show("No product found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error deleting product:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string keyword = txtPSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a product name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = "SELECT * FROM Product WHERE P_Name LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No products found matching your search.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dgvProducts.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Product_id"].Value);
                int restockAmount = Convert.ToInt32(txtPquantity.Text);

                using (SqlConnection conn = new SqlConnection(sql))
                {
                    string query = "UPDATE Product SET StockQuantity = StockQuantity + @Amount WHERE Product_id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Amount", restockAmount);
                    cmd.Parameters.AddWithValue("@Id", productId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadAllProducts();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPSearch.Clear();
            LoadAllProducts();
        }

        private void btnShowLowStock_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = "SELECT * FROM Product WHERE StockQuantity < MinStockThreshold";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvProducts.DataSource = table;
            }
        }

        private void btnShowAllProducts_Click(object sender, EventArgs e)
        {
            LoadAllProducts();

        }

        private void btnMostBought_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"
            SELECT TOP 1 
                P.*, 
                SUM(OI.Quantity) AS TotalSold
            FROM 
                Product P
            JOIN 
                OrderItem OI ON P.Product_id = OI.Product_id
            GROUP BY 
                P.Product_id, P.P_Name, P.Description, P.Price, P.Quantity, 
                P.StockQuantity, P.MinStockThreshold, P.Category_id, P.Supplier_id
            ORDER BY 
                TotalSold DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvProducts.DataSource = table;
            }
        }

        private void btnNotBought_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"
            SELECT * 
            FROM Product 
            WHERE Product_id NOT IN (
                SELECT DISTINCT OI.Product_id
                FROM OrderItem OI
                JOIN [Order] O ON O.Order_id = OI.Order_id
                WHERE MONTH(O.Order_Date) = MONTH(GETDATE())
                  AND YEAR(O.Order_Date) = YEAR(GETDATE())
            )";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvProducts.DataSource = table;
            }
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"
            SELECT * 
            FROM Customer
            WHERE Customer_id NOT IN (
                SELECT DISTINCT Customer_id
                FROM [Order]
                WHERE Order_Date >= DATEADD(YEAR, -1, GETDATE())
            )";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCustomers.DataSource = table;
            }
        }

        private void btnResetCutomers_Click(object sender, EventArgs e)
        {
            LoadAllCustomers();
        }


        // top selling category
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"
            SELECT c.Category_name, SUM(oi.Quantity * oi.U_Price) AS TotalSales
            FROM OrderItem oi
            JOIN Product p ON oi.Product_id = p.Product_id
            JOIN Category c ON p.Category_id = c.Category_id
            GROUP BY c.Category_name";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                Dictionary<string, decimal> categorySales = new Dictionary<string, decimal>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string category = reader["Category_name"].ToString();
                        decimal sales = Convert.ToDecimal(reader["TotalSales"]);
                        categorySales[category] = sales;
                    }
                }

                if (categorySales.Count == 0)
                {
                    MessageBox.Show("No sales data available.");
                    return;
                }

                // Now compare
                string topCategory = categorySales.OrderByDescending(x => x.Value).First().Key;
                decimal topSales = categorySales[topCategory];

                string message = $" The supermarket is selling more **{topCategory}** products!\n\nTotal Sales: {topSales:C2}";
                MessageBox.Show(message, "Sales Comparison", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadProductsWithCustomerCount()
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                string query = @"
            SELECT 
                p.Product_id,
                p.P_Name,
                p.Description,
                p.Price,
                p.Quantity,
                p.StockQuantity,
                p.MinStockThreshold,
                p.Category_id,
                p.Supplier_id,
                COUNT(DISTINCT o.Customer_id) AS NumberOfCustomers
            FROM Product p
            LEFT JOIN OrderItem oi ON p.Product_id = oi.Product_id
            LEFT JOIN [Order] o ON oi.Order_id = o.Order_id
            GROUP BY 
                p.Product_id,
                p.P_Name,
                p.Description,
                p.Price,
                p.Quantity,
                p.StockQuantity,
                p.MinStockThreshold,
                p.Category_id,
                p.Supplier_id
        ";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }

        private void btnProductPerCustomer_Click(object sender, EventArgs e)
        {
            LoadProductsWithCustomerCount();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            using (SqlConnection con = new SqlConnection(sql))
            {
                con.Open();
                string query = "select * from Category";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgvCategory.DataSource = ds.Tables[0];
            }

        }
        private void btnAddC_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
                {
                    MessageBox.Show("Please enter a valid category name.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(sql))
                {
                    con.Open();
                    string query = "INSERT INTO Category (Category_name, Description) VALUES (@Name, @Description)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtCategoryName.Text);
                        cmd.Parameters.AddWithValue("@Description", TxtCategoryDescription.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Category Added Successfully");
                    populate();
                    txtCategoryName.Text = "";
                    TxtCategoryDescription.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void LoadCategories()
        {
            using (SqlConnection con = new SqlConnection(sql))
            {
                string query = "SELECT * FROM Category";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCategory.DataSource = dt;
            }
        }
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCategories();
        }

        private void btnUpdateC_Click(object sender, EventArgs e)
        {
            if (dgvCategory.CurrentRow != null)
            {
                int categoryId = Convert.ToInt32(dgvCategory.CurrentRow.Cells["Category_id"].Value);

                using (SqlConnection con = new SqlConnection(sql))
                {
                    string query = @"UPDATE Category SET Category_name=@Name, Description=@Desc WHERE Category_id=@Id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", txtCategoryName.Text);
                    cmd.Parameters.AddWithValue("@Desc", TxtCategoryDescription.Text);
                    cmd.Parameters.AddWithValue("@Id", categoryId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadCategories();
            }

        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            int categoryId = -1;
            // Try getting ID from txtPID
            if (!string.IsNullOrWhiteSpace(txtCategoryID.Text))
            {
                if (!int.TryParse(txtCategoryID.Text, out categoryId))
                {
                    MessageBox.Show("Invalid Category ID. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (dgvCategory.CurrentRow != null)
            {
                // Try getting ID from selected row if textbox is empty
                categoryId = Convert.ToInt32(dgvCategory.CurrentRow.Cells["Category_id"].Value);
            }
            else
            {
                MessageBox.Show("Please select a category or enter a valid Category ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            // Perform deletion
            try
            {
                using (SqlConnection con = new SqlConnection(sql))
                {
                    con.Open();
                    string query = "DELETE FROM Category WHERE Category_id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", categoryId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            populate(); // Refresh the DataGridView
                            txtCategoryID.Text = "";
                            txtCategoryName.Text = "";
                            TxtCategoryDescription.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No category found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadSuppliers()
        {
            using (SqlConnection con = new SqlConnection(sql))
            {
                string query = "SELECT * FROM Supplier";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dvgSuppliers.DataSource = dt;
            }
        }


        private void btnAddS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Please enter a supplier name.");
                return;
            }

            using (SqlConnection con = new SqlConnection(sql))
            {
                con.Open();
                string query = "INSERT INTO Supplier (S_Name, Address, Phone) VALUES (@Name, @Address, @Phone)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtSupplierName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtSupplierAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtSupplierPhone.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Supplier added successfully.");
                LoadSuppliers(); // Refresh your DataGridView or List
                txtSupplierName.Text = "";
                txtSupplierAddress.Text = "";
                txtSupplierPhone.Text = "";
            }
        }

        private void btnUpdateS_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSupplierID.Text, out int supplierId))
            {
                MessageBox.Show("Invalid Supplier ID.");
                return;
            }

            using (SqlConnection con = new SqlConnection(sql))
            {
                con.Open();
                string query = "UPDATE Supplier SET S_Name = @Name, Address = @Address, Phone = @Phone WHERE Supplier_id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", supplierId);
                    cmd.Parameters.AddWithValue("@Name", txtSupplierName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtSupplierAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtSupplierPhone.Text);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Supplier updated successfully.");
                    else
                        MessageBox.Show("Supplier not found.");
                }
                LoadSuppliers();
            }
        }

        private void btnDeleteS_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSupplierID.Text, out int supplierId))
            {
                MessageBox.Show("Invalid Supplier ID.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection con = new SqlConnection(sql))
            {
                con.Open();
                string query = "DELETE FROM Supplier WHERE Supplier_id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", supplierId);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Supplier deleted successfully.");
                    else
                        MessageBox.Show("Supplier not found.");
                }
                LoadSuppliers();
                txtSupplierID.Text = "";
                txtSupplierName.Text = "";
                txtSupplierAddress.Text = "";
                txtSupplierPhone.Text = "";
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private PdfPTable CreateTableFromQuery(string query)
        {

            PdfPTable table; 
            

            using (SqlConnection con = new SqlConnection(sql))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                int columnCount = reader.FieldCount;
                table = new PdfPTable(columnCount);
                table.WidthPercentage = 100;
                table.SpacingBefore = 10f;
                table.SpacingAfter = 10f;

                // Add header
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    table.AddCell(new Phrase(reader.GetName(i), FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                }

                // Add rows
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        table.AddCell(reader[i].ToString());
                    }
                }

                reader.Close();
            }

            return table;
        }

        private void GeneratePDFReport(string filePath)
        {
            Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Fonts
            iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            iTextSharp.text.Font headingFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
            iTextSharp.text.Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

            // Title
            Paragraph title = new Paragraph("Supermarket Insight Report", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
            doc.Add(new Paragraph("\n"));

            // Section A - Most bought product
            doc.Add(new Paragraph("a. Most Bought Product", headingFont));
            doc.Add(new Paragraph("Displays the product that had the maximum number of customers.", normalFont));
            doc.Add(CreateTableFromQuery("SELECT TOP 1 P.P_Name, COUNT(DISTINCT O.Customer_id) AS CustomerCount FROM [OrderItem] OI JOIN [Order] O ON OI.Order_id = O.Order_id JOIN Product P ON OI.Product_id = P.Product_id GROUP BY P.P_Name ORDER BY CustomerCount DESC"));
            doc.Add(new Paragraph("\n"));

            // Section B - Product with no customers for specific month
            doc.Add(new Paragraph("b. Products Not Bought in the Current Month ", headingFont));
            doc.Add(new Paragraph("Lists products that were not bought in this month.", normalFont));
            doc.Add(CreateTableFromQuery("SELECT P.P_Name FROM Product P WHERE P.Product_id NOT IN (   SELECT OI.Product_id     FROM OrderItem OI    JOIN [Order] O ON O.Order_id = OI.Order_id   WHERE MONTH(O.Order_date) = MONTH(GETDATE())      AND YEAR(O.Order_date) = YEAR(GETDATE()))"));
            doc.Add(new Paragraph("\n"));

            // Section C - Customers with no purchase in one year
            doc.Add(new Paragraph("c. Inactive Customers (1 year)", headingFont));
            doc.Add(new Paragraph("Customers who haven’t bought anything in the past year.", normalFont));
            doc.Add(CreateTableFromQuery("SELECT C.Name FROM Customer C WHERE C.Customer_id NOT IN (SELECT DISTINCT Customer_id FROM [Order] WHERE Order_date >= DATEADD(YEAR, -1, GETDATE()))"));
            doc.Add(new Paragraph("\n"));

            // Section D - Highest purchasing customer this month
            doc.Add(new Paragraph("d. Top Customer This Month", headingFont));
            doc.Add(new Paragraph("Customer who spent the most this month.", normalFont));
            doc.Add(CreateTableFromQuery("SELECT TOP 1 C.Name, SUM(OI.Quantity * OI.U_Price) AS TotalSpent FROM Customer C JOIN [Order] O ON C.Customer_id = O.Customer_id JOIN OrderItem OI ON O.Order_id = OI.Order_id WHERE MONTH(O.Order_date) = MONTH(GETDATE()) GROUP BY C.Name ORDER BY TotalSpent DESC"));
            doc.Add(new Paragraph("\n"));

            // Section E - Sales comparison between food and electric
            doc.Add(new Paragraph("e. Category Sales Comparison", headingFont));
            doc.Add(new Paragraph("Compare total sales between food and electric appliances.", normalFont));
            doc.Add(CreateTableFromQuery("SELECT CAT.Category_name, SUM(OI.Quantity * OI.U_Price) AS TotalSales FROM OrderItem OI JOIN Product P ON OI.Product_id = P.Product_id JOIN Category CAT ON P.Category_id = CAT.Category_id GROUP BY CAT.Category_name"));
            doc.Add(new Paragraph("\n"));

            // Section F - Product + number of customers who bought it
            doc.Add(new Paragraph("f. Product + Customer Count", headingFont));
            doc.Add(new Paragraph("List of each product and how many unique customers bought it.", normalFont));
            doc.Add(CreateTableFromQuery("SELECT P.P_Name, COUNT(DISTINCT O.Customer_id) AS CustomerCount FROM OrderItem OI JOIN [Order] O ON O.Order_id = OI.Order_id JOIN Product P ON OI.Product_id = P.Product_id GROUP BY P.P_Name"));
            doc.Add(new Paragraph("\n"));

            doc.Close();

            MessageBox.Show("PDF Report Generated Successfully!");
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string fileName = "Supermarket_Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
            string filePath = Path.Combine(downloadsPath, fileName);

            GeneratePDFReport(filePath);

            MessageBox.Show("Report saved to Downloads folder:\n" + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
