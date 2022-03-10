using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crystal_work_1a
{
    public partial class FormCustomerContact : Form
    {
        public FormCustomerContact()
        {
            InitializeComponent();
        }

        private void FormCustomerContact_Load(object sender, EventArgs e)
        {
            //1
            CutomerContact rpt = new CutomerContact();
            
            //2
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers", ConfigurationManager.ConnectionStrings["nwcs"].ConnectionString);
            da.Fill(ds, "Customers");
            rpt.SetDataSource(ds);
            //3
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Refresh();
        }
    }
}
