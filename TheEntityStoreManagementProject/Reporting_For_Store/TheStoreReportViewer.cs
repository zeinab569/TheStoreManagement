using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheEntityStoreManagementProject.Reporting_For_Store
{
    public partial class TheStoreReportViewer : Form
    {
        List<ForStore_Result> list;

        public TheStoreReportViewer(List<ForStore_Result> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void TheStoreReportViewer_Load(object sender, EventArgs e)
        {

            forStoreResultBindingSource.DataSource = list;
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
