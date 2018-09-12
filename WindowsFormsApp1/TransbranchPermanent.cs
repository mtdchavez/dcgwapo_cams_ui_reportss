using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TransbranchPermanent : Form
    {
        public MySqlConnection conn;
        public TransbranchPermanent()
        {
            InitializeComponent();
        }

        private void TransbranchPermanent_Load(object sender, EventArgs e)
        {

        }
        public void combo_branch()
        {
            string branchquery = "SELECT DISTINCT(name) FROM branchWHERE id <> '" + Branch.selected_branch_id + "';";
            MySqlCommand branchcom = new MySqlCommand(branchquery, conn);
            try
            {
                conn.Open();
                MySqlDataReader myReader = branchcom.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    branchID.Items.Add(name);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        int emp_id;
        public void fetch_employee_id_method(int x)
        {
            emp_id = x;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            conn.Open();

            String query = "UPDATE employee SET branch_id = (SELECT id FROM BRANCH WHERE name = '" + branchID.Text + "' ) WHERE id = " + emp_id + " ";
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();

            conn.Close();
            this.Close();
        }
    }
}
