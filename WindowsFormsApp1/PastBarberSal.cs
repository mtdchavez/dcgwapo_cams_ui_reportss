using MySql.Data.MySqlClient;
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
    public partial class PastBarberSal : Form
    {
        public BarberCommission ref_barbcomm { get; set; }
        public MySqlConnection conn;
        public PastBarberSal()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none");
        }

        public void Rifreeesh()
        {
            try
            {
                conn.Open();
                String query = "SELECT e.fname, e.lname, CONCAT('Php ' + b.tot_salary) as salary, b.sal_date from barber_salary_archive b inner join employee e on b.emp_id = e.id WHERE e.branch_id = " + GlobalVariables.User_Branch_ID + ";";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["fname"].HeaderText = "FirstName";
                dataGridView1.Columns["lname"].HeaderText = "LastName";
                dataGridView1.Columns["salary"].HeaderText = "TotalSalary";
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

        private void PastBarberSal_Load(object sender, EventArgs e)
        {
            Rifreeesh();
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            BarberCommission barb_comm = new BarberCommission();
            barb_comm.ref_barberSal = this;
            barb_comm.Show();
            this.Hide();

        }
    }
}
