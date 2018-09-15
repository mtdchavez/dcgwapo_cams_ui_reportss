﻿using System;
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
    public partial class Service : Form
    {
        public Dashadmin ref_dashadmin { get; set; }
        public MySqlConnection conn;

        public Service()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none");
        }
        public void Rifreeesh()
        {
            try
            {
                conn.Open();
                String query = "SELECT * FROM service";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["branch_id"].Visible = false;
                dataGridView1.Columns["name"].HeaderText = "Service";
                dataGridView1.Columns["description"].HeaderText = "Description";
                dataGridView1.Columns["price"].HeaderText = "Price";
                dataGridView1.Columns["status"].HeaderText = "Status";

                activeBtn.Enabled = false;
                inactBtn.Enabled = false;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void Service_Load(object sender, EventArgs e)
        {
            Rifreeesh();
        }

        private void addbranch_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Dashadmin admin = new Dashadmin();
            admin.ref_service = this;
            admin.Show();
            this.Close();

        }

        private void activeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                status("Active");
                Rifreeesh();
                activeBtn.Enabled = false;
                inactBtn.Enabled = true;
                MessageBox.Show("The service will be available for that branch");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void inactBtn_Click(object sender, EventArgs e)
        {
            try
            {
                status("Inactive");
                Rifreeesh();
                activeBtn.Enabled = true;
                inactBtn.Enabled = false;
                MessageBox.Show("The service will not be available for that branch");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void status(String x)
        {
            try
            {
                conn.Open();
                String query = "UPDATE service SET status = '" + x + "' WHERE id = '" + seridtext.Text + "'";
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        public static int selected_branch_id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id, name, description, price, status;

            id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            name = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            description = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
            price = dataGridView1.Rows[e.RowIndex].Cells["price"].Value.ToString();
            status = dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString();

            seridtext.Text = id;
            serv_name.Text = name;
            desc.Text = description;
            prc.Text = price;

            if (status == "Active")
            {
                activeBtn.Enabled = false;
                inactBtn.Enabled = true;
            }
            else
            {
                activeBtn.Enabled = true;
                inactBtn.Enabled = false;
            }



        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashadmin admin = new Dashadmin();
            admin.ref_service = this;
            admin.Show();
            this.Close();
        }
    }
}
