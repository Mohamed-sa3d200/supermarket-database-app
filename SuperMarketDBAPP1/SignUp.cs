using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;



namespace SuperMarketDBAPP1
{
    public partial class SignUp : Form
    {
        
                 static String sql = "Data Source=DESKTOP-9DE49G5;Initial Catalog=SupermarketDatabase;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";


        public SignUp()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            label3 = new Label();
            label1 = new Label();
            comboBoxRole = new ComboBox();
            txtUsername = new TextBox();
            labelRole = new Label();
            labelName = new Label();
            labelPassword = new Label();
            txtPassword = new TextBox();
            Submitbtn = new Button();
            labelEmail = new Label();
            txtEmail = new TextBox();
            labelPhone = new Label();
            txtPhone = new TextBox();
            labelAddress = new Label();
            txtAdress = new TextBox();
            SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.FillColor = Color.LightSeaGreen;
            guna2CircleButton1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(-271, -4);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(652, 522);
            guna2CircleButton1.TabIndex = 0;
            guna2CircleButton1.Text = "                                Supermarket System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(536, 475);
            label3.Name = "label3";
            label3.Size = new Size(230, 38);
            label3.TabIndex = 6;
            label3.Text = "By FCAI Team";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(483, 9);
            label1.Name = "label1";
            label1.Size = new Size(333, 38);
            label1.TabIndex = 4;
            label1.Text = "Supermarket System";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(457, 71);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(321, 36);
            comboBoxRole.TabIndex = 7;
            comboBoxRole.SelectedIndexChanged += ComboBoxRole_SelectedIndexChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(457, 132);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(321, 37);
            txtUsername.TabIndex = 8;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.ForeColor = Color.LightSeaGreen;
            labelRole.Location = new Point(457, 48);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(62, 28);
            labelRole.TabIndex = 9;
            labelRole.Text = "Role";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.ForeColor = Color.LightSeaGreen;
            labelName.Location = new Point(457, 107);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 28);
            labelName.TabIndex = 10;
            labelName.Text = "Name";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.ForeColor = Color.LightSeaGreen;
            labelPassword.Location = new Point(457, 244);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(121, 28);
            labelPassword.TabIndex = 12;
            labelPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(457, 269);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(321, 37);
            txtPassword.TabIndex = 11;
            // 
            // Submitbtn
            // 
            Submitbtn.BackColor = Color.LightSeaGreen;
            Submitbtn.ForeColor = SystemColors.Control;
            Submitbtn.Location = new Point(536, 431);
            Submitbtn.Name = "Submitbtn";
            Submitbtn.Size = new Size(195, 35);
            Submitbtn.TabIndex = 13;
            Submitbtn.Text = "Submit";
            Submitbtn.UseVisualStyleBackColor = false;
            Submitbtn.Click += Submitbtn_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.ForeColor = Color.LightSeaGreen;
            labelEmail.Location = new Point(457, 173);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(85, 28);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(457, 198);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 37);
            txtEmail.TabIndex = 14;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.ForeColor = Color.LightSeaGreen;
            labelPhone.Location = new Point(457, 305);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(83, 28);
            labelPhone.TabIndex = 19;
            labelPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(457, 330);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(321, 37);
            txtPhone.TabIndex = 18;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.ForeColor = Color.LightSeaGreen;
            labelAddress.Location = new Point(457, 367);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(107, 28);
            labelAddress.TabIndex = 21;
            labelAddress.Text = "Address";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(457, 392);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(321, 37);
            txtAdress.TabIndex = 20;
            // 
            // SignUp
            // 
            ClientSize = new Size(882, 513);
            Controls.Add(labelAddress);
            Controls.Add(txtAdress);
            Controls.Add(labelPhone);
            Controls.Add(txtPhone);
            Controls.Add(labelEmail);
            Controls.Add(txtEmail);
            Controls.Add(Submitbtn);
            Controls.Add(labelPassword);
            Controls.Add(txtPassword);
            Controls.Add(labelName);
            Controls.Add(labelRole);
            Controls.Add(txtUsername);
            Controls.Add(comboBoxRole);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(guna2CircleButton1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        // On Form Load: Populate ComboBox
        private void SignUp_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Clear(); // Safety first
            comboBoxRole.Items.Add("Admin");
            comboBoxRole.Items.Add("Customer");
            comboBoxRole.SelectedItem = "Customer"; // Default selection
        }

        //  React to Role Change (optional logic)
        private void ComboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = comboBoxRole.SelectedItem?.ToString();

            bool isAdmin = selectedRole == "Admin";

            // Hide Address and Phone for Admin
            labelAddress.Visible = !isAdmin;
            txtAdress.Visible = !isAdmin;
        }

        //  Controls
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Label label3;
        private Label label1;
        private ComboBox comboBoxRole;
        private TextBox txtUsername;
        private Label labelRole;
        private Label labelName;
        private Label labelPassword;
        private TextBox txtPassword;
        private Button Submitbtn;
        private Label labelEmail;
        private TextBox txtEmail;
        private Label labelPhone;
        private Label labelAddress;
        private TextBox txtAdress;
        private TextBox txtPhone;


        // send data to tables

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAdress.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string role = comboBoxRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(sql))
                {
                    conn.Open();

                    string query;

                    if (role == "Admin")
                    {
                        query = @"INSERT INTO Admin (Name, Email, Password, Phone)
                          VALUES (@Username, @Email, @Password, @Phone)";
                    }
                    else
                    {
                        query = @"INSERT INTO Customer (Name, Email, Password, Address, Phone)
                          VALUES (@Username, @Email, @Password, @Address, @Phone)";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Phone", phone);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"{role} registered successfully!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        // end of the class
    }
}
