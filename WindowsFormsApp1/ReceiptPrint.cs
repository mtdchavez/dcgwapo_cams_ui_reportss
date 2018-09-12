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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace WindowsFormsApp1
{
    public partial class ReceiptPrint : Form
    {
        public ClientTransaction ref_dashadmin { get; set; }
        public MySqlConnection conn;
        public ReceiptPrint()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none");
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ReceiptPrint_Load(object sender, EventArgs e)
        {
            string s = System.IO.Directory.GetCurrentDirectory().ToString();


            int x = s.IndexOf("bin\\Debug");
            if (x != -1)
            {
                s = s.Remove(x);
            }
            s += "ReceiptPrintReports.rpt";
            crystalReportViewer1.Visible = true;
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@s);
            cryRpt.Refresh();
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
