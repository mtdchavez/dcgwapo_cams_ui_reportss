namespace WindowsFormsApp1
{
    partial class BranchSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchSale));
            this.backBtn = new System.Windows.Forms.Button();
            this.backlabel = new System.Windows.Forms.Label();
            this.branchSaleGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.genSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.branchSaleGrid)).BeginInit();
            this.SuspendLayout();
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
            this.backBtn.Location = new System.Drawing.Point(23, 13);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(107, 89);
            this.backBtn.TabIndex = 74;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backlabel.Location = new System.Drawing.Point(786, 876);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(39, 18);
            this.backlabel.TabIndex = 75;
            this.backlabel.Text = "back";
            // 
            // branchSaleGrid
            // 
            this.branchSaleGrid.AllowUserToAddRows = false;
            this.branchSaleGrid.AllowUserToDeleteRows = false;
            this.branchSaleGrid.AllowUserToResizeRows = false;
            this.branchSaleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.branchSaleGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.branchSaleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchSaleGrid.Location = new System.Drawing.Point(23, 130);
            this.branchSaleGrid.Name = "branchSaleGrid";
            this.branchSaleGrid.ReadOnly = true;
            this.branchSaleGrid.RowTemplate.Height = 24;
            this.branchSaleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.branchSaleGrid.Size = new System.Drawing.Size(525, 280);
            this.branchSaleGrid.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(60, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 77;
            this.label1.Text = "back";
            // 
            // genSale
            // 
            this.genSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.genSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.genSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genSale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genSale.Location = new System.Drawing.Point(359, 426);
            this.genSale.Margin = new System.Windows.Forms.Padding(4);
            this.genSale.Name = "genSale";
            this.genSale.Size = new System.Drawing.Size(189, 46);
            this.genSale.TabIndex = 78;
            this.genSale.Text = "GENERATE SALE";
            this.genSale.UseVisualStyleBackColor = false;
            this.genSale.Click += new System.EventHandler(this.genSale_Click);
            // 
            // BranchSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 496);
            this.Controls.Add(this.genSale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.branchSaleGrid);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BranchSale";
            this.ShowIcon = false;
            this.Text = "BranchSale";
            this.Load += new System.EventHandler(this.BranchSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.branchSaleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.DataGridView branchSaleGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button genSale;
    }
}