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
    public partial class TransBranch : Form
    {
        public DataGridViewButtonColumn ref_trans { get; set; }
        public MySqlConnection conn;
        public TransBranch()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=dcgwaps; Uid=root; Pwd=root; SslMode=none");
        }
        public void combo_branch()
        {
            string branchquery = "SELECT DISTINCT(name) FROM branch WHERE id <> '"+ Branch.selected_branch_id +"';";
            MySqlCommand branchcom = new MySqlCommand(branchquery, conn);
            try
            {
                conn.Open();
                MySqlDataReader myReader = branchcom.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    br_ID.Items.Add(name);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        private void Confirm_Click(object sender, EventArgs e)
        {
        string startDate = startDTP.Value.ToString("yyyy-MM-dd");
        string endDate = endDTP.Value.ToString("yyyy-MM-dd");
        conn.Open();

        string query = "UPDATE employee SET branch_id = (SELECT id FROM BRANCH WHERE name = '" + br_ID.Text + "' ) WHERE id = " + emp_id + " ";
        MySqlCommand comm = new MySqlCommand(query, conn);
        comm.ExecuteNonQuery();

        String transferQuery = "INSERT INTO EMPLOYEE_TRANSFER(EMP_ID, BRANCH_ID, DATE_FROM, DATE_TO) VALUES " +
                                   "( " + emp_id + ", (SELECT id FROM BRANCH WHERE name = '" + br_ID.Text + "' ), '" + startDate + "', '" + endDate + "')";
        MySqlCommand transferQueryComm = new MySqlCommand(transferQuery, conn);
        transferQueryComm.ExecuteNonQuery();



        conn.Close();
        this.Close();
        }
        int emp_id;
        public void fetch_employee_id_method(int x)
        {
            emp_id = x;
        }

        private void TransBranch_Load(object sender, EventArgs e)
        {
            combo_branch();
            //checkTransfer();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
