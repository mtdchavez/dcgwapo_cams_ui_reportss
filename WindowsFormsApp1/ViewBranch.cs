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
    public partial class ViewBranch : Form
    {
        public DataGridViewButtonColumn ref_branch1 { get; set; }
        public MySqlConnection conn;
        public ViewBranch()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none");
        }
        public void loadSelectedBranch()
        {
            conn.Open();
            string query = "SELECT id, FNAME, LNAME, position FROM  employee where branch_id = " + Branch.selected_branch_id + " AND POSITION <> 'Admin' AND POSITION <> 'Cashier';";
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            viewBranchDGV.DataSource = dt;
            viewBranchDGV.Columns["id"].HeaderText = "id";
            viewBranchDGV.Columns["FNAME"].HeaderText = "Firstname";
            viewBranchDGV.Columns["LNAME"].HeaderText = "Lastname";
            viewBranchDGV.Columns["POSITION"].HeaderText = "Role";
        }

        private void viewBranchDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (MessageBox.Show("Are you sure you want to transfer this employee?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here 
                    TransBranch trans = new TransBranch();
                    trans.fetch_employee_id_method(int.Parse(viewBranchDGV.Rows[viewBranchDGV.CurrentRow.Index].Cells[0].Value.ToString()));
                    //viiew.ref_branch1 = this;
                    trans.ShowDialog();
                    loadSelectedBranch();
                }
            }
        }

        private void ViewBranch_Load(object sender, EventArgs e)
        {
            loadSelectedBranch();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            viewBranchDGV.Columns.Add(btn);
            btn.HeaderText = "Action";
            btn.Text = "Transfer";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            branchCmb.Text = Branch.selected_name;
            cityTxt.Text = Branch.selected_city;
            locationTxt.Text = Branch.selected_location;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
