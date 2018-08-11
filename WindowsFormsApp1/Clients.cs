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
    public partial class Clients : Form
    {
        public MySqlConnection conn;
        public ClientTransaction ref_clienttrans { get; set; }
        public Clients()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none;");
        }

        public void Rifreeesh()
        {
            try
            {
                conn.Open();
                String query = "CALL selClient()";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                clientGrid.DataSource = dt;
                clientGrid.Columns["id"].Visible = false;
                clientGrid.Columns["name"].HeaderText = "Client";
                clientGrid.Columns["address"].HeaderText = "Address";
                clientGrid.Columns["birthday"].HeaderText = "Birthday";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            Rifreeesh();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTxt.Text == String.Empty || addressTxt.Text == String.Empty)
                {
                    MessageBox.Show("Please input required field.");
                }
                else
                {
                    //CHECK THE DUPLICATION                
                    int getValidation = 0;
                    int convertedValidation = 0;

                    conn.Open();
                    MySqlCommand EmpValidation = new MySqlCommand("SELECT COUNT(*) FROM client WHERE name = '" + nameTxt.Text + "' AND address = '" + addressTxt.Text + "' AND BIRTHDAY = '" + birthday.Text + "'", conn);
                    convertedValidation = Convert.ToInt32(EmpValidation.ExecuteScalar());
                    getValidation = convertedValidation;
                    conn.Close();

                    if (getValidation > 0)
                    {
                        MessageBox.Show(nameTxt.Text + " " + addressTxt.Text + " is already in the system");
                    }
                    else if (getValidation <= 0)
                    {
                        if (MessageBox.Show("Do you want to add the data?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            conn.Open();

                            String query = "INSERT INTO client VALUES (NULL, '" + nameTxt.Text+ "', '" + addressTxt.Text + "', '" + this.birthday.Text + "')";
                            MySqlCommand comm = new MySqlCommand(query, conn);
                            comm.ExecuteNonQuery();

                            conn.Close();
                        }
                        MessageBox.Show("New client has been added successfully", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Rifreeesh();
                    }
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void clientGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String c_id, name, address, bday;

            c_id = clientGrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
            name = clientGrid.Rows[e.RowIndex].Cells["name"].Value.ToString();
            address = clientGrid.Rows[e.RowIndex].Cells["address"].Value.ToString();
            bday = clientGrid.Rows[e.RowIndex].Cells["birthday"].Value.ToString();

            IDlabel.Text = c_id;
            nameTxt.Text = name;
            addressTxt.Text = address;
            birthday.Text = bday;
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTxt.Text == String.Empty || addressTxt.Text == String.Empty || birthday.Text == String.Empty)
                {
                    MessageBox.Show("Please input required field.");
                }
                else
                {
                    if (MessageBox.Show("Do you want to update the data?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();

                        String query = "UPDATE client SET name = '" + nameTxt.Text + "', address = '" + addressTxt.Text + "',  birthday = '" + this.birthday.Text + "' WHERE id = '" + IDlabel.Text + "'";
                        MySqlCommand comm = new MySqlCommand(query, conn);
                        comm.ExecuteNonQuery();

                        conn.Close();
                    }
                    MessageBox.Show("Branch data has been updated successfully", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Rifreeesh();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            ref_clienttrans.Show();
        }
    }

}
