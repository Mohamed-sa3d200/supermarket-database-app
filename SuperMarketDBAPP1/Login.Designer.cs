namespace SuperMarketDBAPP1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            txtName = new TextBox();
            txtPass = new TextBox();
            lblName = new Label();
            lblPass = new Label();
            btnLogin = new Button();
            label4 = new Label();
            btnsignup = new Button();
            SuspendLayout();
            // 
            // CircleButton1
            // 
            CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CircleButton1.FillColor = Color.LightSeaGreen;
            CircleButton1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CircleButton1.ForeColor = Color.White;
            CircleButton1.Location = new Point(-283, -8);
            CircleButton1.Name = "CircleButton1";
            CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            CircleButton1.Size = new Size(618, 581);
            CircleButton1.TabIndex = 0;
            CircleButton1.Text = "                                         Supermarket System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(451, 59);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 4;
            label2.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(341, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 32);
            label1.TabIndex = 3;
            label1.Text = "Supermarket System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(375, 513);
            label3.Name = "label3";
            label3.Size = new Size(195, 32);
            label3.TabIndex = 5;
            label3.Text = "By FCAI Team";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Customer" });
            comboBox1.Location = new Point(517, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 29);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "   Select a Role";
            // 
            // txtName
            // 
            txtName.Location = new Point(517, 232);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 32);
            txtName.TabIndex = 7;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(517, 312);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(253, 32);
            txtPass.TabIndex = 8;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(395, 241);
            lblName.Name = "lblName";
            lblName.Size = new Size(70, 23);
            lblName.TabIndex = 9;
            lblName.Text = "Name";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(375, 321);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(100, 23);
            lblPass.TabIndex = 10;
            lblPass.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSeaGreen;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(574, 378);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 48);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(375, 460);
            label4.Name = "label4";
            label4.Size = new Size(194, 23);
            label4.TabIndex = 12;
            label4.Text = "Don't Have an Account?";
            // 
            // btnsignup
            // 
            btnsignup.BackColor = Color.LightSeaGreen;
            btnsignup.ForeColor = Color.White;
            btnsignup.Location = new Point(629, 448);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(133, 48);
            btnsignup.TabIndex = 13;
            btnsignup.Text = "Sign Up";
            btnsignup.UseVisualStyleBackColor = false;
            btnsignup.Click += btnsignup_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 560);
            Controls.Add(btnsignup);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(lblPass);
            Controls.Add(lblName);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CircleButton1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton CircleButton1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox txtName;
        private TextBox txtPass;
        private Label lblName;
        private Label lblPass;
        private Button btnLogin;
        private Label label4;
        private Button btnsignup;
    }
}