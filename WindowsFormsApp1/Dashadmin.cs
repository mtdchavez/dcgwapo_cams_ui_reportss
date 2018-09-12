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
    public partial class Dashadmin : Form
    {
        public Login ref_login { get; set; }
        public DataTable ref_dtlogin { get; set; }
        public Branch ref_branch { get; set; }
        public Service ref_service { get; set; }
        public Employee ref_employee { get; set; }
        public CashierCommission ref_cashiercomm { get; set; }

        public MySqlConnection conn;

        public Dashadmin()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Branch br = new Branch();
            br.ref_dashadmin = this;
            br.Show();
            this.Hide();
        }

        private void empman_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.ref_dashadmin = this;
            emp.Show();
            this.Hide();
        }

        private void serman_Click(object sender, EventArgs e)
        {
            Service ser = new Service();
            ser.ref_dashadmin = this;
            ser.Show();
            this.Hide();
        }

        private void cashCommBtn_Click(object sender, EventArgs e)
        {
            CashierCommission cashcomm = new CashierCommission();
            cashcomm.ref_dashadmin = this;
            cashcomm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ref_dashadmin = this;
            log.Show();
            this.Close();
        }

        private void Dashadmin_Load(object sender, EventArgs e)
        {
            checkTransfer();
        }
        public void checkTransfer()
        {
            int count = 0;
            conn.Open();

            MySqlCommand getTransferCount = new MySqlCommand("SELECT * FROM EMPLOYEE_TRANSFER WHERE DATE_TO < NOW()", conn);
            count = Convert.ToInt32(getTransferCount.ExecuteScalar());

            if (count >= 1)
            {
                notificationLbl.Visible = true;
            }
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ref_dashadmin = this;
            log.Show();
            this.Close();
        }

        private void notificationLbl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Barber employee transfer has already end his duty, retrieve him now", "Okay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Branch br = new Branch();
                br.ref_dashadmin = this;
                br.Show();
                this.Hide();
            }
        }

        private void notifications_Click(object sender, EventArgs e)
        {

        }
    }
}
