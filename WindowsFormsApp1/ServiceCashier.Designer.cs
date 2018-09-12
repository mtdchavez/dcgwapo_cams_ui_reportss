namespace WindowsFormsApp1
{
    partial class ServiceCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceCashier));
            this.inactBtn = new System.Windows.Forms.Button();
            this.activeBtn = new System.Windows.Forms.Button();
            this.backlabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.serIDlab = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inactBtn
            // 
            this.inactBtn.BackColor = System.Drawing.Color.Tomato;
            this.inactBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.inactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inactBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inactBtn.Location = new System.Drawing.Point(304, 478);
            this.inactBtn.Margin = new System.Windows.Forms.Padding(4);
            this.inactBtn.Name = "inactBtn";
            this.inactBtn.Size = new System.Drawing.Size(163, 73);
            this.inactBtn.TabIndex = 76;
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
            this.activeBtn.Location = new System.Drawing.Point(133, 478);
            this.activeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.activeBtn.Name = "activeBtn";
            this.activeBtn.Size = new System.Drawing.Size(163, 73);
            this.activeBtn.TabIndex = 75;
            this.activeBtn.Text = "Active";
            this.activeBtn.UseVisualStyleBackColor = false;
            this.activeBtn.Click += new System.EventHandler(this.activeBtn_Click);
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backlabel.Location = new System.Drawing.Point(59, 114);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(39, 18);
            this.backlabel.TabIndex = 74;
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
            this.backBtn.Location = new System.Drawing.Point(24, 25);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(107, 89);
            this.backBtn.TabIndex = 73;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // serIDlab
            // 
            this.serIDlab.AutoSize = true;
            this.serIDlab.BackColor = System.Drawing.Color.Transparent;
            this.serIDlab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serIDlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serIDlab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.serIDlab.Location = new System.Drawing.Point(291, 444);
            this.serIDlab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serIDlab.Name = "serIDlab";
            this.serIDlab.Size = new System.Drawing.Size(23, 25);
            this.serIDlab.TabIndex = 72;
            this.serIDlab.Text = "0";
            this.serIDlab.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 153);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(561, 279);
            this.dataGridView1.TabIndex = 71;
            // 
            // ServiceCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 596);
            this.Controls.Add(this.inactBtn);
            this.Controls.Add(this.activeBtn);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.serIDlab);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServiceCashier";
            this.Text = "ServiceCashier";
            this.Load += new System.EventHandler(this.ServiceCashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inactBtn;
        private System.Windows.Forms.Button activeBtn;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label serIDlab;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}