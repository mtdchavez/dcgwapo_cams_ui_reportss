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
    
    public partial class AttendanceLogs : Form
    {
        public Dashcashier ref_dashcashier { get; set; }
        public MySqlConnection conn;

        public AttendanceLogs()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none;");
        }


        private void AttendanceLogs_Load(object sender, EventArgs e)
        {

            RifreeeshTimeIn();
            RifreeeshTimeOut();
            fillcombo_emp();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void addLogs_Click(object sender, EventArgs e)
        {
            int empIdInt = empCombo.SelectedIndex + 1;

 
            try
            {
                if (empCombo.Text == String.Empty)
                {
                    MessageBox.Show ("Enter credentials");
                }
                else
                {
                    if (MessageBox.Show ("Do you want to add the data?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open ();

                        String query = "call addLogs(" + empIdInt + ")";
                        MySqlCommand comm = new MySqlCommand(query, conn);
                        comm.ExecuteNonQuery();

                        conn.Close();
                    }
                    MessageBox.Show ("Attendance", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RifreeeshTimeIn();
                    RifreeeshTimeOut();
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show (ee.ToString());
                conn.Close();
            }
        }

        

        public void RifreeeshTimeIn()
        {
            try
            {
                conn.Open();
                String query = "CALL selTimeIn(" + GlobalVariables.User_Branch_ID + ")";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                timeInGrid.DataSource = dt;
                timeInGrid.Columns["fname"].HeaderText = "First Name";
                timeInGrid.Columns["lname"].HeaderText = "Last Name";
                timeInGrid.Columns["position"].HeaderText = "Position";
                timeInGrid.Columns["time_in"].HeaderText = "Time In";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        public void RifreeeshTimeOut()
        {
            try
            {
                conn.Open();
                String query = "CALL selTimeOut(" + GlobalVariables.User_Branch_ID + ")";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                timeOutGrid.DataSource = dt;
                timeOutGrid.Columns["fname"].HeaderText = "First Name";
                timeOutGrid.Columns["lname"].HeaderText = "Last Name";
                timeOutGrid.Columns["position"].HeaderText = "Position";
                timeOutGrid.Columns["time_out"].HeaderText = "Time Out";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        public void fillcombo_emp()
        {
            string empquery = "SELECT CONCAT(fname, ' ', lname) FROM employee WHERE position IN('Barber', 'Cashier') AND status = 'Active' AND branch_id = " + GlobalVariables.User_Branch_ID + " AND id <> " + GlobalVariables.User_Emp_ID + "";
            // AND branch_id = GlobalVariables.User_Branch_ID;
            MySqlCommand empcom = new MySqlCommand(empquery, conn);
            try
            {
                conn.Open();
                MySqlDataReader myReader = empcom.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    empCombo.Items.Add(name);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        private void timeInGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void allGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void timeOutGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AttendanceLogs_FormClosing(object sender, FormClosingEventArgs e)
        {
            ref_dashcashier.Show();
        }

        private void timeInGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
