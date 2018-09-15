using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class CashierUtang : Form
    {
        public CashierCommission ref_cashiercomm { get; set; }
        public MySqlConnection conn;
        public CashierUtang()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none;");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CashierCommission cashcomm = new CashierCommission();
            cashcomm.ref_utang = this;
            cashcomm.Show();
            this.Close();
        }
    }
}
