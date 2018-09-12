namespace WindowsFormsApp1
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cashierRB = new System.Windows.Forms.RadioButton();
            this.barberRB = new System.Windows.Forms.RadioButton();
            this.adminRB = new System.Windows.Forms.RadioButton();
            this.password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.con_num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.branchCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updEmp = new System.Windows.Forms.Button();
            this.addEmp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.empTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cashier = new System.Windows.Forms.DataGridView();
            this.backlabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.empTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cashierRB);
            this.panel1.Controls.Add(this.barberRB);
            this.panel1.Controls.Add(this.adminRB);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.birthday);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.con_num);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.branchCombo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.mname);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 206);
            this.panel1.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(457, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 27);
            this.label9.TabIndex = 72;
            this.label9.Text = "Position";
            // 
            // cashierRB
            // 
            this.cashierRB.AutoSize = true;
            this.cashierRB.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierRB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cashierRB.Location = new System.Drawing.Point(785, 98);
            this.cashierRB.Name = "cashierRB";
            this.cashierRB.Size = new System.Drawing.Size(64, 17);
            this.cashierRB.TabIndex = 71;
            this.cashierRB.TabStop = true;
            this.cashierRB.Text = "Cashier";
            this.cashierRB.UseVisualStyleBackColor = true;
            this.cashierRB.CheckedChanged += new System.EventHandler(this.cashierRB_CheckedChanged);
            // 
            // barberRB
            // 
            this.barberRB.AutoSize = true;
            this.barberRB.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barberRB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.barberRB.Location = new System.Drawing.Point(707, 98);
            this.barberRB.Name = "barberRB";
            this.barberRB.Size = new System.Drawing.Size(60, 17);
            this.barberRB.TabIndex = 70;
            this.barberRB.TabStop = true;
            this.barberRB.Text = "Barber";
            this.barberRB.UseVisualStyleBackColor = true;
            this.barberRB.CheckedChanged += new System.EventHandler(this.barberRB_CheckedChanged);
            // 
            // adminRB
            // 
            this.adminRB.AutoSize = true;
            this.adminRB.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminRB.Location = new System.Drawing.Point(628, 98);
            this.adminRB.Name = "adminRB";
            this.adminRB.Size = new System.Drawing.Size(56, 17);
            this.adminRB.TabIndex = 69;
            this.adminRB.TabStop = true;
            this.adminRB.Text = "Admin";
            this.adminRB.UseVisualStyleBackColor = true;
            this.adminRB.CheckedChanged += new System.EventHandler(this.adminRB_CheckedChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(626, 162);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(217, 28);
            this.password.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(457, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 27);
            this.label8.TabIndex = 67;
            this.label8.Text = "Password";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(626, 125);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(217, 28);
            this.username.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(457, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 27);
            this.label7.TabIndex = 65;
            this.label7.Text = "Username";
            // 
            // birthday
            // 
            this.birthday.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Location = new System.Drawing.Point(626, 58);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(217, 24);
            this.birthday.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(457, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 27);
            this.label6.TabIndex = 63;
            this.label6.Text = "Birthday";
            // 
            // con_num
            // 
            this.con_num.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_num.Location = new System.Drawing.Point(626, 17);
            this.con_num.Multiline = true;
            this.con_num.Name = "con_num";
            this.con_num.Size = new System.Drawing.Size(217, 28);
            this.con_num.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(457, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 27);
            this.label5.TabIndex = 61;
            this.label5.Text = "Contact Number";
            // 
            // branchCombo
            // 
            this.branchCombo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchCombo.FormattingEnabled = true;
            this.branchCombo.Location = new System.Drawing.Point(154, 17);
            this.branchCombo.Name = "branchCombo";
            this.branchCombo.Size = new System.Drawing.Size(217, 27);
            this.branchCombo.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 58;
            this.label1.Text = "Branch";
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(154, 126);
            this.lname.Multiline = true;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(217, 28);
            this.lname.TabIndex = 57;
            // 
            // mname
            // 
            this.mname.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mname.Location = new System.Drawing.Point(154, 89);
            this.mname.Multiline = true;
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(217, 28);
            this.mname.TabIndex = 56;
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(154, 53);
            this.fname.Multiline = true;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(217, 28);
            this.fname.TabIndex = 55;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(15, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 54;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 27);
            this.label3.TabIndex = 53;
            this.label3.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 52;
            this.label2.Text = "First Name";
            // 
            // updEmp
            // 
            this.updEmp.BackColor = System.Drawing.Color.Transparent;
            this.updEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updEmp.BackgroundImage")));
            this.updEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.updEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updEmp.Location = new System.Drawing.Point(478, 607);
            this.updEmp.Name = "updEmp";
            this.updEmp.Size = new System.Drawing.Size(124, 72);
            this.updEmp.TabIndex = 73;
            this.updEmp.UseVisualStyleBackColor = false;
            // 
            // addEmp
            // 
            this.addEmp.BackColor = System.Drawing.Color.Transparent;
            this.addEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEmp.BackgroundImage")));
            this.addEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addEmp.Location = new System.Drawing.Point(333, 607);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(127, 72);
            this.addEmp.TabIndex = 60;
            this.addEmp.UseVisualStyleBackColor = false;
            this.addEmp.Click += new System.EventHandler(this.addEmp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.searchtxt);
            this.panel2.Location = new System.Drawing.Point(278, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 59);
            this.panel2.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(344, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 54;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(17, 14);
            this.searchtxt.Multiline = true;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(322, 32);
            this.searchtxt.TabIndex = 53;
            // 
            // empTab
            // 
            this.empTab.Controls.Add(this.tabPage1);
            this.empTab.Controls.Add(this.tabPage2);
            this.empTab.Controls.Add(this.tabPage3);
            this.empTab.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empTab.Location = new System.Drawing.Point(12, 101);
            this.empTab.Name = "empTab";
            this.empTab.SelectedIndex = 0;
            this.empTab.Size = new System.Drawing.Size(912, 283);
            this.empTab.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(904, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Barber";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(901, 257);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cashier);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(904, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cashier";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cashier
            // 
            this.cashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashier.Location = new System.Drawing.Point(0, 3);
            this.cashier.Name = "cashier";
            this.cashier.Size = new System.Drawing.Size(940, 254);
            this.cashier.TabIndex = 0;
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backlabel.Location = new System.Drawing.Point(38, 83);
            this.backlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(32, 14);
            this.backlabel.TabIndex = 62;
            this.backlabel.Text = "back";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.Location = new System.Drawing.Point(13, 11);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 72);
            this.backBtn.TabIndex = 61;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(385, 682);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 14);
            this.label10.TabIndex = 74;
            this.label10.Text = "Add";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(521, 682);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 14);
            this.label11.TabIndex = 75;
            this.label11.Text = "Update";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(856, 89);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 14);
            this.label12.TabIndex = 77;
            this.label12.Text = "PRINT";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(825, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 67);
            this.button2.TabIndex = 76;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 701);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.updEmp);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.empTab);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.empTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox branchCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updEmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton cashierRB;
        private System.Windows.Forms.RadioButton barberRB;
        private System.Windows.Forms.RadioButton adminRB;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox con_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addEmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.TabControl empTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView cashier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
    }
}