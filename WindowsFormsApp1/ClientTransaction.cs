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
           
            try
            {
                
                if (MessageBox.Show("Do you want to add the data?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();

                    String query = "INSERT INTO client_transaction VALUES (NULL, " +  GlobalVariables.User_Branch_ID +", 'Reserved', 0, NOW());";
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();

                    conn.Close();
                }
                MessageBox.Show("Transaction has been added", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RifreeeshReserved();
                

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }

        }
        

        private void ClientTransaction_Load(object sender, EventArgs e)
        {
            RifreeeshReserved();

            viewBtn.Enabled = false;
            cancelBtn.Enabled = false;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void RifreeeshReserved()
        {
            try
            {
                conn.Open();
                String query = "SELECT t.id, t.total_amt, t.trans_date, t.status FROM client_transaction t INNER JOIN branch b ON t.branch_id = b.id WHERE date(trans_date) = CURDATE() AND branch_id = " + GlobalVariables.User_Branch_ID +"";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                reservedGrid.DataSource = dt;
                reservedGrid.Columns["id"].HeaderText = "Transaction ID";
                reservedGrid.Columns["total_amt"].HeaderText = "Total Amount";
                reservedGrid.Columns["trans_date"].HeaderText = "Transaction Date";
                reservedGrid.Columns["status"].HeaderText = "Status";
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
        public static string selected_amount;
        public static string selected_status;

        private void reservedGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            selected_trans_id = int.Parse(reservedGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
            selected_amount = reservedGrid.Rows[e.RowIndex].Cells["total_amt"].Value.ToString();
            selected_status = reservedGrid.Rows[e.RowIndex].Cells["status"].Value.ToString();

            tIDtxt.Text = string.Concat(selected_trans_id);
            amtTxt.Text = selected_amount;

            viewBtn.Enabled = true;

            if (selected_status == "Reserved")
            {
                cancelBtn.Enabled = true;
            }
            
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            ServiceDetail service = new ServiceDetail();
            service.ref_clienttrans = this;
            service.Show();
            this.Hide();
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to cancel this transaction?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();

                    String query = "DELETE FROM client_transaction WHERE id = " + int.Parse(tIDtxt.Text) +"";
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();

                    conn.Close();
                }
                MessageBox.Show("Transaction has been added", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RifreeeshReserved();

                tIDtxt.Text = "";
                amtTxt.Text = "";

                viewBtn.Enabled = false;
                cancelBtn.Enabled = false;

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }
    }
}
