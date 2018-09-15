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
    public partial class Payment : Form
    {
        public MySqlConnection conn;
        public ServiceDetail reftrans { get; set; }
       
        public Payment()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none;");
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (payamtTxt.Text == String.Empty)
                {
                    MessageBox.Show("Enter payment amount");
                }
                else
                {
                    if (MessageBox.Show("Are you sure will undergo the payment?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();

                        String query1 = "INSERT INTO payment (client_transaction_id, total_amount, pay_amount, payment_date) VALUES (" + int.Parse(tIDlabel.Text) + ", " + double.Parse(amtLabel.Text) + ", " + double.Parse(payamtTxt.Text) + ", NOW())";
                        String query2 = "UPDATE client_transaction SET status = 'Paid' WHERE id = " + int.Parse(tIDlabel.Text) + "";
                        //String query3 = "INSERT INTO branch_sale VALUES ("
                        MySqlCommand comm1 = new MySqlCommand(query1, conn);
                        MySqlCommand comm2 = new MySqlCommand(query2, conn);
                        comm1.ExecuteNonQuery();
                        comm2.ExecuteNonQuery();

                        decimal change = decimal.Parse(Change.Text.ToString()) - decimal.Parse(amtLabel.Text.ToString());
                        Change.Text = change.ToString("#,0.00");
            
                        if (decimal.Parse(payamtTxt.Text.ToString()) < decimal.Parse(amtLabel.Text.ToString()))
                        {
                            MessageBox.Show("Cannot proceed to payment because your payment is short!");
                            payamtTxt.Text = "0";
                            Change.Clear();
                        }

                        MessageBox.Show("Payment has been successful, Your change is " + change, "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                    ClientTransaction trans = new ClientTransaction();
                    trans.ref_pay = this;
                    trans.Show();
                    this.Hide();

                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }


        }

        private void Payment_Load(object sender, EventArgs e)
        {
            tIDlabel.Text = String.Concat(ServiceDetail.selected_trans_id);
            amtLabel.Text = String.Concat(ServiceDetail.selected_amt);
            Console.Write(amtLabel.Text);

        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            reftrans.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payamtTxt_TextChanged(object sender, EventArgs e)
        {
            if (payamtTxt.Text == "")
            {
                Change.Text = "0";
            }
            else
            {
                decimal change = decimal.Parse(payamtTxt.Text.ToString()) - decimal.Parse(amtLabel.Text.ToString());
                Change.Text = change.ToString("#,0.00");
            }
        }

        private void payamtTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers!", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                payamtTxt.Text = "0";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
