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
    public partial class ServiceCashier : Form
    {
        public Dashcashier ref_dashcashier { get; set; }
        public MySqlConnection conn;
        public ServiceCashier()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none");
        }

        private void ServiceCashier_Load(object sender, EventArgs e)
        {
            Rifreeesh();
        }
        public void Rifreeesh()
        {
            try
            {
                conn.Open();
                String query = "SELECT * FROM service WHERE branch_id = " + GlobalVariables.User_Branch_ID + ";";
                MySqlCommand comm = new MySqlCommand(query, conn);


                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["branch_id"].Visible = false;
                dataGridView1.Columns["name"].HeaderText = "Service";
                dataGridView1.Columns["description"].HeaderText = "Description";
                dataGridView1.Columns["price"].HeaderText = "Price";
                dataGridView1.Columns["status"].HeaderText = "Status";

                activeBtn.Enabled = false;
                inactBtn.Enabled = false;


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }

        }
        private void serv_status(String x)
        {
            try
            {
                conn.Open();
                String query = "UPDATE service SET status = '" + x + "' WHERE id = '" + int.Parse(serIDlab.Text) + "'";
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void activeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                serv_status("Active");
                Rifreeesh();
                activeBtn.Enabled = false;
                inactBtn.Enabled = true;
                MessageBox.Show("This is service is available");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void inactBtn_Click(object sender, EventArgs e)
        {
            try
            {
                serv_status("Inactive");
                Rifreeesh();
                inactBtn.Enabled = false;
                activeBtn.Enabled = true;
                MessageBox.Show("This service is not available");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashcashier cashiir = new Dashcashier();
            cashiir.ref_dashcashier = this;
            cashiir.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String ser_id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            String status = dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString();
            
            serIDlab.Text = ser_id;
            
            if (status == "Active")
            {
                activeBtn.Enabled = false;
                inactBtn.Enabled = true;
            }
            else
            {
                activeBtn.Enabled = true;
                inactBtn.Enabled = false;
            }
        }
    }
}
