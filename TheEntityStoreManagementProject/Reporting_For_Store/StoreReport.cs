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
    public partial class StoreReport : Form
    {
        public StoreReport()
        {
            InitializeComponent();
        }

        private void StoreReport_Load(object sender, EventArgs e)
        {
            using (InventoryEntities smodel = new InventoryEntities())
            {
                forStoreResultBindingSource.DataSource = smodel.ForStore();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ForStore_Result> list = forStoreResultBindingSource.DataSource as List<ForStore_Result>;

           
                using (TheStoreReportViewer viewer = new TheStoreReportViewer(list))
                {
                    
                    viewer.ShowDialog();
                   
                }

            }
            

        }
    }

