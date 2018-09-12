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
    public partial class ServiceDetail : Form
    {
        public ClientTransaction ref_clienttrans { get; set; }
        public Payment ref_payment { get; set; }
        public MySqlConnection conn;
        public ServiceDetail()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none;");
        }
        public void Rifreeesh()
        {
            try
            {
                conn.Open();
                String query = "SELECT sd.id, s.name, s.price, sd.added_on FROM service_details sd " +
                    "INNER JOIN service s ON sd.service_id = s.id WHERE client_transaction_id = " + ClientTransaction.selected_trans_id+ "";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                servicesGrid.DataSource = dt;
                servicesGrid.Columns["id"].HeaderText = "Service Detail ID";
                servicesGrid.Columns["name"].HeaderText = "Service";
                servicesGrid.Columns["price"].HeaderText = "Price";
                servicesGrid.Columns["added_on"].HeaderText = "Transaction Date";
                total_this();

                selected_amt = double.Parse(amtLabel.Text);
            }
            catch (Exception ee)
            {
                conn.Close();
            }
        }

        private void total_this()
        {
            double total = 0;
            for (int i = 0; i < servicesGrid.Rows.Count; i++)
            {
                total += double.Parse(servicesGrid.Rows[i].Cells["price"].Value.ToString());
            }
            amtLabel.Text = total.ToString("#,###.##");
            
        }

        public static int selected_trans_id;
        public static double selected_amt;
        public static string kliyente;

        private void ServiceDetail_Load(object sender, EventArgs e)
        {
            Rifreeesh();
            tIDlabel.Text = string.Concat(ClientTransaction.selected_trans_id);
            amtLabel.Text =  ClientTransaction.selected_amount;
            statusLabel.Text = ClientTransaction.selected_status;
            fillcombo_barber();
            fillcombo_service();

            selected_trans_id = int.Parse(tIDlabel.Text);
            

            if (statusLabel.Text == "Paid")
            {
                payBtn.Enabled = false;
                addOrd.Enabled = false;
                barberCombo.Enabled = false;
                serviceCombo.Enabled = false;
            }
            
        }

        public void fillcombo_barber()
        {
            string empquery = "SELECT CONCAT(e.fname, ' ', e.lname) FROM employee e INNER JOIN barber_employee b ON b.emp_id = e.id INNER JOIN attendance_log a ON a.emp_id = e.id WHERE e.branch_id = " + GlobalVariables.User_Branch_ID + " AND date(time_in) = curdate() AND io = 'Time In'";
            MySqlCommand barbercom = new MySqlCommand(empquery, conn);
            try
            {
                conn.Open();
                MySqlDataReader myReader = barbercom.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    barberCombo.Items.Add(name);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

 
        public void fillcombo_service()
        {
            string servicequery = "SELECT CONCAT(name, '/', price) FROM service WHERE branch_id = " + GlobalVariables.User_Branch_ID + " AND status = 'Active' ";
            MySqlCommand servicecom = new MySqlCommand(servicequery, conn);
            try
            {
                conn.Open();
                MySqlDataReader myReader = servicecom.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    serviceCombo.Items.Add(name);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void addOrd_Click(object sender, EventArgs e)
        {
            int barberIdInt;
            int serviceIdInt;

            //serviceCombo
            conn.Open();

            MySqlCommand getBarberID = new MySqlCommand("SELECT ID FROM EMPLOYEE WHERE (CONCAT(FNAME, ' ', LNAME) LIKE'%" + barberCombo.Text + "%')", conn);
            barberIdInt = Convert.ToInt32(getBarberID.ExecuteScalar());

            MySqlCommand getServiceID = new MySqlCommand("SELECT ID FROM SERVICE WHERE CONCAT(name, '/', price) LIKE'%" + serviceCombo.Text + "%'",conn);
            serviceIdInt = Convert.ToInt32(getServiceID.ExecuteScalar());


            try
            {
                if (barberCombo.Text == String.Empty || serviceCombo.Text == String.Empty)
                {
                    MessageBox.Show("Enter credentials");
                }
                else
                {
                    if (MessageBox.Show("Do you want to add the data?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        

                        String query = "CALL addOrder("+ tIDlabel.Text +", "+ barberIdInt +", "+ serviceIdInt +");";
                        MySqlCommand comm = new MySqlCommand(query, conn);
                        comm.ExecuteNonQuery();

                        conn.Close();
                    }
                    MessageBox.Show("New order has been added", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Rifreeesh();
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.reftrans = this;
            pay.Show();
            this.Hide();
           
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServiceDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            ref_clienttrans.Show();
        }

        private void backBtn_Click_2(object sender, EventArgs e)
        {
            //this.Close();

            ClientTransaction orders = new ClientTransaction();
            orders.ref_trans1 = this;
            orders.Show();
            this.Hide();
        }
        
    }
}
