namespace WindowsFormsApp1
{
    partial class Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.branchID = new System.Windows.Forms.ComboBox();
            this.addService = new System.Windows.Forms.Button();
            this.prc = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.serv_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updService = new System.Windows.Forms.Button();
            this.inactBtn = new System.Windows.Forms.Button();
            this.activeBtn = new System.Windows.Forms.Button();
            this.seridtext = new System.Windows.Forms.TextBox();
            this.backlabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(383, 173);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(616, 104);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(34, 31);
            this.search.TabIndex = 4;
            this.search.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(364, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 31);
            this.textBox1.TabIndex = 3;
            // 
            // branchID
            // 
            this.branchID.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchID.FormattingEnabled = true;
            this.branchID.Location = new System.Drawing.Point(137, 144);
            this.branchID.Name = "branchID";
            this.branchID.Size = new System.Drawing.Size(166, 27);
            this.branchID.TabIndex = 33;
            // 
            // addService
            // 
            this.addService.BackColor = System.Drawing.Color.Transparent;
            this.addService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addService.BackgroundImage")));
            this.addService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addService.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addService.Location = new System.Drawing.Point(30, 323);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(122, 70);
            this.addService.TabIndex = 32;
            this.addService.UseVisualStyleBackColor = false;
            // 
            // prc
            // 
            this.prc.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prc.Location = new System.Drawing.Point(137, 275);
            this.prc.Multiline = true;
            this.prc.Name = "prc";
            this.prc.Size = new System.Drawing.Size(166, 27);
            this.prc.TabIndex = 31;
            // 
            // desc
            // 
            this.desc.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.Location = new System.Drawing.Point(137, 209);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(166, 61);
            this.desc.TabIndex = 30;
            // 
            // serv_name
            // 
            this.serv_name.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serv_name.Location = new System.Drawing.Point(137, 176);
            this.serv_name.Multiline = true;
            this.serv_name.Name = "serv_name";
            this.serv_name.Size = new System.Drawing.Size(166, 27);
            this.serv_name.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(16, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(16, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Branch";
            // 
            // updService
            // 
            this.updService.BackColor = System.Drawing.Color.Transparent;
            this.updService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updService.BackgroundImage")));
            this.updService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.updService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updService.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updService.Location = new System.Drawing.Point(158, 323);
            this.updService.Name = "updService";
            this.updService.Size = new System.Drawing.Size(122, 70);
            this.updService.TabIndex = 34;
            this.updService.UseVisualStyleBackColor = false;
            // 
            // inactBtn
            // 
            this.inactBtn.BackColor = System.Drawing.Color.Tomato;
            this.inactBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.inactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inactBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inactBtn.Location = new System.Drawing.Point(508, 323);
            this.inactBtn.Name = "inactBtn";
            this.inactBtn.Size = new System.Drawing.Size(122, 59);
            this.inactBtn.TabIndex = 36;
            this.inactBtn.Text = "Inactive";
            this.inactBtn.UseVisualStyleBackColor = false;
            this.inactBtn.Click += new System.EventHandler(this.inactBtn_Click);
            // 
            // activeBtn
            // 
            this.activeBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.activeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.activeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activeBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.activeBtn.Location = new System.Drawing.Point(380, 323);
            this.activeBtn.Name = "activeBtn";
            this.activeBtn.Size = new System.Drawing.Size(122, 59);
            this.activeBtn.TabIndex = 35;
            this.activeBtn.Text = "Active";
            this.activeBtn.UseVisualStyleBackColor = false;
            this.activeBtn.Click += new System.EventHandler(this.activeBtn_Click);
            // 
            // seridtext
            // 
            this.seridtext.Enabled = false;
            this.seridtext.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seridtext.Location = new System.Drawing.Point(137, 105);
            this.seridtext.Multiline = true;
            this.seridtext.Name = "seridtext";
            this.seridtext.Size = new System.Drawing.Size(35, 32);
            this.seridtext.TabIndex = 37;
            this.seridtext.Visible = false;
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backlabel.Location = new System.Drawing.Point(36, 84);
            this.backlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(32, 14);
            this.backlabel.TabIndex = 66;
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
            this.backBtn.Location = new System.Drawing.Point(10, 11);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 72);
            this.backBtn.TabIndex = 65;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(82, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 14);
            this.label5.TabIndex = 67;
            this.label5.Text = "Add";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(202, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 68;
            this.label6.Text = "Update";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(647, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 14);
            this.label7.TabIndex = 70;
            this.label7.Text = "PRINT";
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
            this.button1.Location = new System.Drawing.Point(616, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 67);
            this.button1.TabIndex = 69;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 427);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.seridtext);
            this.Controls.Add(this.inactBtn);
            this.Controls.Add(this.activeBtn);
            this.Controls.Add(this.updService);
            this.Controls.Add(this.branchID);
            this.Controls.Add(this.addService);
            this.Controls.Add(this.prc);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.serv_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Service";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox branchID;
        private System.Windows.Forms.Button addService;
        private System.Windows.Forms.TextBox prc;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox serv_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updService;
        private System.Windows.Forms.Button inactBtn;
        private System.Windows.Forms.Button activeBtn;
        private System.Windows.Forms.TextBox seridtext;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}