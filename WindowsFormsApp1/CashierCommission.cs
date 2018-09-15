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
    public partial class CashierCommission : Form
    {
        public Dashadmin ref_dashadmin { get; set; }
        public CashierUtang ref_utang { get; set; }
        public MySqlConnection conn;
        public CashierCommission()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none");
        }

        public void Rifreeesh()
        {
            try
            {
                conn.Open();
                String query = "SELECT e.id, CONCAT(e.fname, ' ', e.lname) as 'fullname', c.mon_salary, c.allowance, c.sal_date FROM cashier_employee c INNER JOIN employee e ON c.emp_id = e.id;";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                cashierEmpGrid.DataSource = dt;
                cashierEmpGrid.Columns["id"].Visible = false;
                cashierEmpGrid.Columns["fullname"].HeaderText = "Cashier";
                cashierEmpGrid.Columns["mon_salary"].HeaderText = "Salary";
                cashierEmpGrid.Columns["allowance"].HeaderText = "Allowance";
                cashierEmpGrid.Columns["sal_date"].HeaderText = "Date";


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void CashierCommission_Load(object sender, EventArgs e)
        {
            Rifreeesh();
            //fillcombo_emp();
        }

        /*public void fillcombo_emp()
        {
            string empquery = "SELECT CONCAT(fname,' ', lname) FROM employee WHERE position = 'Cashier' AND status = 'Active';";
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
        }*/

        private void addBtn_Click(object sender, EventArgs e)
        {            
            try
            {
                if (allowance.Text == "")
                {
                    MessageBox.Show("Enter credentials");
                }
                else
                {
                    if (MessageBox.Show("Do you want to add the data?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        
                        String query = "UPDATE cashier_employee SET mon_salary = 1500.00, allowance = " + double.Parse(allowance.Text) + " WHERE emp_id = " + int.Parse(userID.Text) + ";";
                        MySqlCommand comm = new MySqlCommand(query, conn);
                        comm.ExecuteNonQuery();

                        conn.Close();
                    }
                    MessageBox.Show("Cashier Commission Added", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Rifreeesh();
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
            Dashadmin admin = new Dashadmin();
            admin.ref_cashiercomm = this;
            admin.Show();
            this.Close();
        }

        //public static int empID;
        private void cashierEmpGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if(e.RowIndex > -1)
            {
                empID = int.Parse(cashierEmpGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
            }*/
            String empID = cashierEmpGrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
            String fullnametwo = cashierEmpGrid.Rows[e.RowIndex].Cells["fullname"].Value.ToString();

            userID.Text = empID;
            fullname.Text = fullnametwo;
        }

        private void cashadvBtn_Click(object sender, EventArgs e)
        {
            CashierUtang utang = new CashierUtang();
            utang.ref_cashiercomm = this;
            utang.Show();
            this.Hide();
        }
    }
}