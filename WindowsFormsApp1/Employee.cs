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

        String position;
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
        public void loadBranch()
        {
            AutoCompleteStringCollection branchCollection = new AutoCompleteStringCollection();

            conn.Open();

            String getBranch = "SELECT NAME FROM BRANCH";
            MySqlCommand comm = new MySqlCommand(getBranch, conn);
            comm.CommandText = getBranch;
            MySqlDataReader drd = comm.ExecuteReader();

            if (drd.HasRows == true)
            {
                while (drd.Read())
                {
                    branchCollection.Add(drd["NAME"].ToString());
                }
            }

            drd.Close();
            conn.Close();

            branchidInt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            branchidInt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            branchidInt.AutoCompleteCustomSource = branchCollection;
        }
        public void fillcombo_branch()
        {
            string branchquery = "SELECT DISTINCT(name) FROM branch where status = 'Open'; ";
            MySqlCommand branchcom = new MySqlCommand(branchquery, conn);
            try
            {
                conn.Open();
                MySqlDataReader myReader = branchcom.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    branchidInt.Items.Add(name);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static int selected_branch_id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String fn, mn, ln, conNo, bday, uname, status;
            selected_branch_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            branchidInt.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            fn = dataGridView1.Rows[e.RowIndex].Cells["fname"].Value.ToString();
            mn = dataGridView1.Rows[e.RowIndex].Cells["mname"].Value.ToString();
            ln = dataGridView1.Rows[e.RowIndex].Cells["lname"].Value.ToString();
            conNo = dataGridView1.Rows[e.RowIndex].Cells["contact_number"].Value.ToString();
            bday = dataGridView1.Rows[e.RowIndex].Cells["birthday"].Value.ToString();
            uname = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
            status = dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells["position"].Value.ToString() == "Admin")
            {
                adminRB.Checked = true;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells["position"].Value.ToString() == "Barber")
            {
                barberRB.Checked = true;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells["position"].Value.ToString() == "Cashier")
            {
                cashierRB.Checked = true;
            }

            fname.Text = fn;
            mname.Text = mn;
            lname.Text = ln;
            con_num.Text = conNo;
            birthday.Text = bday;
            username.Text = uname;
        }

        private void back_Click_1(object sender, EventArgs e)
        {

        }

        private void addEmp_Click(object sender, EventArgs e)
        {
            conn.Close();
            adminRB.Enabled = true;
            barberRB.Enabled = true;
            cashierRB.Enabled = true;
            int branchidInt;


            try
            {
                conn.Open();
                if (fname.Text == String.Empty || mname.Text == String.Empty || lname.Text == String.Empty || con_num.Text == String.Empty || username.Text == String.Empty || password.Text == String.Empty)
                {
                    MessageBox.Show("Please input required field.");
                }
                else if (con_num.Text == String.Empty)
                {
                    MessageBox.Show("Enter contact number!");
                }
                else if (!con_num.Text.All(c => Char.IsNumber(c)))
                {
                    MessageBox.Show("Contact is Invalid. Please Use numbers only.");
                    con_num.Clear();

                }
                else
                {
                    //CHECK THE DUPLICATION                
                    int getValidation = 0;
                    int convertedValidation = 0;

                    MySqlCommand EmpValidation = new MySqlCommand("SELECT COUNT(*) FROM EMPLOYEE WHERE FNAME = '" + fname.Text + "' AND LNAME = '" + lname.Text + "' AND BIRTHDAY = '" + birthday.Text + "'", conn);
                    convertedValidation = Convert.ToInt32(EmpValidation.ExecuteScalar());
                    getValidation = convertedValidation;
                    conn.Close();

                    if (getValidation > convertedValidation++)
                    {
                        MessageBox.Show(fname.Text + " " + lname.Text + " is already in the system");
                    }
                    else if (getValidation <= 0)
                    {
                        if (MessageBox.Show("Do you want to add the data?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            conn.Open();

                            String query = "INSERT INTO employee (branch_id, fname, mname, lname, address, contact_number, gender, birthday, position, username, password, status) VALUES (" + branchidInt + ", '" + fname.Text + "', '" + mname.Text + "', '" + lname.Text + "', ' ' , '" + con_num.Text + "', '" + "" + "', '" + this.birthday.Text + "', '" + position + "',  '" + username.Text + "', '" + password.Text + "', 'Active') ";
                            MySqlCommand comm = new MySqlCommand(query, conn);
                            comm.ExecuteNonQuery();

                            conn.Close();
                        }
                        MessageBox.Show("Branch data has been added successfully", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Rifreeesh();
                    }
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
            admin.ref_employee = this;
            admin.Show();
            this.Close();
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(fname.Text, @"[0-9]"))
            {
                MessageBox.Show("Please enter letters only!");
                fname.Clear();
            }
        }

        private void adminRB_CheckedChanged(object sender, EventArgs e)
        {
            position = "Admin";
        }

        private void barberRB_CheckedChanged(object sender, EventArgs e)
        {
            position = "Barber";
        }

        private void cashierRB_CheckedChanged(object sender, EventArgs e)
        {
            position = "Cashier";
        }
    }
}
