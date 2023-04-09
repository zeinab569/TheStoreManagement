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
    public partial class ProductsReport : Form
    {
        public ProductsReport()
        {
            InitializeComponent();
        }

        private void ProductsReport_Load(object sender, EventArgs e)
        {
            using (InventoryEntities imodel = new InventoryEntities())
            {
                forItemResultBindingSource.DataSource = imodel.ForItem();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ForItem_Result> list = forItemResultBindingSource.DataSource as List<ForItem_Result>;


            using (Productreportviewer viewer = new Productreportviewer(list))
            {
                viewer.ShowDialog();
            }

        }
    }
    }

