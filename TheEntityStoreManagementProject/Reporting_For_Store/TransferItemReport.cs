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
    public partial class TransferItemReport : Form
    {
        public TransferItemReport()
        {
            InitializeComponent();
        }

        private void TransferItemReport_Load(object sender, EventArgs e)
        {
            using (InventoryEntities imodel = new InventoryEntities())
            {
                listTransferResultBindingSource.DataSource = imodel.ListTransfer();
            }
        }
    }
}
