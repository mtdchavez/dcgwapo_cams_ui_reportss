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
   
    public partial class Dashcashier : Form
    {
        public Login ref_login { get; set; }
        public DataTable ref_dtlogin { get; set; }
        public AttendanceLogs ref_logs { get; set; }
        public ClientTransaction ref_clienttrans { get; set; }
        public BarberCommission ref_barbercomm { get; set; }
        public ServiceCashier ref_dashcashier { get; set; }
        public BranchSale ref_sale { get; set; }

        public MySqlConnection conn;
        public Dashcashier()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none;");
        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            AttendanceLogs logs = new AttendanceLogs();
            logs.ref_dashcashier = this;
            logs.Show();
            this.Hide();
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            ClientTransaction orders = new ClientTransaction();
            orders.ref_dashcashier = this;
            orders.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ref_dashcashier = this;
            log.Show();
            this.Close();
        }

        private void barberBtn_Click(object sender, EventArgs e)
        {
            BarberCommission comm = new BarberCommission();
            comm.ref_dashcashieer = this;
            comm.Show();
            this.Hide();
        }

        private void service_btn_Click(object sender, EventArgs e)
        {
            ServiceCashier cashier = new ServiceCashier();
            cashier.ref_dashcashier = this;
            cashier.Show();
            this.Hide();
        }

        private void Dashcashier_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void branchSaleBtn_Click(object sender, EventArgs e)
        {
            BranchSale sale = new BranchSale();
            sale.ref_dashcashier = this;
            sale.Show();
            this.Hide();
        }

        private void Dashcashier_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ref_dashcashier = this;
            log.Show();
            this.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ref_dashcashier = this;
            log.Show();
            this.Close();
        }
    }

}
