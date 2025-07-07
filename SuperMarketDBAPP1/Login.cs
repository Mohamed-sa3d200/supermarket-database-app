using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SuperMarketDBAPP1
{
    public partial class Login : Form
    {

        static string sql = "Data Source=DESKTOP-9DE49G5;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Ensure comboBox1 is populated
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Admin", "Customer" });
            comboBox1.SelectedIndex = 0; // Optional: default selection
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role = comboBox1.SelectedItem?.ToString();
            string username = txtName?.Text.Trim();
            string password = txtPass?.Text;

            if (string.IsNullOrEmpty(role) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields and select a role.");
                return;
            }

            string query = "";
            if (role == "Admin")
                query = "SELECT COUNT(*) FROM Admin WHERE Name = @username AND Password = @password";
            else if (role == "Customer")
                query = "SELECT Customer_id FROM Customer WHERE Name = @username AND Password = @password";
            else
            {
                MessageBox.Show("Invalid role selected.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(sql))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (role == "Admin")
                    {
                        int count = Convert.ToInt32(result);
                        if (count > 0)
                        {
                            MessageBox.Show("Admin login successful!");
                            AdminDashboard adminForm = new AdminDashboard();
                            adminForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid admin credentials.");
                        }
                    }
                    else // Customer
                    {
                        if (result != null)
                        {
                            int customerId = Convert.ToInt32(result);
                            Session.CurrentCustomerId = customerId;

                            MessageBox.Show("Customer login successful!");
                            Dashboard customerForm = new Dashboard(customerId);
                            customerForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid customer credentials.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message);

            }
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();

            // When signup closes, show the login form again
            signUpForm.FormClosed += (s, args) => this.Show();

            this.Hide();
            signUpForm.Show();
        }
    }
}
