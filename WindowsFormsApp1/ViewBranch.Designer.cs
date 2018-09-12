namespace WindowsFormsApp1
{
    partial class ViewBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBranch));
            this.backlabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.branchCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewBranchDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewBranchDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backlabel.Location = new System.Drawing.Point(32, 68);
            this.backlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(32, 14);
            this.backlabel.TabIndex = 74;
            this.backlabel.Text = "back";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.Location = new System.Drawing.Point(10, 11);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(71, 56);
            this.backBtn.TabIndex = 73;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // locationTxt
            // 
            this.locationTxt.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTxt.Location = new System.Drawing.Point(194, 102);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(183, 30);
            this.locationTxt.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(98, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 80;
            this.label3.Text = "Location";
            // 
            // cityTxt
            // 
            this.cityTxt.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTxt.Location = new System.Drawing.Point(194, 59);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(183, 30);
            this.cityTxt.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(98, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 27);
            this.label1.TabIndex = 78;
            this.label1.Text = "City";
            // 
            // branchCmb
            // 
            this.branchCmb.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchCmb.FormattingEnabled = true;
            this.branchCmb.Location = new System.Drawing.Point(194, 16);
            this.branchCmb.Name = "branchCmb";
            this.branchCmb.Size = new System.Drawing.Size(183, 30);
            this.branchCmb.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(98, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 76;
            this.label2.Text = "Branch";
            // 
            // viewBranchDGV
            // 
            this.viewBranchDGV.AllowUserToAddRows = false;
            this.viewBranchDGV.AllowUserToDeleteRows = false;
            this.viewBranchDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewBranchDGV.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.viewBranchDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewBranchDGV.Location = new System.Drawing.Point(22, 151);
            this.viewBranchDGV.Name = "viewBranchDGV";
            this.viewBranchDGV.ReadOnly = true;
            this.viewBranchDGV.RowHeadersVisible = false;
            this.viewBranchDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewBranchDGV.Size = new System.Drawing.Size(488, 278);
            this.viewBranchDGV.TabIndex = 75;
            this.viewBranchDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewBranchDGV_CellContentClick);
            // 
            // ViewBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 451);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.branchCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewBranchDGV);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewBranch";
            this.Text = "ViewBranch";
            this.Load += new System.EventHandler(this.ViewBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewBranchDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox branchCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView viewBranchDGV;
    }
}