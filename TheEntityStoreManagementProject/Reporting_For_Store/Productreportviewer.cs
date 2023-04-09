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
    public partial class Productreportviewer : Form
    {
        List<ForItem_Result> list;

        public Productreportviewer(List<ForItem_Result> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void Productreportviewer_Load(object sender, EventArgs e)
        {
            forItemResultBindingSource.DataSource = list;
            this.reportViewer1.RefreshReport();
        }
    }
}
