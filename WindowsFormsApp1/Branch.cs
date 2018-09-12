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
    public partial class Branch : Form
    {
        public ViewBranch ref_branch1 { get; set; }
        public Dashadmin ref_dashadmin { get; set; }
        public MySqlConnection conn;

        public Branch()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none");
        }

        public void Rifreeesh()
        {
            try
            {
                conn.Open();
                String query = "SELECT * FROM branch";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["name"].HeaderText = "Branch";
                dataGridView1.Columns["location"].HeaderText = "Location";
                dataGridView1.Columns["city"].HeaderText = "City";
                dataGridView1.Columns["status"].HeaderText = "Status";


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Branch_Load_1(object sender, EventArgs e)
        {
            Rifreeesh();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Action";
            btn.Text = "View";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void addbranch_Click(object sender, EventArgs e)
        {
            try
            {
                if (brnametxt.Text == "" || locationTxt.Text == "" || cityText.Text == "")
                {
                    MessageBox.Show("Enter credentials");
                }
                else
                {
                    conn.Open();

                    String query = "CALL addBranch('" + brnametxt.Text + "','" + locationTxt.Text + "', '" + cityText.Text +"')";
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();

                    conn.Close();
                    brnametxt.Text = "";
                    locationTxt.Text = "";
                    cityText.Text = "";

                    Rifreeesh();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                String query = "SELECT * FROM branch WHERE name LIKE '%" + txtSearch.Text + "%' ";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void updBranch_Click(object sender, EventArgs e)
        {
            try
            {
                if (brnametxt.Text == "" || locationTxt.Text == "" || cityText.Text == "")
                {
                    MessageBox.Show("Enter credentials");
                }
                else
                {
                    conn.Open();

                    String query = "UPDATE branch SET name = " + brnametxt.Text + ", 	location = " + locationTxt.Text + ", city = " + cityText.Text + " WHERE id = " + bridtext.Text + "";
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();

                    conn.Close();

                    bridtext.Text = "";
                    brnametxt.Text = "";
                    locationTxt.Text = "";
                    cityText.Text = "";

                    Rifreeesh();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }
        public static int selected_branch_id; //get the branch_id
        public static string selected_name;
        public static string selected_location;
        public static string selected_city;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id, name, location, city, status;
            selected_branch_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            name = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            location = dataGridView1.Rows[e.RowIndex].Cells["location"].Value.ToString();
            city = dataGridView1.Rows[e.RowIndex].Cells["city"].Value.ToString();
            status = dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString();

            selected_name = name;
            selected_location = location;
            selected_city = city;

            bridtext.Text = id;
            brnametxt.Text = name;
            locationTxt.Text = location;
            cityText.Text = city;
            
            if (status == "Open")
            {
                openBtn.Enabled = false;
                renBtn.Enabled = true;
                closedBtn.Enabled = true;
            }
            else if (status == "Renovation")
            {
                openBtn.Enabled = true;
                renBtn.Enabled = false;
                closedBtn.Enabled = true;
            }
            else
            {
                openBtn.Enabled = false;
                renBtn.Enabled = false;
                closedBtn.Enabled = false;
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            try
            {
                brstatus("Open");
                Rifreeesh();
                openBtn.Enabled = false;
                renBtn.Enabled = true;
                closedBtn.Enabled = true;
                MessageBox.Show("The branch is now open for business");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void renBtn_Click(object sender, EventArgs e)
        {
            try
            {
                brstatus("Renovation");
                Rifreeesh();
                openBtn.Enabled = true;
                renBtn.Enabled = false;
                closedBtn.Enabled = true;

                MessageBox.Show("The branch will be temporary closed");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void closedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                brstatus("Closed");
                Rifreeesh();
                openBtn.Enabled = false;
                renBtn.Enabled = false;
                closedBtn.Enabled = false;
                MessageBox.Show("The branch will be out of business");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void brstatus(String x)
        {
            try
            {
                conn.Open();
                String query = "UPDATE branch SET status = '" + x + "' WHERE id = '" + bridtext.Text + "'";
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
        private void button1_Click(object sender, EventArgs e)
        {
            BranchPrint br = new BranchPrint();
            br.ref_dashadmin = this;
            br.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashadmin admin = new Dashadmin();
            admin.ref_branch = this;
            admin.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here 
                ViewBranch viiew = new ViewBranch();
                //viiew.ref_branch1 = this;
                viiew.Show();
            }
        }
        public static implicit operator DataGridViewButtonColumn(Branch v)
        {
            throw new NotImplementedException();
        }
    }
}
