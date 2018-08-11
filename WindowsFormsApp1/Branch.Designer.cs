namespace WindowsFormsApp1
{
    partial class Branch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Branch));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addbranch = new System.Windows.Forms.Button();
            this.cityText = new System.Windows.Forms.TextBox();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.brnametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updBranch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.renBtn = new System.Windows.Forms.Button();
            this.closedBtn = new System.Windows.Forms.Button();
            this.bridtext = new System.Windows.Forms.TextBox();
            this.backlabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(217, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(365, 40);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(797, 252);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // addbranch
            // 
            this.addbranch.BackColor = System.Drawing.Color.Transparent;
            this.addbranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addbranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbranch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbranch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addbranch.Image = ((System.Drawing.Image)(resources.GetObject("addbranch.Image")));
            this.addbranch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addbranch.Location = new System.Drawing.Point(257, 674);
            this.addbranch.Margin = new System.Windows.Forms.Padding(4);
            this.addbranch.Name = "addbranch";
            this.addbranch.Size = new System.Drawing.Size(144, 91);
            this.addbranch.TabIndex = 8;
            this.addbranch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addbranch.UseVisualStyleBackColor = false;
            this.addbranch.Click += new System.EventHandler(this.addbranch_Click);
            // 
            // cityText
            // 
            this.cityText.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityText.Location = new System.Drawing.Point(154, 113);
            this.cityText.Margin = new System.Windows.Forms.Padding(4);
            this.cityText.Multiline = true;
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(288, 40);
            this.cityText.TabIndex = 15;
            // 
            // locationTxt
            // 
            this.locationTxt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTxt.Location = new System.Drawing.Point(154, 65);
            this.locationTxt.Margin = new System.Windows.Forms.Padding(4);
            this.locationTxt.Multiline = true;
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(288, 40);
            this.locationTxt.TabIndex = 14;
            // 
            // brnametxt
            // 
            this.brnametxt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnametxt.Location = new System.Drawing.Point(154, 17);
            this.brnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.brnametxt.Multiline = true;
            this.brnametxt.Name = "brnametxt";
            this.brnametxt.Size = new System.Drawing.Size(288, 40);
            this.brnametxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(37, 516);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // updBranch
            // 
            this.updBranch.BackColor = System.Drawing.Color.Transparent;
            this.updBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updBranch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updBranch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updBranch.Image = ((System.Drawing.Image)(resources.GetObject("updBranch.Image")));
            this.updBranch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.updBranch.Location = new System.Drawing.Point(409, 674);
            this.updBranch.Margin = new System.Windows.Forms.Padding(4);
            this.updBranch.Name = "updBranch";
            this.updBranch.Size = new System.Drawing.Size(144, 91);
            this.updBranch.TabIndex = 16;
            this.updBranch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.updBranch.UseVisualStyleBackColor = false;
            this.updBranch.Click += new System.EventHandler(this.updBranch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(592, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 48);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.openBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.openBtn.Location = new System.Drawing.Point(563, 416);
            this.openBtn.Margin = new System.Windows.Forms.Padding(4);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(120, 49);
            this.openBtn.TabIndex = 18;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // renBtn
            // 
            this.renBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.renBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.renBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renBtn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.renBtn.Location = new System.Drawing.Point(303, 415);
            this.renBtn.Margin = new System.Windows.Forms.Padding(4);
            this.renBtn.Name = "renBtn";
            this.renBtn.Size = new System.Drawing.Size(232, 50);
            this.renBtn.TabIndex = 19;
            this.renBtn.Text = "On Renovation/Temporary Closure";
            this.renBtn.UseVisualStyleBackColor = false;
            this.renBtn.Click += new System.EventHandler(this.renBtn_Click);
            // 
            // closedBtn
            // 
            this.closedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.closedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedBtn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closedBtn.Location = new System.Drawing.Point(157, 415);
            this.closedBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closedBtn.Name = "closedBtn";
            this.closedBtn.Size = new System.Drawing.Size(120, 50);
            this.closedBtn.TabIndex = 20;
            this.closedBtn.Text = "Closed";
            this.closedBtn.UseVisualStyleBackColor = false;
            this.closedBtn.Click += new System.EventHandler(this.closedBtn_Click);
            // 
            // bridtext
            // 
            this.bridtext.Enabled = false;
            this.bridtext.Location = new System.Drawing.Point(42, 30);
            this.bridtext.Margin = new System.Windows.Forms.Padding(4);
            this.bridtext.Multiline = true;
            this.bridtext.Name = "bridtext";
            this.bridtext.Size = new System.Drawing.Size(45, 38);
            this.bridtext.TabIndex = 21;
            this.bridtext.Visible = false;
            this.bridtext.TextChanged += new System.EventHandler(this.bridtext_TextChanged);
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backlabel.Location = new System.Drawing.Point(47, 102);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(39, 18);
            this.backlabel.TabIndex = 60;
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
            this.backBtn.Location = new System.Drawing.Point(13, 13);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(106, 88);
            this.backBtn.TabIndex = 59;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.brnametxt);
            this.panel1.Controls.Add(this.locationTxt);
            this.panel1.Controls.Add(this.cityText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(13, 497);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 170);
            this.panel1.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.bridtext);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(13, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 100);
            this.panel2.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(313, 769);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Add";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(454, 769);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 64;
            this.label5.Text = "Update";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(726, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 66;
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
            this.button1.Location = new System.Drawing.Point(685, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 83);
            this.button1.TabIndex = 65;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 805);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.closedBtn);
            this.Controls.Add(this.renBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.updBranch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addbranch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Branch";
            this.Text = "Branch";
            this.Load += new System.EventHandler(this.Branch_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addbranch;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.TextBox brnametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updBranch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button renBtn;
        private System.Windows.Forms.Button closedBtn;
        private System.Windows.Forms.TextBox bridtext;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}