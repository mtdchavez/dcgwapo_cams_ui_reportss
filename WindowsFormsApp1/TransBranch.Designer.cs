namespace WindowsFormsApp1
{
    partial class TransBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransBranch));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Branchnm = new System.Windows.Forms.Label();
            this.br_ID = new System.Windows.Forms.ComboBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.backlabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.End = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(198, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 70;
            this.label2.Text = "Cancel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(108, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 69;
            this.label1.Text = "Confirm";
            // 
            // Branchnm
            // 
            this.Branchnm.AutoSize = true;
            this.Branchnm.BackColor = System.Drawing.Color.Transparent;
            this.Branchnm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Branchnm.ForeColor = System.Drawing.Color.Transparent;
            this.Branchnm.Location = new System.Drawing.Point(31, 88);
            this.Branchnm.Name = "Branchnm";
            this.Branchnm.Size = new System.Drawing.Size(101, 33);
            this.Branchnm.TabIndex = 68;
            this.Branchnm.Text = "Branch";
            // 
            // br_ID
            // 
            this.br_ID.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_ID.FormattingEnabled = true;
            this.br_ID.Location = new System.Drawing.Point(128, 88);
            this.br_ID.Name = "br_ID";
            this.br_ID.Size = new System.Drawing.Size(197, 37);
            this.br_ID.TabIndex = 65;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.Transparent;
            this.Confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Confirm.BackgroundImage")));
            this.Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Confirm.FlatAppearance.BorderSize = 0;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(81, 133);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(86, 67);
            this.Confirm.TabIndex = 66;
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancel.BackgroundImage")));
            this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cancel.Location = new System.Drawing.Point(173, 133);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(95, 67);
            this.Cancel.TabIndex = 67;
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backlabel.Location = new System.Drawing.Point(26, 64);
            this.backlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(32, 14);
            this.backlabel.TabIndex = 72;
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
            this.backBtn.Location = new System.Drawing.Point(4, 6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(71, 56);
            this.backBtn.TabIndex = 71;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.End);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.endDTP);
            this.panel1.Controls.Add(this.startDTP);
            this.panel1.Controls.Add(this.Confirm);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 220);
            this.panel1.TabIndex = 73;
            // 
            // End
            // 
            this.End.AutoSize = true;
            this.End.BackColor = System.Drawing.Color.Transparent;
            this.End.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.ForeColor = System.Drawing.Color.Transparent;
            this.End.Location = new System.Drawing.Point(15, 83);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(61, 33);
            this.End.TabIndex = 75;
            this.End.Text = "End";
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Transparent;
            this.Start.Location = new System.Drawing.Point(15, 40);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(76, 33);
            this.Start.TabIndex = 74;
            this.Start.Text = "Start";
            // 
            // endDTP
            // 
            this.endDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDTP.Location = new System.Drawing.Point(118, 92);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(190, 20);
            this.endDTP.TabIndex = 72;
            // 
            // startDTP
            // 
            this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTP.Location = new System.Drawing.Point(118, 49);
            this.startDTP.Name = "startDTP";
            this.startDTP.Size = new System.Drawing.Size(190, 20);
            this.startDTP.TabIndex = 71;
            // 
            // TransBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 334);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.Branchnm);
            this.Controls.Add(this.br_ID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransBranch";
            this.Text = "TransBranch";
            this.Load += new System.EventHandler(this.TransBranch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Branchnm;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox br_ID;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label End;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.DateTimePicker startDTP;
    }
}