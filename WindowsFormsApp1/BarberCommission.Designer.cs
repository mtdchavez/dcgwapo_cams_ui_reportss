namespace WindowsFormsApp1
{
    partial class BarberCommission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarberCommission));
            this.backlabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.PastBarbSal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backlabel.Location = new System.Drawing.Point(44, 92);
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
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.Location = new System.Drawing.Point(19, 20);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 72);
            this.backBtn.TabIndex = 73;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // PastBarbSal
            // 
            this.PastBarbSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PastBarbSal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PastBarbSal.BackgroundImage")));
            this.PastBarbSal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PastBarbSal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PastBarbSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PastBarbSal.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastBarbSal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PastBarbSal.Location = new System.Drawing.Point(285, 20);
            this.PastBarbSal.Name = "PastBarbSal";
            this.PastBarbSal.Size = new System.Drawing.Size(101, 70);
            this.PastBarbSal.TabIndex = 72;
            this.PastBarbSal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PastBarbSal.UseVisualStyleBackColor = false;
            this.PastBarbSal.Click += new System.EventHandler(this.PastBarbSal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(387, 235);
            this.dataGridView1.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(284, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 14);
            this.label1.TabIndex = 75;
            this.label1.Text = "Past Barber Salary";
            // 
            // BarberCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.PastBarbSal);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BarberCommission";
            this.Text = "BarberCommission";
            this.Load += new System.EventHandler(this.BarberCommission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button PastBarbSal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}