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
    public partial class CloseToExpire : Form
    {
        public CloseToExpire()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCloseTExpire_Click(object sender, EventArgs e)
        {
            var x = dateTimePicker1.Value;
            using (InventoryEntities closemodel = new InventoryEntities())
            {
                closeToExpireResultBindingSource.DataSource = closemodel.CloseToExpire(x);
            }
        }
    }
}
