namespace SuperMarketDBAPP1
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            tabPageOrders = new TabControl();
            tabPageCustomers = new TabPage();
            button1 = new Button();
            btnResetCutomers = new Button();
            btnInactive = new Button();
            txtCIDDel = new TextBox();
            label21 = new Label();
            txtCName = new TextBox();
            label20 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label16 = new Label();
            label18 = new Label();
            txtVAmount = new TextBox();
            label19 = new Label();
            txtVCode = new TextBox();
            btnAddV = new Button();
            btnViewFreqCustomers = new Button();
            btnAdd = new Button();
            dgvCustomers = new DataGridView();
            txtCAddress = new TextBox();
            label17 = new Label();
            txtCPhone = new TextBox();
            label15 = new Label();
            txtCPass = new TextBox();
            label14 = new Label();
            txtCEmail = new TextBox();
            label13 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            txtCustomerID = new TextBox();
            label12 = new Label();
            tabPageCategories = new TabPage();
            label35 = new Label();
            txtCategoryID = new TextBox();
            TxtCategoryDescription = new TextBox();
            lblDesc = new Label();
            txtCategoryName = new TextBox();
            lblName = new Label();
            btnDeleteC = new Button();
            btnUpdateC = new Button();
            btnAddC = new Button();
            label31 = new Label();
            dgvCategory = new DataGridView();
            tabPageProducts = new TabPage();
            btnProductPerCustomer = new Button();
            btnNotBought = new Button();
            btnMostBought = new Button();
            btnShowAllProducts = new Button();
            btnShowLowStock = new Button();
            btnReset = new Button();
            label29 = new Label();
            txtPID = new TextBox();
            txtPSearch = new TextBox();
            btnSearchProduct = new Button();
            btnRestock = new Button();
            btnDeleteProduct = new Button();
            btnEditProduct = new Button();
            btnAddProduct = new Button();
            txtPsupplier = new TextBox();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            txtPcategory = new TextBox();
            txtPminThres = new TextBox();
            txtPquantity = new TextBox();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            txtPprice = new TextBox();
            txtPdesc = new TextBox();
            txtPname = new TextBox();
            dgvProducts = new DataGridView();
            tabPageSuppliers = new TabPage();
            txtSupplierAddress = new TextBox();
            label37 = new Label();
            label36 = new Label();
            txtSupplierID = new TextBox();
            txtSupplierPhone = new TextBox();
            label32 = new Label();
            txtSupplierName = new TextBox();
            label33 = new Label();
            btnDeleteS = new Button();
            btnUpdateS = new Button();
            btnAddS = new Button();
            label34 = new Label();
            dvgSuppliers = new DataGridView();
            tabPage3 = new TabPage();
            label30 = new Label();
            dataGridViewOrders = new DataGridView();
            tabPagefreqCustomers = new TabPage();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            txtAmount = new TextBox();
            label8 = new Label();
            txtCode = new TextBox();
            label7 = new Label();
            txtCID = new TextBox();
            btnAddVoucher = new Button();
            dgvFreqCustomers = new DataGridView();
            tabPageaddcustomer = new TabPage();
            btnSave = new Button();
            textBox5Address = new TextBox();
            textBox4Phone = new TextBox();
            textBox3Pass = new TextBox();
            textBox2Email = new TextBox();
            textBoxName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGenerateReport = new Button();
            tabPageOrders.SuspendLayout();
            tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tabPageSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgSuppliers).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            tabPagefreqCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFreqCustomers).BeginInit();
            tabPageaddcustomer.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageOrders
            // 
            tabPageOrders.Controls.Add(tabPageCustomers);
            tabPageOrders.Controls.Add(tabPageCategories);
            tabPageOrders.Controls.Add(tabPageProducts);
            tabPageOrders.Controls.Add(tabPageSuppliers);
            tabPageOrders.Controls.Add(tabPage3);
            tabPageOrders.Controls.Add(tabPagefreqCustomers);
            tabPageOrders.Controls.Add(tabPageaddcustomer);
            tabPageOrders.Location = new Point(0, -3);
            tabPageOrders.Name = "tabPageOrders";
            tabPageOrders.SelectedIndex = 0;
            tabPageOrders.Size = new Size(1258, 714);
            tabPageOrders.TabIndex = 0;
            tabPageOrders.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPageCustomers
            // 
            tabPageCustomers.BackColor = Color.LightSeaGreen;
            tabPageCustomers.Controls.Add(button1);
            tabPageCustomers.Controls.Add(btnResetCutomers);
            tabPageCustomers.Controls.Add(btnInactive);
            tabPageCustomers.Controls.Add(txtCIDDel);
            tabPageCustomers.Controls.Add(label21);
            tabPageCustomers.Controls.Add(txtCName);
            tabPageCustomers.Controls.Add(label20);
            tabPageCustomers.Controls.Add(dateTimePicker2);
            tabPageCustomers.Controls.Add(label16);
            tabPageCustomers.Controls.Add(label18);
            tabPageCustomers.Controls.Add(txtVAmount);
            tabPageCustomers.Controls.Add(label19);
            tabPageCustomers.Controls.Add(txtVCode);
            tabPageCustomers.Controls.Add(btnAddV);
            tabPageCustomers.Controls.Add(btnViewFreqCustomers);
            tabPageCustomers.Controls.Add(btnAdd);
            tabPageCustomers.Controls.Add(dgvCustomers);
            tabPageCustomers.Controls.Add(txtCAddress);
            tabPageCustomers.Controls.Add(label17);
            tabPageCustomers.Controls.Add(txtCPhone);
            tabPageCustomers.Controls.Add(label15);
            tabPageCustomers.Controls.Add(txtCPass);
            tabPageCustomers.Controls.Add(label14);
            tabPageCustomers.Controls.Add(txtCEmail);
            tabPageCustomers.Controls.Add(label13);
            tabPageCustomers.Controls.Add(btnDelete);
            tabPageCustomers.Controls.Add(btnEdit);
            tabPageCustomers.Controls.Add(txtCustomerID);
            tabPageCustomers.Controls.Add(label12);
            tabPageCustomers.Location = new Point(4, 39);
            tabPageCustomers.Name = "tabPageCustomers";
            tabPageCustomers.Padding = new Padding(3);
            tabPageCustomers.Size = new Size(1250, 671);
            tabPageCustomers.TabIndex = 4;
            tabPageCustomers.Text = "Customers";
            tabPageCustomers.Click += tabPage4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(481, 535);
            button1.Name = "button1";
            button1.Size = new Size(288, 43);
            button1.TabIndex = 30;
            button1.Text = "Top Selling Category";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnResetCutomers
            // 
            btnResetCutomers.BackColor = Color.LightSeaGreen;
            btnResetCutomers.CausesValidation = false;
            btnResetCutomers.ForeColor = Color.White;
            btnResetCutomers.Location = new Point(431, 331);
            btnResetCutomers.Name = "btnResetCutomers";
            btnResetCutomers.Size = new Size(97, 43);
            btnResetCutomers.TabIndex = 29;
            btnResetCutomers.Text = "Reset";
            btnResetCutomers.UseVisualStyleBackColor = false;
            btnResetCutomers.Click += btnResetCutomers_Click;
            // 
            // btnInactive
            // 
            btnInactive.BackColor = Color.LightSeaGreen;
            btnInactive.FlatStyle = FlatStyle.Flat;
            btnInactive.ForeColor = Color.White;
            btnInactive.Location = new Point(481, 596);
            btnInactive.Name = "btnInactive";
            btnInactive.Size = new Size(288, 43);
            btnInactive.TabIndex = 28;
            btnInactive.Text = "Inactive Over a Year";
            btnInactive.UseVisualStyleBackColor = false;
            btnInactive.Click += btnInactive_Click;
            // 
            // txtCIDDel
            // 
            txtCIDDel.Location = new Point(972, 330);
            txtCIDDel.Name = "txtCIDDel";
            txtCIDDel.Size = new Size(270, 37);
            txtCIDDel.TabIndex = 27;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.White;
            label21.Location = new Point(781, 337);
            label21.Name = "label21";
            label21.Size = new Size(160, 30);
            label21.TabIndex = 26;
            label21.Text = "Customer ID";
            // 
            // txtCName
            // 
            txtCName.Location = new Point(972, 383);
            txtCName.Name = "txtCName";
            txtCName.Size = new Size(270, 37);
            txtCName.TabIndex = 25;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.White;
            label20.Location = new Point(781, 383);
            label20.Name = "label20";
            label20.Size = new Size(87, 30);
            label20.TabIndex = 24;
            label20.Text = "Name";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(199, 536);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(270, 37);
            dateTimePicker2.TabIndex = 23;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(8, 551);
            label16.Name = "label16";
            label16.Size = new Size(145, 30);
            label16.TabIndex = 22;
            label16.Text = "Expiry Date";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.White;
            label18.Location = new Point(8, 504);
            label18.Name = "label18";
            label18.Size = new Size(108, 30);
            label18.TabIndex = 21;
            label18.Text = "Amount";
            // 
            // txtVAmount
            // 
            txtVAmount.Location = new Point(199, 493);
            txtVAmount.Name = "txtVAmount";
            txtVAmount.Size = new Size(270, 37);
            txtVAmount.TabIndex = 20;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.White;
            label19.Location = new Point(3, 461);
            label19.Name = "label19";
            label19.Size = new Size(190, 30);
            label19.TabIndex = 19;
            label19.Text = "Voucher Code";
            // 
            // txtVCode
            // 
            txtVCode.Location = new Point(199, 450);
            txtVCode.Name = "txtVCode";
            txtVCode.Size = new Size(270, 37);
            txtVCode.TabIndex = 18;
            // 
            // btnAddV
            // 
            btnAddV.BackColor = Color.LightSeaGreen;
            btnAddV.FlatStyle = FlatStyle.Flat;
            btnAddV.ForeColor = Color.White;
            btnAddV.Location = new Point(225, 596);
            btnAddV.Name = "btnAddV";
            btnAddV.Size = new Size(210, 43);
            btnAddV.TabIndex = 17;
            btnAddV.Text = "Add a Voucher";
            btnAddV.UseVisualStyleBackColor = false;
            btnAddV.Click += btnAddV_Click;
            // 
            // btnViewFreqCustomers
            // 
            btnViewFreqCustomers.BackColor = Color.LightSeaGreen;
            btnViewFreqCustomers.FlatStyle = FlatStyle.Flat;
            btnViewFreqCustomers.ForeColor = Color.White;
            btnViewFreqCustomers.Location = new Point(8, 331);
            btnViewFreqCustomers.Name = "btnViewFreqCustomers";
            btnViewFreqCustomers.Size = new Size(405, 43);
            btnViewFreqCustomers.TabIndex = 16;
            btnViewFreqCustomers.Text = "Most Frequent Customers";
            btnViewFreqCustomers.UseVisualStyleBackColor = false;
            btnViewFreqCustomers.Click += btnViewFreqCustomers_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSeaGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(813, 605);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(-4, 0);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 62;
            dgvCustomers.Size = new Size(1254, 318);
            dgvCustomers.TabIndex = 14;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // txtCAddress
            // 
            txtCAddress.Location = new Point(972, 556);
            txtCAddress.Name = "txtCAddress";
            txtCAddress.Size = new Size(270, 37);
            txtCAddress.TabIndex = 13;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(781, 556);
            label17.Name = "label17";
            label17.Size = new Size(105, 30);
            label17.TabIndex = 12;
            label17.Text = "Address";
            // 
            // txtCPhone
            // 
            txtCPhone.Location = new Point(972, 513);
            txtCPhone.Name = "txtCPhone";
            txtCPhone.Size = new Size(270, 37);
            txtCPhone.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(781, 513);
            label15.Name = "label15";
            label15.Size = new Size(89, 30);
            label15.TabIndex = 8;
            label15.Text = "Phone";
            // 
            // txtCPass
            // 
            txtCPass.Location = new Point(972, 469);
            txtCPass.Name = "txtCPass";
            txtCPass.Size = new Size(270, 37);
            txtCPass.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(781, 473);
            label14.Name = "label14";
            label14.Size = new Size(122, 30);
            label14.TabIndex = 6;
            label14.Text = "Password";
            // 
            // txtCEmail
            // 
            txtCEmail.Location = new Point(972, 426);
            txtCEmail.Name = "txtCEmail";
            txtCEmail.Size = new Size(270, 37);
            txtCEmail.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(781, 430);
            label13.Name = "label13";
            label13.Size = new Size(78, 30);
            label13.TabIndex = 4;
            label13.Text = "Email";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightSeaGreen;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1125, 605);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSeaGreen;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(962, 605);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(199, 407);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(270, 37);
            txtCustomerID.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(6, 414);
            label12.Name = "label12";
            label12.Size = new Size(160, 30);
            label12.TabIndex = 0;
            label12.Text = "Customer ID";
            // 
            // tabPageCategories
            // 
            tabPageCategories.BackColor = Color.LightSeaGreen;
            tabPageCategories.Controls.Add(label35);
            tabPageCategories.Controls.Add(txtCategoryID);
            tabPageCategories.Controls.Add(TxtCategoryDescription);
            tabPageCategories.Controls.Add(lblDesc);
            tabPageCategories.Controls.Add(txtCategoryName);
            tabPageCategories.Controls.Add(lblName);
            tabPageCategories.Controls.Add(btnDeleteC);
            tabPageCategories.Controls.Add(btnUpdateC);
            tabPageCategories.Controls.Add(btnAddC);
            tabPageCategories.Controls.Add(label31);
            tabPageCategories.Controls.Add(dgvCategory);
            tabPageCategories.Location = new Point(4, 34);
            tabPageCategories.Name = "tabPageCategories";
            tabPageCategories.Padding = new Padding(3);
            tabPageCategories.Size = new Size(1250, 676);
            tabPageCategories.TabIndex = 5;
            tabPageCategories.Text = "Categories";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.ForeColor = Color.White;
            label35.Location = new Point(80, 406);
            label35.Margin = new Padding(2, 0, 2, 0);
            label35.Name = "label35";
            label35.Size = new Size(36, 28);
            label35.TabIndex = 22;
            label35.Text = "ID";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(147, 406);
            txtCategoryID.Margin = new Padding(2);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(226, 37);
            txtCategoryID.TabIndex = 21;
            // 
            // TxtCategoryDescription
            // 
            TxtCategoryDescription.Location = new Point(189, 152);
            TxtCategoryDescription.Margin = new Padding(2);
            TxtCategoryDescription.Name = "TxtCategoryDescription";
            TxtCategoryDescription.Size = new Size(226, 37);
            TxtCategoryDescription.TabIndex = 20;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesc.ForeColor = Color.White;
            lblDesc.Location = new Point(20, 161);
            lblDesc.Margin = new Padding(2, 0, 2, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(142, 28);
            lblDesc.TabIndex = 19;
            lblDesc.Text = "Description";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(189, 85);
            txtCategoryName.Margin = new Padding(2);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(226, 37);
            txtCategoryName.TabIndex = 18;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(67, 90);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 28);
            lblName.TabIndex = 17;
            lblName.Text = "Name";
            // 
            // btnDeleteC
            // 
            btnDeleteC.BackColor = Color.White;
            btnDeleteC.FlatAppearance.BorderSize = 0;
            btnDeleteC.FlatStyle = FlatStyle.Flat;
            btnDeleteC.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteC.ForeColor = Color.LightSeaGreen;
            btnDeleteC.Location = new Point(178, 486);
            btnDeleteC.Margin = new Padding(2);
            btnDeleteC.Name = "btnDeleteC";
            btnDeleteC.Size = new Size(112, 40);
            btnDeleteC.TabIndex = 16;
            btnDeleteC.Text = "Delete";
            btnDeleteC.UseVisualStyleBackColor = false;
            btnDeleteC.Click += btnDeleteC_Click;
            // 
            // btnUpdateC
            // 
            btnUpdateC.BackColor = Color.White;
            btnUpdateC.FlatAppearance.BorderSize = 0;
            btnUpdateC.FlatStyle = FlatStyle.Flat;
            btnUpdateC.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateC.ForeColor = Color.LightSeaGreen;
            btnUpdateC.Location = new Point(261, 232);
            btnUpdateC.Margin = new Padding(2);
            btnUpdateC.Name = "btnUpdateC";
            btnUpdateC.Size = new Size(112, 40);
            btnUpdateC.TabIndex = 15;
            btnUpdateC.Text = "Update";
            btnUpdateC.UseVisualStyleBackColor = false;
            btnUpdateC.Click += btnUpdateC_Click;
            // 
            // btnAddC
            // 
            btnAddC.BackColor = Color.White;
            btnAddC.FlatAppearance.BorderSize = 0;
            btnAddC.FlatStyle = FlatStyle.Flat;
            btnAddC.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddC.ForeColor = Color.LightSeaGreen;
            btnAddC.Location = new Point(115, 232);
            btnAddC.Margin = new Padding(2);
            btnAddC.Name = "btnAddC";
            btnAddC.Size = new Size(112, 40);
            btnAddC.TabIndex = 14;
            btnAddC.Text = "Add";
            btnAddC.UseVisualStyleBackColor = false;
            btnAddC.Click += btnAddC_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.White;
            label31.Location = new Point(483, 3);
            label31.Name = "label31";
            label31.Size = new Size(326, 38);
            label31.TabIndex = 1;
            label31.Text = "Manage Categories";
            // 
            // dgvCategory
            // 
            dgvCategory.BackgroundColor = Color.White;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(438, 61);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 62;
            dgvCategory.Size = new Size(804, 554);
            dgvCategory.TabIndex = 0;
            dgvCategory.CellContentClick += dgvCategory_CellContentClick;
            // 
            // tabPageProducts
            // 
            tabPageProducts.BackColor = Color.LightSeaGreen;
            tabPageProducts.Controls.Add(btnGenerateReport);
            tabPageProducts.Controls.Add(btnProductPerCustomer);
            tabPageProducts.Controls.Add(btnNotBought);
            tabPageProducts.Controls.Add(btnMostBought);
            tabPageProducts.Controls.Add(btnShowAllProducts);
            tabPageProducts.Controls.Add(btnShowLowStock);
            tabPageProducts.Controls.Add(btnReset);
            tabPageProducts.Controls.Add(label29);
            tabPageProducts.Controls.Add(txtPID);
            tabPageProducts.Controls.Add(txtPSearch);
            tabPageProducts.Controls.Add(btnSearchProduct);
            tabPageProducts.Controls.Add(btnRestock);
            tabPageProducts.Controls.Add(btnDeleteProduct);
            tabPageProducts.Controls.Add(btnEditProduct);
            tabPageProducts.Controls.Add(btnAddProduct);
            tabPageProducts.Controls.Add(txtPsupplier);
            tabPageProducts.Controls.Add(label26);
            tabPageProducts.Controls.Add(label27);
            tabPageProducts.Controls.Add(label28);
            tabPageProducts.Controls.Add(txtPcategory);
            tabPageProducts.Controls.Add(txtPminThres);
            tabPageProducts.Controls.Add(txtPquantity);
            tabPageProducts.Controls.Add(label25);
            tabPageProducts.Controls.Add(label24);
            tabPageProducts.Controls.Add(label23);
            tabPageProducts.Controls.Add(label22);
            tabPageProducts.Controls.Add(txtPprice);
            tabPageProducts.Controls.Add(txtPdesc);
            tabPageProducts.Controls.Add(txtPname);
            tabPageProducts.Controls.Add(dgvProducts);
            tabPageProducts.Location = new Point(4, 39);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(3);
            tabPageProducts.Size = new Size(1250, 671);
            tabPageProducts.TabIndex = 1;
            tabPageProducts.Text = "Products";
            // 
            // btnProductPerCustomer
            // 
            btnProductPerCustomer.BackColor = Color.LightSeaGreen;
            btnProductPerCustomer.CausesValidation = false;
            btnProductPerCustomer.ForeColor = Color.White;
            btnProductPerCustomer.Location = new Point(633, 535);
            btnProductPerCustomer.Name = "btnProductPerCustomer";
            btnProductPerCustomer.Size = new Size(290, 46);
            btnProductPerCustomer.TabIndex = 28;
            btnProductPerCustomer.Text = "Products Per Customer";
            btnProductPerCustomer.UseVisualStyleBackColor = false;
            btnProductPerCustomer.Click += btnProductPerCustomer_Click;
            // 
            // btnNotBought
            // 
            btnNotBought.BackColor = Color.LightSeaGreen;
            btnNotBought.CausesValidation = false;
            btnNotBought.ForeColor = Color.White;
            btnNotBought.Location = new Point(929, 535);
            btnNotBought.Name = "btnNotBought";
            btnNotBought.Size = new Size(290, 46);
            btnNotBought.TabIndex = 27;
            btnNotBought.Text = "Not Bought This Month";
            btnNotBought.UseVisualStyleBackColor = false;
            btnNotBought.Click += btnNotBought_Click;
            // 
            // btnMostBought
            // 
            btnMostBought.BackColor = Color.LightSeaGreen;
            btnMostBought.CausesValidation = false;
            btnMostBought.ForeColor = Color.White;
            btnMostBought.Location = new Point(929, 483);
            btnMostBought.Name = "btnMostBought";
            btnMostBought.Size = new Size(290, 46);
            btnMostBought.TabIndex = 26;
            btnMostBought.Text = "Most Bought";
            btnMostBought.UseVisualStyleBackColor = false;
            btnMostBought.Click += btnMostBought_Click;
            // 
            // btnShowAllProducts
            // 
            btnShowAllProducts.BackColor = Color.LightSeaGreen;
            btnShowAllProducts.CausesValidation = false;
            btnShowAllProducts.ForeColor = Color.White;
            btnShowAllProducts.Location = new Point(633, 587);
            btnShowAllProducts.Name = "btnShowAllProducts";
            btnShowAllProducts.Size = new Size(290, 46);
            btnShowAllProducts.TabIndex = 25;
            btnShowAllProducts.Text = "Show All Products";
            btnShowAllProducts.UseVisualStyleBackColor = false;
            btnShowAllProducts.Click += btnShowAllProducts_Click;
            // 
            // btnShowLowStock
            // 
            btnShowLowStock.BackColor = Color.LightSeaGreen;
            btnShowLowStock.CausesValidation = false;
            btnShowLowStock.ForeColor = Color.White;
            btnShowLowStock.Location = new Point(929, 587);
            btnShowLowStock.Name = "btnShowLowStock";
            btnShowLowStock.Size = new Size(290, 46);
            btnShowLowStock.TabIndex = 24;
            btnShowLowStock.Text = "Low Stock Products";
            btnShowLowStock.UseVisualStyleBackColor = false;
            btnShowLowStock.Click += btnShowLowStock_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LightSeaGreen;
            btnReset.CausesValidation = false;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(1138, 337);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(97, 38);
            btnReset.TabIndex = 23;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.ForeColor = Color.White;
            label29.Location = new Point(10, 603);
            label29.Name = "label29";
            label29.Size = new Size(136, 30);
            label29.TabIndex = 22;
            label29.Text = "Product ID";
            // 
            // txtPID
            // 
            txtPID.Location = new Point(200, 596);
            txtPID.Name = "txtPID";
            txtPID.Size = new Size(235, 37);
            txtPID.TabIndex = 21;
            // 
            // txtPSearch
            // 
            txtPSearch.Location = new Point(919, 287);
            txtPSearch.Name = "txtPSearch";
            txtPSearch.Size = new Size(310, 37);
            txtPSearch.TabIndex = 20;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.LightSeaGreen;
            btnSearchProduct.CausesValidation = false;
            btnSearchProduct.ForeColor = Color.White;
            btnSearchProduct.Location = new Point(790, 286);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(123, 38);
            btnSearchProduct.TabIndex = 19;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = false;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // btnRestock
            // 
            btnRestock.BackColor = Color.LightSeaGreen;
            btnRestock.CausesValidation = false;
            btnRestock.ForeColor = Color.White;
            btnRestock.Location = new Point(461, 535);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(128, 46);
            btnRestock.TabIndex = 18;
            btnRestock.Text = "Restock";
            btnRestock.UseVisualStyleBackColor = false;
            btnRestock.Click += btnRestock_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.LightSeaGreen;
            btnDeleteProduct.CausesValidation = false;
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(461, 587);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(128, 46);
            btnDeleteProduct.TabIndex = 17;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = Color.LightSeaGreen;
            btnEditProduct.CausesValidation = false;
            btnEditProduct.ForeColor = Color.White;
            btnEditProduct.Location = new Point(461, 343);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(128, 46);
            btnEditProduct.TabIndex = 16;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.LightSeaGreen;
            btnAddProduct.CausesValidation = false;
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(461, 291);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(128, 46);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtPsupplier
            // 
            txtPsupplier.Location = new Point(200, 508);
            txtPsupplier.Name = "txtPsupplier";
            txtPsupplier.Size = new Size(235, 37);
            txtPsupplier.TabIndex = 14;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.ForeColor = Color.White;
            label26.Location = new Point(8, 511);
            label26.Name = "label26";
            label26.Size = new Size(138, 30);
            label26.TabIndex = 13;
            label26.Text = "Supplier ID";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = Color.White;
            label27.Location = new Point(8, 466);
            label27.Name = "label27";
            label27.Size = new Size(156, 30);
            label27.TabIndex = 12;
            label27.Text = "Category ID";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = Color.White;
            label28.Location = new Point(8, 423);
            label28.Name = "label28";
            label28.Size = new Size(176, 30);
            label28.TabIndex = 11;
            label28.Text = "Min Threshold";
            // 
            // txtPcategory
            // 
            txtPcategory.Location = new Point(200, 463);
            txtPcategory.Name = "txtPcategory";
            txtPcategory.Size = new Size(235, 37);
            txtPcategory.TabIndex = 10;
            // 
            // txtPminThres
            // 
            txtPminThres.Location = new Point(200, 420);
            txtPminThres.Name = "txtPminThres";
            txtPminThres.Size = new Size(235, 37);
            txtPminThres.TabIndex = 9;
            // 
            // txtPquantity
            // 
            txtPquantity.Location = new Point(200, 551);
            txtPquantity.Name = "txtPquantity";
            txtPquantity.Size = new Size(235, 37);
            txtPquantity.TabIndex = 8;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.White;
            label25.Location = new Point(8, 555);
            label25.Name = "label25";
            label25.Size = new Size(115, 30);
            label25.TabIndex = 7;
            label25.Text = "Quantity";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.White;
            label24.Location = new Point(8, 380);
            label24.Name = "label24";
            label24.Size = new Size(72, 30);
            label24.TabIndex = 6;
            label24.Text = "Price";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.White;
            label23.Location = new Point(8, 337);
            label23.Name = "label23";
            label23.Size = new Size(147, 30);
            label23.TabIndex = 5;
            label23.Text = "Description";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.White;
            label22.Location = new Point(8, 294);
            label22.Name = "label22";
            label22.Size = new Size(186, 30);
            label22.TabIndex = 4;
            label22.Text = "Product Name";
            // 
            // txtPprice
            // 
            txtPprice.Location = new Point(200, 377);
            txtPprice.Name = "txtPprice";
            txtPprice.Size = new Size(235, 37);
            txtPprice.TabIndex = 3;
            // 
            // txtPdesc
            // 
            txtPdesc.Location = new Point(200, 334);
            txtPdesc.Name = "txtPdesc";
            txtPdesc.Size = new Size(235, 37);
            txtPdesc.TabIndex = 2;
            // 
            // txtPname
            // 
            txtPname.Location = new Point(200, 291);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(235, 37);
            txtPname.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(1, 2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(1234, 264);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // tabPageSuppliers
            // 
            tabPageSuppliers.BackColor = Color.LightSeaGreen;
            tabPageSuppliers.Controls.Add(txtSupplierAddress);
            tabPageSuppliers.Controls.Add(label37);
            tabPageSuppliers.Controls.Add(label36);
            tabPageSuppliers.Controls.Add(txtSupplierID);
            tabPageSuppliers.Controls.Add(txtSupplierPhone);
            tabPageSuppliers.Controls.Add(label32);
            tabPageSuppliers.Controls.Add(txtSupplierName);
            tabPageSuppliers.Controls.Add(label33);
            tabPageSuppliers.Controls.Add(btnDeleteS);
            tabPageSuppliers.Controls.Add(btnUpdateS);
            tabPageSuppliers.Controls.Add(btnAddS);
            tabPageSuppliers.Controls.Add(label34);
            tabPageSuppliers.Controls.Add(dvgSuppliers);
            tabPageSuppliers.Location = new Point(4, 34);
            tabPageSuppliers.Name = "tabPageSuppliers";
            tabPageSuppliers.Padding = new Padding(3);
            tabPageSuppliers.Size = new Size(1250, 676);
            tabPageSuppliers.TabIndex = 6;
            tabPageSuppliers.Text = "Suppliers";
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(153, 140);
            txtSupplierAddress.Margin = new Padding(2);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(226, 37);
            txtSupplierAddress.TabIndex = 33;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.ForeColor = Color.White;
            label37.Location = new Point(31, 145);
            label37.Margin = new Padding(2, 0, 2, 0);
            label37.Name = "label37";
            label37.Size = new Size(107, 28);
            label37.TabIndex = 32;
            label37.Text = "Address";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.ForeColor = Color.White;
            label36.Location = new Point(27, 413);
            label36.Margin = new Padding(2, 0, 2, 0);
            label36.Name = "label36";
            label36.Size = new Size(36, 28);
            label36.TabIndex = 31;
            label36.Text = "ID";
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new Point(92, 408);
            txtSupplierID.Margin = new Padding(2);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(226, 37);
            txtSupplierID.TabIndex = 30;
            // 
            // txtSupplierPhone
            // 
            txtSupplierPhone.Location = new Point(153, 201);
            txtSupplierPhone.Margin = new Padding(2);
            txtSupplierPhone.Name = "txtSupplierPhone";
            txtSupplierPhone.Size = new Size(226, 37);
            txtSupplierPhone.TabIndex = 29;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.ForeColor = Color.White;
            label32.Location = new Point(46, 201);
            label32.Margin = new Padding(2, 0, 2, 0);
            label32.Name = "label32";
            label32.Size = new Size(83, 28);
            label32.TabIndex = 28;
            label32.Text = "Phone";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(153, 83);
            txtSupplierName.Margin = new Padding(2);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(226, 37);
            txtSupplierName.TabIndex = 27;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.ForeColor = Color.White;
            label33.Location = new Point(45, 83);
            label33.Margin = new Padding(2, 0, 2, 0);
            label33.Name = "label33";
            label33.Size = new Size(84, 28);
            label33.TabIndex = 26;
            label33.Text = "Name";
            label33.Click += label33_Click;
            // 
            // btnDeleteS
            // 
            btnDeleteS.BackColor = Color.White;
            btnDeleteS.FlatAppearance.BorderSize = 0;
            btnDeleteS.FlatStyle = FlatStyle.Flat;
            btnDeleteS.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteS.ForeColor = Color.LightSeaGreen;
            btnDeleteS.Location = new Point(131, 486);
            btnDeleteS.Margin = new Padding(2);
            btnDeleteS.Name = "btnDeleteS";
            btnDeleteS.Size = new Size(112, 40);
            btnDeleteS.TabIndex = 25;
            btnDeleteS.Text = "Delete";
            btnDeleteS.UseVisualStyleBackColor = false;
            btnDeleteS.Click += btnDeleteS_Click;
            // 
            // btnUpdateS
            // 
            btnUpdateS.BackColor = Color.White;
            btnUpdateS.FlatAppearance.BorderSize = 0;
            btnUpdateS.FlatStyle = FlatStyle.Flat;
            btnUpdateS.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateS.ForeColor = Color.LightSeaGreen;
            btnUpdateS.Location = new Point(215, 292);
            btnUpdateS.Margin = new Padding(2);
            btnUpdateS.Name = "btnUpdateS";
            btnUpdateS.Size = new Size(112, 40);
            btnUpdateS.TabIndex = 24;
            btnUpdateS.Text = "Update";
            btnUpdateS.UseVisualStyleBackColor = false;
            btnUpdateS.Click += btnUpdateS_Click;
            // 
            // btnAddS
            // 
            btnAddS.BackColor = Color.White;
            btnAddS.FlatAppearance.BorderSize = 0;
            btnAddS.FlatStyle = FlatStyle.Flat;
            btnAddS.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddS.ForeColor = Color.LightSeaGreen;
            btnAddS.Location = new Point(65, 292);
            btnAddS.Margin = new Padding(2);
            btnAddS.Name = "btnAddS";
            btnAddS.Size = new Size(112, 40);
            btnAddS.TabIndex = 23;
            btnAddS.Text = "Add";
            btnAddS.UseVisualStyleBackColor = false;
            btnAddS.Click += btnAddS_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.ForeColor = Color.White;
            label34.Location = new Point(482, 3);
            label34.Name = "label34";
            label34.Size = new Size(295, 38);
            label34.TabIndex = 22;
            label34.Text = "Manage Suppliers";
            // 
            // dvgSuppliers
            // 
            dvgSuppliers.BackgroundColor = Color.White;
            dvgSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgSuppliers.Location = new Point(398, 66);
            dvgSuppliers.Name = "dvgSuppliers";
            dvgSuppliers.RowHeadersWidth = 62;
            dvgSuppliers.Size = new Size(837, 560);
            dvgSuppliers.TabIndex = 21;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightSeaGreen;
            tabPage3.Controls.Add(label30);
            tabPage3.Controls.Add(dataGridViewOrders);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1250, 676);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Orders";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Century Gothic", 20F);
            label30.ForeColor = Color.White;
            label30.Location = new Point(461, 26);
            label30.Name = "label30";
            label30.Size = new Size(262, 49);
            label30.TabIndex = 1;
            label30.Text = "Track Orders";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.BackgroundColor = Color.White;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(51, 105);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 62;
            dataGridViewOrders.Size = new Size(1142, 533);
            dataGridViewOrders.TabIndex = 0;
            // 
            // tabPagefreqCustomers
            // 
            tabPagefreqCustomers.BackColor = Color.White;
            tabPagefreqCustomers.Controls.Add(label11);
            tabPagefreqCustomers.Controls.Add(dateTimePicker1);
            tabPagefreqCustomers.Controls.Add(label10);
            tabPagefreqCustomers.Controls.Add(label9);
            tabPagefreqCustomers.Controls.Add(txtAmount);
            tabPagefreqCustomers.Controls.Add(label8);
            tabPagefreqCustomers.Controls.Add(txtCode);
            tabPagefreqCustomers.Controls.Add(label7);
            tabPagefreqCustomers.Controls.Add(txtCID);
            tabPagefreqCustomers.Controls.Add(btnAddVoucher);
            tabPagefreqCustomers.Controls.Add(dgvFreqCustomers);
            tabPagefreqCustomers.ForeColor = Color.Cornsilk;
            tabPagefreqCustomers.Location = new Point(4, 34);
            tabPagefreqCustomers.Name = "tabPagefreqCustomers";
            tabPagefreqCustomers.Padding = new Padding(3);
            tabPagefreqCustomers.Size = new Size(1250, 676);
            tabPagefreqCustomers.TabIndex = 3;
            tabPagefreqCustomers.Text = "Frequent Customers";
            tabPagefreqCustomers.Click += tabPagefreqCustomers_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.LightSeaGreen;
            label11.Location = new Point(92, 31);
            label11.Name = "label11";
            label11.Size = new Size(194, 30);
            label11.TabIndex = 11;
            label11.Text = "Add a Voucher";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(186, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 37);
            dateTimePicker1.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.LightSeaGreen;
            label10.Location = new Point(3, 210);
            label10.Name = "label10";
            label10.Size = new Size(145, 30);
            label10.TabIndex = 9;
            label10.Text = "Expiry Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.LightSeaGreen;
            label9.Location = new Point(3, 167);
            label9.Name = "label9";
            label9.Size = new Size(108, 30);
            label9.TabIndex = 7;
            label9.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(186, 167);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(261, 37);
            txtAmount.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.LightSeaGreen;
            label8.Location = new Point(3, 124);
            label8.Name = "label8";
            label8.Size = new Size(190, 30);
            label8.TabIndex = 5;
            label8.Text = "Voucher Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(186, 124);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(261, 37);
            txtCode.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(3, 81);
            label7.Name = "label7";
            label7.Size = new Size(160, 30);
            label7.TabIndex = 3;
            label7.Text = "Customer ID";
            // 
            // txtCID
            // 
            txtCID.Location = new Point(186, 74);
            txtCID.Name = "txtCID";
            txtCID.Size = new Size(261, 37);
            txtCID.TabIndex = 2;
            // 
            // btnAddVoucher
            // 
            btnAddVoucher.BackColor = Color.LightSeaGreen;
            btnAddVoucher.FlatAppearance.BorderSize = 0;
            btnAddVoucher.FlatStyle = FlatStyle.Flat;
            btnAddVoucher.ForeColor = Color.White;
            btnAddVoucher.Location = new Point(82, 273);
            btnAddVoucher.Name = "btnAddVoucher";
            btnAddVoucher.Size = new Size(193, 57);
            btnAddVoucher.TabIndex = 1;
            btnAddVoucher.Text = "Add Voucher";
            btnAddVoucher.UseVisualStyleBackColor = false;
            btnAddVoucher.Click += btnAddVoucher_Click;
            // 
            // dgvFreqCustomers
            // 
            dgvFreqCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFreqCustomers.Location = new Point(453, 31);
            dgvFreqCustomers.Name = "dgvFreqCustomers";
            dgvFreqCustomers.RowHeadersWidth = 62;
            dgvFreqCustomers.Size = new Size(797, 494);
            dgvFreqCustomers.TabIndex = 0;
            dgvFreqCustomers.CellContentClick += dgvFreqCustomers_CellContentClick;
            // 
            // tabPageaddcustomer
            // 
            tabPageaddcustomer.BackColor = Color.LightSeaGreen;
            tabPageaddcustomer.Controls.Add(btnSave);
            tabPageaddcustomer.Controls.Add(textBox5Address);
            tabPageaddcustomer.Controls.Add(textBox4Phone);
            tabPageaddcustomer.Controls.Add(textBox3Pass);
            tabPageaddcustomer.Controls.Add(textBox2Email);
            tabPageaddcustomer.Controls.Add(textBoxName);
            tabPageaddcustomer.Controls.Add(label6);
            tabPageaddcustomer.Controls.Add(label5);
            tabPageaddcustomer.Controls.Add(label4);
            tabPageaddcustomer.Controls.Add(label3);
            tabPageaddcustomer.Controls.Add(label2);
            tabPageaddcustomer.Controls.Add(label1);
            tabPageaddcustomer.ForeColor = Color.LightSlateGray;
            tabPageaddcustomer.Location = new Point(4, 34);
            tabPageaddcustomer.Name = "tabPageaddcustomer";
            tabPageaddcustomer.Padding = new Padding(3);
            tabPageaddcustomer.Size = new Size(1250, 676);
            tabPageaddcustomer.TabIndex = 0;
            tabPageaddcustomer.Text = "Add Customer";
            tabPageaddcustomer.Click += tabPage1_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(631, 425);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 44);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textBox5Address
            // 
            textBox5Address.Location = new Point(548, 357);
            textBox5Address.Name = "textBox5Address";
            textBox5Address.Size = new Size(302, 37);
            textBox5Address.TabIndex = 11;
            // 
            // textBox4Phone
            // 
            textBox4Phone.Location = new Point(548, 310);
            textBox4Phone.Name = "textBox4Phone";
            textBox4Phone.Size = new Size(302, 37);
            textBox4Phone.TabIndex = 10;
            // 
            // textBox3Pass
            // 
            textBox3Pass.Location = new Point(548, 266);
            textBox3Pass.Name = "textBox3Pass";
            textBox3Pass.Size = new Size(302, 37);
            textBox3Pass.TabIndex = 9;
            // 
            // textBox2Email
            // 
            textBox2Email.Location = new Point(548, 218);
            textBox2Email.Name = "textBox2Email";
            textBox2Email.Size = new Size(302, 37);
            textBox2Email.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(548, 169);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(302, 37);
            textBoxName.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(410, 357);
            label6.Name = "label6";
            label6.Size = new Size(105, 30);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(410, 310);
            label5.Name = "label5";
            label5.Size = new Size(89, 30);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(410, 266);
            label4.Name = "label4";
            label4.Size = new Size(122, 30);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(410, 218);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(410, 172);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(448, 76);
            label1.Name = "label1";
            label1.Size = new Size(355, 39);
            label1.TabIndex = 0;
            label1.Text = "Add a New Customer";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.LightSeaGreen;
            btnGenerateReport.CausesValidation = false;
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(633, 483);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(290, 46);
            btnGenerateReport.TabIndex = 29;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1258, 712);
            Controls.Add(tabPageOrders);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            tabPageOrders.ResumeLayout(false);
            tabPageCustomers.ResumeLayout(false);
            tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            tabPageCategories.ResumeLayout(false);
            tabPageCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            tabPageProducts.ResumeLayout(false);
            tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            tabPageSuppliers.ResumeLayout(false);
            tabPageSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgSuppliers).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            tabPagefreqCustomers.ResumeLayout(false);
            tabPagefreqCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFreqCustomers).EndInit();
            tabPageaddcustomer.ResumeLayout(false);
            tabPageaddcustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPageOrders;
        private TabPage tabPageaddcustomer;
        private TabPage tabPageProducts;
        private TabPage tabPage3;
        private TextBox textBox5Address;
        private TextBox textBox4Phone;
        private TextBox textBox3Pass;
        private TextBox textBox2Email;
        private TextBox textBoxName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private DataGridView dataGridViewOrders;
        private TabPage tabPagefreqCustomers;
        private DataGridView dgvFreqCustomers;
        private Button btnAddVoucher;
        private Label label7;
        private TextBox txtCID;
        private Label label9;
        private TextBox txtAmount;
        private Label label8;
        private TextBox txtCode;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private TabPage tabPageCustomers;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtCustomerID;
        private Label label12;
        private TextBox txtCPhone;
        private Label label15;
        private TextBox txtCPass;
        private Label label14;
        private TextBox txtCEmail;
        private Label label13;
        private Button btnAdd;
        private DataGridView dgvCustomers;
        private TextBox txtCAddress;
        private Label label17;
        private TextBox txtCName;
        private Label label20;
        private DateTimePicker dateTimePicker2;
        private Label label16;
        private Label label18;
        private TextBox txtVAmount;
        private Label label19;
        private TextBox txtVCode;
        private Button btnAddV;
        private Button btnViewFreqCustomers;
        private TextBox txtCIDDel;
        private Label label21;
        private Label label26;
        private Label label27;
        private Label label28;
        private TextBox txtPcategory;
        private TextBox txtPminThres;
        private TextBox txtPquantity;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private TextBox txtPprice;
        private TextBox txtPdesc;
        private TextBox txtPname;
        private DataGridView dgvProducts;
        private TextBox txtPSearch;
        private Button btnSearchProduct;
        private Button btnRestock;
        private Button btnDeleteProduct;
        private Button btnEditProduct;
        private Button btnAddProduct;
        private TextBox txtPsupplier;
        private Label label29;
        private TextBox txtPID;
        private Button btnReset;
        private Button btnShowLowStock;
        private Button btnShowAllProducts;
        private Button btnMostBought;
        private Button btnNotBought;
        private Button btnInactive;
        private Button btnResetCutomers;
        private Button button1;
        private Button btnProductPerCustomer;
        private Label label30;
        private TabPage tabPageCategories;
        private TabPage tabPageSuppliers;
        private Label label31;
        private DataGridView dgvCategory;
        private Button btnDeleteC;
        private Button btnUpdateC;
        private Button btnAddC;
        private TextBox TxtCategoryDescription;
        private Label lblDesc;
        private TextBox txtCategoryName;
        private Label lblName;
        private TextBox txtSupplierPhone;
        private Label label32;
        private TextBox txtSupplierName;
        private Label label33;
        private Button btnDeleteS;
        private Button btnUpdateS;
        private Button btnAddS;
        private Label label34;
        private DataGridView dvgSuppliers;
        private Label label35;
        private TextBox txtCategoryID;
        private Label label36;
        private TextBox txtSupplierID;
        private TextBox txtSupplierAddress;
        private Label label37;
        private Button btnGenerateReport;
    }
}