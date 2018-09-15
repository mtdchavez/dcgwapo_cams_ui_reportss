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
    public partial class OverallBranchSale : Form
    {
        public MySqlConnection conn;
        public Dashadmin ref_dashadmin { get; set; }

        public OverallBranchSale()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none;");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashadmin admin = new Dashadmin();
            admin.ref_sales = this;
            admin.Show();
            this.Close();
        }

        private void OverallBranchSale_Load(object sender, EventArgs e)
        {
            fillcombo_branch();
        }

        public void fillcombo_branch()
        {
            String branchquery = "SELECT name FROM branch";
            MySqlCommand branchcomm = new MySqlCommand(branchquery, conn);

            try
            {
                conn.Open();
                MySqlDataReader myReader = branchcomm.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    branchCombo.Items.Add(name);
                }
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int brIDInt = branchCombo.SelectedIndex + 1;

            try
            {
                conn.Open();
                String query = "SELECT id, branch_id, SUM(sale), CONCAT(monthname(sale_date), ' ', year(sale_date)) FROM branch_sale WHERE branch_id = " + brIDInt + " group by monthname(sale_date)";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                branchSaleGrid.DataSource = dt;
                branchSaleGrid.Columns["id"].Visible = false;
                branchSaleGrid.Columns["branch_id"].Visible = false;
                branchSaleGrid.Columns["SUM(sale)"].HeaderText = "Monthly Sales";
                branchSaleGrid.Columns["CONCAT(monthname(sale_date), ' ', year(sale_date))"].HeaderText = "Date";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }
    }
}
