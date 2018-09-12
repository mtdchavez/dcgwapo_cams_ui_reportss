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
    public partial class BranchSale : Form
    {
        public Dashcashier ref_dashcashier { get; set; }
        public MySqlConnection conn;
        public BranchSale()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none;");
        }

        private void genSale_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (MessageBox.Show("Do you want to add the data?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();

                        String query = "CALL addBranchSale(" + GlobalVariables.User_Branch_ID + ");";
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

        public void Rifreeesh()
        {
            try
            {
                conn.Open();
                String query = "SELECT id, branch_id, CONCAT('Php ', sale), sale_date FROM branch_sale WHERE branch_id = " + GlobalVariables.User_Branch_ID + "";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                branchSaleGrid.DataSource = dt;
                branchSaleGrid.Columns["id"].Visible = false;
                branchSaleGrid.Columns["branch_id"].Visible = false;
                branchSaleGrid.Columns["CONCAT('Php ', sale)"].HeaderText = "Sale";
                branchSaleGrid.Columns["sale_date"].HeaderText = "Date";

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashcashier cashier = new Dashcashier();
            cashier.ref_sale = this;
            cashier.Show();
            this.Close();
        }

        private void BranchSale_Load(object sender, EventArgs e)
        {
            Rifreeesh();
        }
    }
}
