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
    public partial class BarberCommission : Form
    {
        public Dashcashier ref_dashcashieer { get; set; }
        public MySqlConnection conn;
        public BarberCommission()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none");
        }

        private void BarberCommission_Load(object sender, EventArgs e)
        {
            Rifreeesh();
        }

        public void Rifreeesh()
        {
            try
            {
                conn.Open();
                String query = "SELECT e.fname, e.lname, b.tot_salary, b.sal_date FROM barber_employee b INNER JOIN employee e ON b.emp_id = e.id  WHERE e.branch_id = " + GlobalVariables.User_Branch_ID + ";";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["fname"].HeaderText = "FirstName";
                dataGridView1.Columns["lname"].HeaderText = "LastName";
                dataGridView1.Columns["tot_salary"].HeaderText = "TotalSalary";
                dataGridView1.Columns["sal_date"].HeaderText = "SalaryDate";

                MySqlDataReader myReader;

                conn.Open();
                myReader = comm.ExecuteReader();
                while (myReader.Read())
                {
                    string name = myReader.GetString(2);

                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashcashier cashir = new Dashcashier();
            cashir.ref_barbercomm = this;
            cashir.Show();
            this.Hide();
        }
    }
}
