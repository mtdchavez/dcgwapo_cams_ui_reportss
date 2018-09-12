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
    public partial class Login : Form
    {
        public MySqlConnection conn;
        public Dashadmin ref_dashadmin { get; set; }
        public Dashcashier ref_dashcashier { get; set; }
        public Login()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                String query = "SELECT * FROM employee INNER JOIN users ON users.emp_id = employee.id WHERE users.username = '" + username.Text + "' AND users.password = '" + password.Text + "';";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                GlobalVariables.User_Branch_ID = int.Parse(dt.Rows[0]["branch_id"].ToString());
                GlobalVariables.User_Emp_ID = int.Parse(dt.Rows[0]["id"].ToString());

                if (dt.Rows.Count == 1 && dt.Rows[0]["position"].ToString() == "Admin")
                {
                    Dashadmin main = new Dashadmin();
                    main.ref_login = this;
                    main.ref_dtlogin = dt;
                    main.Show();
                    this.Hide();
                }
                else if (dt.Rows.Count == 1 && dt.Rows[0]["position"].ToString() == "Cashier")
                {
                    Dashcashier main = new Dashcashier();
                    main.ref_login = this;
                    main.ref_dtlogin = dt;
                    main.Show();
                    this.Hide();
                }
                else if (username.Text == "" || password.Text == "")
                {
                    MessageBox.Show("Please enter the username and/or password");
                }
                else
                {
                    MessageBox.Show("Please enter the correct username and/or password");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
