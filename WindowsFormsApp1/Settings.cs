using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Settings : Form
    {
        public Dashadmin ref_dashadmin { get; set; }

        public Settings()
        {
            InitializeComponent();
        }

        private void usernameUpd_Click(object sender, EventArgs e)
        {
            if (barberPctTxt.Text == "" || salesPctTxt.Text == "")
            {
                MessageBox.Show("Enter credentials");
            }
            else
            {
                GlobalVariables.pct_barber = double.Parse(barberPctTxt.Text);
                GlobalVariables.pct_sale = double.Parse(salesPctTxt.Text);
                MessageBox.Show("The percentage has been updated", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                barberPctTxt.Text = "";
                salesPctTxt.Text = "";
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashadmin admin = new Dashadmin();
            admin.ref_settings = this;
            admin.Show();
            this.Close();
        }
    }
}
