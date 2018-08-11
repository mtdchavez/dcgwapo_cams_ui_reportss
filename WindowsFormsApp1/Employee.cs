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
    public partial class Employee : Form
    {
        public Dashadmin ref_dashadmin { get; set; }
        public MySqlConnection conn;

        public Employee()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none");
        }

        public void Rifreeesh()
        {
            try
            {
                conn.Open();
                String query = "CALL selEmp()";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["name"].HeaderText = "Branch";
                dataGridView1.Columns["fname"].HeaderText = "First Name";
                dataGridView1.Columns["mname"].HeaderText = "Middle Name";
                dataGridView1.Columns["lname"].HeaderText = "Last Name";
                dataGridView1.Columns["birthday"].HeaderText = "Birthday";
                dataGridView1.Columns["contact_number"].HeaderText = "Contact Number";
                dataGridView1.Columns["position"].HeaderText = "Position";
                dataGridView1.Columns["username"].Visible = false;
                dataGridView1.Columns["password"].Visible = false;
                dataGridView1.Columns["status"].HeaderText = "Status";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        public void RifreeeshBarber()
        {
            try
            {
                conn.Open();
                String query = "CALL selBarber";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                dataGridView2.DataSource = dt;
                dataGridView2.Columns["id"].Visible = false;
                dataGridView2.Columns["name"].HeaderText = "Branch";
                dataGridView2.Columns["fname"].HeaderText = "First Name";
                dataGridView2.Columns["mname"].HeaderText = "Middle Name";
                dataGridView2.Columns["lname"].HeaderText = "Last Name";
                dataGridView2.Columns["birthday"].HeaderText = "Birthday";
                dataGridView2.Columns["contact_number"].HeaderText = "Contact Number";
                dataGridView2.Columns["position"].HeaderText = "Position";
                dataGridView2.Columns["username"].Visible = false;
                dataGridView2.Columns["password"].Visible = false;
                dataGridView2.Columns["status"].HeaderText = "Status";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        public void RifreeeshCashier()
        {
            try
            {
                conn.Open();
                String query = "CALL selCashier";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                cashier.DataSource = dt;
                cashier.Columns["id"].Visible = false;
                cashier.Columns["name"].HeaderText = "Branch";
                cashier.Columns["fname"].HeaderText = "First Name";
                cashier.Columns["mname"].HeaderText = "Middle Name";
                cashier.Columns["lname"].HeaderText = "Last Name";
                cashier.Columns["birthday"].HeaderText = "Birthday";
                cashier.Columns["contact_number"].HeaderText = "Contact Number";
                cashier.Columns["position"].HeaderText = "Position";
                cashier.Columns["username"].Visible = false;
                cashier.Columns["password"].Visible = false;
                cashier.Columns["status"].HeaderText = "Status";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            Rifreeesh();
            RifreeeshBarber();
            RifreeeshCashier();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Click_1(object sender, EventArgs e)
        {

        }
    }
}
