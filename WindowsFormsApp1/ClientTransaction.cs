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
    
    public partial class ClientTransaction : Form
    {
        public Dashcashier ref_dashcashier { get; set; }
        public Clients ref_clients { get; set; }
        public ServiceDetail ref_trans1 { get; set; }
        public Payment ref_pay { get; set; }
        public MySqlConnection conn;
        public ClientTransaction()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none;");
        }

        private void addLogs_Click(object sender, EventArgs e)
        {
            int clientIdInt = clientCombo.SelectedIndex + 1;

            try
            {
                if (clientCombo.Text == String.Empty)
                {
                    MessageBox.Show("Enter credentials");
                }
                else
                {
                    if (MessageBox.Show("Do you want to add the data?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();

                        String query = "INSERT INTO client_transaction VALUES (NULL, " + clientIdInt + ", " +  GlobalVariables.User_Branch_ID +", 'Reserved', 0, NOW());";
                        MySqlCommand comm = new MySqlCommand(query, conn);
                        comm.ExecuteNonQuery();

                        conn.Close();
                    }
                    MessageBox.Show("Transaction has been added", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RifreeeshReserved();
                    RifreeeshPaid();
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        public void fillcombo_client()
        {
            string empquery = "SELECT name FROM client;";
            MySqlCommand clientcom = new MySqlCommand(empquery, conn);
            try
            {
                conn.Open();
                MySqlDataReader myReader = clientcom.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    clientCombo.Items.Add(name);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ClientTransaction_Load(object sender, EventArgs e)
        {
            RifreeeshReserved();
            RifreeeshPaid();
            fillcombo_client();

            /*DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn();
            viewBtn.HeaderText = "Action";
            viewBtn.Text = "View";
            viewBtn.Name = "btnView";
            viewBtn.UseColumnTextForButtonValue = true;
            reservedGrid.Columns.Add(viewBtn);

            DataGridViewButtonColumn payBtn = new DataGridViewButtonColumn();
            payBtn.HeaderText = "Action";
            payBtn.Text = "Pay";
            payBtn.Name = "btnPay";
            payBtn.UseColumnTextForButtonValue = true;
            reservedGrid.Columns.Add(payBtn);*/


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void RifreeeshReserved()
        {
            try
            {
                conn.Open();
                String query = "SELECT t.id, c.name, t.total_amt, t.trans_date, t.status FROM client c INNER JOIN client_transaction t ON t.client_id = c.id WHERE t.status = 'Reserved' AND branch_id = "+ GlobalVariables.User_Branch_ID +"";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                reservedGrid.DataSource = dt;
                reservedGrid.Columns["id"].HeaderText = "Transaction ID";
                reservedGrid.Columns["name"].HeaderText = "Client";
                reservedGrid.Columns["total_amt"].HeaderText = "Total Amount";
                reservedGrid.Columns["trans_date"].HeaderText = "Transaction Date";
                reservedGrid.Columns["status"].Visible = false;

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        public void RifreeeshPaid()
        {
            try
            {
                conn.Open();
                String query = "SELECT t.id, c.name, t.total_amt, t.trans_date, t.status FROM client c INNER JOIN client_transaction t ON t.client_id = c.id WHERE t.status = 'Paid' AND branch_id = " + GlobalVariables.User_Branch_ID + "";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                paidGrid.DataSource = dt;
                paidGrid.Columns["id"].HeaderText = "Transaction ID";
                paidGrid.Columns["name"].HeaderText = "Client";
                paidGrid.Columns["total_amt"].HeaderText = "Total Amount";
                paidGrid.Columns["trans_date"].HeaderText = "Transaction Date";
                paidGrid.Columns["status"].Visible = false;

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            client.ref_clienttrans = this;
            client.Show();
            this.Hide();
        }

        private void reservedGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public static int selected_trans_id; //get the client_transaction_id
        public static string kliyente;
        public static string selected_amount;
        public static string selected_status;

        private void reservedGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            selected_trans_id = int.Parse(reservedGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
            kliyente = reservedGrid.Rows[e.RowIndex].Cells["name"].Value.ToString();
            selected_amount = reservedGrid.Rows[e.RowIndex].Cells["total_amt"].Value.ToString();
            selected_status = reservedGrid.Rows[e.RowIndex].Cells["status"].Value.ToString();

            tIDtxt.Text = string.Concat(selected_trans_id);
            clientTxt.Text = kliyente;
            amtTxt.Text = selected_amount;
            statusTxt.Text = selected_status;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            ServiceDetail service = new ServiceDetail();
            service.ref_clienttrans = this;
            service.Show();
            this.Hide();
        }

        private void paidGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_trans_id = int.Parse(paidGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
            kliyente = paidGrid.Rows[e.RowIndex].Cells["name"].Value.ToString();
            selected_amount = paidGrid.Rows[e.RowIndex].Cells["total_amt"].Value.ToString();
            selected_status = paidGrid.Rows[e.RowIndex].Cells["status"].Value.ToString();

            tIDtxt.Text = string.Concat(selected_trans_id);
            clientTxt.Text = kliyente;
            amtTxt.Text = selected_amount;
            statusTxt.Text = selected_status;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashcashier cashier = new Dashcashier();
            cashier.ref_clienttrans = this;
            cashier.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backlabel_Click(object sender, EventArgs e)
        {

        }

        private void ClientTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
