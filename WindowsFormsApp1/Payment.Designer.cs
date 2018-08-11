namespace WindowsFormsApp1
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.payamtTxt = new System.Windows.Forms.TextBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.amtLabel = new System.Windows.Forms.Label();
            this.tIDlabel = new System.Windows.Forms.Label();
            this.backlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 27);
            this.label5.TabIndex = 56;
            this.label5.Text = "Total Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 27);
            this.label2.TabIndex = 57;
            this.label2.Text = "Transaction ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(52, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 27);
            this.label6.TabIndex = 58;
            this.label6.Text = "Payment :";
            // 
            // payamtTxt
            // 
            this.payamtTxt.Font = new System.Drawing.Font("Arial", 15.5F);
            this.payamtTxt.Location = new System.Drawing.Point(159, 120);
            this.payamtTxt.Multiline = true;
            this.payamtTxt.Name = "payamtTxt";
            this.payamtTxt.Size = new System.Drawing.Size(142, 31);
            this.payamtTxt.TabIndex = 59;
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.Transparent;
            this.payBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payBtn.BackgroundImage")));
            this.payBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.payBtn.Location = new System.Drawing.Point(92, 197);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(95, 63);
            this.payBtn.TabIndex = 60;
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelBtn.Location = new System.Drawing.Point(195, 197);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(95, 63);
            this.cancelBtn.TabIndex = 60;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // amtLabel
            // 
            this.amtLabel.AutoSize = true;
            this.amtLabel.BackColor = System.Drawing.Color.Transparent;
            this.amtLabel.Font = new System.Drawing.Font("Arial", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtLabel.ForeColor = System.Drawing.Color.White;
            this.amtLabel.Location = new System.Drawing.Point(198, 90);
            this.amtLabel.Name = "amtLabel";
            this.amtLabel.Size = new System.Drawing.Size(22, 24);
            this.amtLabel.TabIndex = 61;
            this.amtLabel.Text = "0";
            // 
            // tIDlabel
            // 
            this.tIDlabel.AutoSize = true;
            this.tIDlabel.BackColor = System.Drawing.Color.Transparent;
            this.tIDlabel.Font = new System.Drawing.Font("Arial", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIDlabel.ForeColor = System.Drawing.Color.White;
            this.tIDlabel.Location = new System.Drawing.Point(210, 53);
            this.tIDlabel.Name = "tIDlabel";
            this.tIDlabel.Size = new System.Drawing.Size(22, 24);
            this.tIDlabel.TabIndex = 62;
            this.tIDlabel.Text = "0";
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backlabel.Location = new System.Drawing.Point(130, 263);
            this.backlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(26, 14);
            this.backlabel.TabIndex = 63;
            this.backlabel.Text = "Pay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(225, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 64;
            this.label1.Text = "Cancel";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.tIDlabel);
            this.Controls.Add(this.amtLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.payamtTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Payment";
            this.Text = "Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payment_FormClosing);
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox payamtTxt;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label amtLabel;
        private System.Windows.Forms.Label tIDlabel;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Label label1;
    }
}