namespace WindowsFormsApp1
{
    partial class ClientTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientTransaction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientCombo = new System.Windows.Forms.ComboBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.addLogs = new System.Windows.Forms.Button();
            this.clientBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reservedGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.paidGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.amtTxt = new System.Windows.Forms.TextBox();
            this.clientTxt = new System.Windows.Forms.TextBox();
            this.tIDtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservedGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paidGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.clientCombo);
            this.panel1.Controls.Add(this.clientLabel);
            this.panel1.Controls.Add(this.addLogs);
            this.panel1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 54);
            this.panel1.TabIndex = 1;
            // 
            // clientCombo
            // 
            this.clientCombo.FormattingEnabled = true;
            this.clientCombo.Location = new System.Drawing.Point(86, 18);
            this.clientCombo.Name = "clientCombo";
            this.clientCombo.Size = new System.Drawing.Size(302, 20);
            this.clientCombo.TabIndex = 52;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clientLabel.Location = new System.Drawing.Point(17, 11);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(69, 27);
            this.clientLabel.TabIndex = 51;
            this.clientLabel.Text = "Client";
            // 
            // addLogs
            // 
            this.addLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLogs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addLogs.Location = new System.Drawing.Point(404, 7);
            this.addLogs.Name = "addLogs";
            this.addLogs.Size = new System.Drawing.Size(142, 37);
            this.addLogs.TabIndex = 53;
            this.addLogs.Text = "MAKE TRANSACTION";
            this.addLogs.UseVisualStyleBackColor = false;
            this.addLogs.Click += new System.EventHandler(this.addLogs_Click);
            // 
            // clientBtn
            // 
            this.clientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clientBtn.BackgroundImage")));
            this.clientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.clientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clientBtn.Location = new System.Drawing.Point(482, 11);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(94, 67);
            this.clientBtn.TabIndex = 53;
            this.clientBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clientBtn.UseVisualStyleBackColor = false;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.Location = new System.Drawing.Point(16, 6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 72);
            this.backBtn.TabIndex = 53;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 27);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 235);
            this.tabControl1.TabIndex = 55;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reservedGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reserved";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // reservedGrid
            // 
            this.reservedGrid.AllowUserToAddRows = false;
            this.reservedGrid.AllowUserToDeleteRows = false;
            this.reservedGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservedGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reservedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.reservedGrid.Location = new System.Drawing.Point(0, 2);
            this.reservedGrid.Name = "reservedGrid";
            this.reservedGrid.ReadOnly = true;
            this.reservedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservedGrid.Size = new System.Drawing.Size(560, 209);
            this.reservedGrid.TabIndex = 0;
            this.reservedGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservedGrid_CellClick);
            this.reservedGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservedGrid_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.paidGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Paid";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // paidGrid
            // 
            this.paidGrid.AllowUserToAddRows = false;
            this.paidGrid.AllowUserToDeleteRows = false;
            this.paidGrid.AllowUserToResizeColumns = false;
            this.paidGrid.AllowUserToResizeRows = false;
            this.paidGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paidGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.paidGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paidGrid.Location = new System.Drawing.Point(0, 2);
            this.paidGrid.Name = "paidGrid";
            this.paidGrid.ReadOnly = true;
            this.paidGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paidGrid.Size = new System.Drawing.Size(559, 209);
            this.paidGrid.TabIndex = 0;
            this.paidGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paidGrid_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.viewBtn);
            this.panel2.Controls.Add(this.statusTxt);
            this.panel2.Controls.Add(this.amtTxt);
            this.panel2.Controls.Add(this.clientTxt);
            this.panel2.Controls.Add(this.tIDtxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(13, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 241);
            this.panel2.TabIndex = 56;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(323, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 14);
            this.label6.TabIndex = 60;
            this.label6.Text = "cancel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(226, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 59;
            this.label5.Text = "view";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancelBtn.Location = new System.Drawing.Point(296, 162);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 59);
            this.cancelBtn.TabIndex = 53;
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewBtn.BackgroundImage")));
            this.viewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.viewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.viewBtn.Location = new System.Drawing.Point(194, 162);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(94, 59);
            this.viewBtn.TabIndex = 53;
            this.viewBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // statusTxt
            // 
            this.statusTxt.Font = new System.Drawing.Font("Arial", 15.5F);
            this.statusTxt.Location = new System.Drawing.Point(94, 78);
            this.statusTxt.Multiline = true;
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.ReadOnly = true;
            this.statusTxt.Size = new System.Drawing.Size(197, 28);
            this.statusTxt.TabIndex = 28;
            // 
            // amtTxt
            // 
            this.amtTxt.Font = new System.Drawing.Font("Arial", 15.5F);
            this.amtTxt.Location = new System.Drawing.Point(341, 123);
            this.amtTxt.Multiline = true;
            this.amtTxt.Name = "amtTxt";
            this.amtTxt.ReadOnly = true;
            this.amtTxt.Size = new System.Drawing.Size(197, 28);
            this.amtTxt.TabIndex = 28;
            // 
            // clientTxt
            // 
            this.clientTxt.Font = new System.Drawing.Font("Arial", 15.5F);
            this.clientTxt.Location = new System.Drawing.Point(94, 43);
            this.clientTxt.Multiline = true;
            this.clientTxt.Name = "clientTxt";
            this.clientTxt.ReadOnly = true;
            this.clientTxt.Size = new System.Drawing.Size(197, 28);
            this.clientTxt.TabIndex = 28;
            // 
            // tIDtxt
            // 
            this.tIDtxt.Font = new System.Drawing.Font("Arial", 15.5F);
            this.tIDtxt.Location = new System.Drawing.Point(171, 8);
            this.tIDtxt.Multiline = true;
            this.tIDtxt.Name = "tIDtxt";
            this.tIDtxt.Size = new System.Drawing.Size(31, 29);
            this.tIDtxt.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Client :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Transaction ID :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(383, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 67);
            this.button1.TabIndex = 57;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backlabel.Location = new System.Drawing.Point(41, 79);
            this.backlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(32, 14);
            this.backlabel.TabIndex = 58;
            this.backlabel.Text = "back";
            this.backlabel.Click += new System.EventHandler(this.backlabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(414, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 14);
            this.label7.TabIndex = 59;
            this.label7.Text = "PRINT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(504, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 14);
            this.label8.TabIndex = 60;
            this.label8.Text = "CLIENTS";
            // 
            // ClientTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 681);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.clientBtn);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientTransaction";
            this.Text = "Client Transaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientTransaction_FormClosing);
            this.Load += new System.EventHandler(this.ClientTransaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservedGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paidGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addLogs;
        private System.Windows.Forms.ComboBox clientCombo;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Button clientBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView reservedGrid;
        private System.Windows.Forms.DataGridView paidGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox clientTxt;
        private System.Windows.Forms.TextBox tIDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox statusTxt;
        private System.Windows.Forms.TextBox amtTxt;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}