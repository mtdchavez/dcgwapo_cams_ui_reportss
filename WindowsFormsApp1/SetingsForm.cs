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

        private void button2_Click(object sender, EventArgs e)
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
                String query = "SELECT e.fname, e.lname, e.position, u.username, u.password FROM users u INNER JOIN employee e ON e.id = u.emp_id  WHERE e.position <> 'Barber';";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                dataGridView1.DataSource = dt;
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
    }
}
