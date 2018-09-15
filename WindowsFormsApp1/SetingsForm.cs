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
    public partial class SetingsForm : Form
    {
        public Dashadmin ref_dashadmin { get; set; }
        public MySqlConnection conn;

        public SetingsForm()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none");
        }

        private void passBtn_Click(object sender, EventArgs e)
        {

        }

        

        private void SetingsForm_Load(object sender, EventArgs e)
        {
            Rifreeesh();
        }

        public void Rifreeesh()
        {
            try
            {
                conn.Open();
                String query = "SELECT u.userID, e.fname, e.lname, e.position, u.username, u.password FROM users u INNER JOIN employee e ON e.id = u.emp_id";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["userID"].Visible = false;
                dataGridView1.Columns["fname"].HeaderText = "First Name";
                dataGridView1.Columns["lname"].HeaderText = "Last Name";
                dataGridView1.Columns["position"].HeaderText = "Position";
                dataGridView1.Columns["username"].HeaderText = "Username";
                dataGridView1.Columns["password"].HeaderText = "Password";


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashadmin admin = new Dashadmin();
            admin.ref_usr_mgt = this;
            admin.Show();
            this.Close();
        }

        private void usernameUpd_Click(object sender, EventArgs e)
        {
            try
            {
                if (userTxt.Text == "")
                {
                    MessageBox.Show("Enter credentials");
                }
                else
                {
                    conn.Open();

                    String query = "UPDATE users SET username = '"+ userTxt.Text +"' WHERE userID = "+ userID.Text +"";
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();

                    conn.Close();
                    userTxt.Text = "";
                    opsswrdTxt.Text = "";
                    npsswrdTxt.Text = "";
                    cpsswrdTxt.Text = "";

                    Rifreeesh();
                }
                MessageBox.Show("Username is updated");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String username = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
            String user_id = dataGridView1.Rows[e.RowIndex].Cells["userID"].Value.ToString();
            String password = dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();

            userID.Text = user_id;
            userTxt.Text = username;

        }

        private void passUpd_Click(object sender, EventArgs e)
        {
            try
            {
                if (opsswrdTxt.Text == "" || npsswrdTxt.Text == "" || cpsswrdTxt.Text == "")
                {
                    MessageBox.Show("Enter credentials");
                }
                else if (npsswrdTxt.Text != cpsswrdTxt.Text)
                {
                    MessageBox.Show("The password doesn't match");
                }
                else
                {
                    conn.Open();

                    String query = "UPDATE users SET password = '" + cpsswrdTxt.Text + "' WHERE userID = " + userID.Text + "";
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();

                    conn.Close();
                    userTxt.Text = "";
                    opsswrdTxt.Text = "";
                    npsswrdTxt.Text = "";
                    cpsswrdTxt.Text = "";

                    MessageBox.Show("Password is updated");

                    Rifreeesh();
                }
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }
    }
}
