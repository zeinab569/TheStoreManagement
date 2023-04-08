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
    public partial class AlreadyExpire : Form
    {
        public AlreadyExpire()
        {
            InitializeComponent();
        }

        private void btnCloseTExpire_Click(object sender, EventArgs e)
        {
            var x = dateTimePicker1.Value;
            using (InventoryEntities almodel = new InventoryEntities())
            {
                alreadyExpireResultBindingSource.DataSource = almodel.alreadyExpire(x);
            }
        }

        private void AlreadyExpire_Load(object sender, EventArgs e)
        {

        }
    }
}
