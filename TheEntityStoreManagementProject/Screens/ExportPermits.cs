using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheEntityStoreManagementProject.Screens
{
    public partial class ExportPermits : Form
    {
        InventoryEntities exportmodel = new InventoryEntities();

        public ExportPermits()
        {
            InitializeComponent();
        }

        
        private void ExportPermits_Load(object sender, EventArgs e)
        {
            foreach (store s in exportmodel.stores)
            {
                comboBoxstore.Items.Add(s.id);
            }
            foreach (supplier sp in exportmodel.suppliers)
            {
                comboBoxsupname.Items.Add(sp.name);
            }
            foreach (item it in exportmodel.items)
            {
                comboBoxitem.Items.Add(it.id);
            }
        }

        //Display All
        private void btndisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (InventoryEntities xmodel = new InventoryEntities())
            {
                listExportResultBindingSource.DataSource = xmodel.ListExport();
            }

            foreach (ExchangePermit i in exportmodel.ExchangePermits)
            {
                listBox1.Items.Add(i.permit_number);
            }
        }

        //Add Export 
        private void btnadd_Click(object sender, EventArgs e)
        {
            ExchangePermit ip1 = new ExchangePermit();
            ExchangePermit ip2 = exportmodel.ExchangePermits.Find(int.Parse(txtid.Text));
            supplier s = new supplier();
            s.name = comboBoxsupname.Text;

            var allowed = (from s1 in exportmodel.suppliers
                           where s1.name == s.name
                           select s1.id).FirstOrDefault();

            if (ip2 == null)
            {
                if (txtid.Text != null && comboBoxitem.Text != null && txtpernitnum.Text != null && comboBoxsupname.Text != null && txtquantity.Text != null)
                {
                    ip1.permit_id = int.Parse(txtid.Text);
                    ip1.store_id = int.Parse(comboBoxstore.Text);
                    ip1.permit_number = txtpernitnum.Text;
                    ip1.supplier_id = allowed;
                    ip1.permit_date = permitdate.Value;
                    ip1.item_id = int.Parse(comboBoxitem.Text);
                    ip1.quantity = int.Parse(txtquantity.Text);

                    exportmodel.ExchangePermits.Add(ip1);
                    exportmodel.SaveChanges();
                    MessageBox.Show("added successfully ^_^");
                    listBox1.Items.Add(int.Parse(txtpernitnum.Text));
                    txtid.Text = txtpernitnum.Text = comboBoxitem.Text =
                    comboBoxstore.Text = comboBoxsupname.Text = txtquantity.Text = " ";
                }
                else
                {
                    MessageBox.Show("please enter All values to Add");
                }
            }
            else
            {
                MessageBox.Show("already Exist");
            }
        }

        //update Export
        private void btnupdate_Click(object sender, EventArgs e)
        {
            supplier s = new supplier();
            s.name = comboBoxsupname.Text;

            var allowed = (from s1 in exportmodel.suppliers
                           where s1.name == s.name
                           select s1.id).FirstOrDefault();

            ExchangePermit ip1 = exportmodel.ExchangePermits.Find(int.Parse(txtid.Text));
            if (ip1 != null)
            {
                if (txtid.Text != null && comboBoxitem.Text != null && txtpernitnum.Text != null && comboBoxsupname.Text != null && txtquantity.Text != null)
                {

                    ip1.store_id = int.Parse(comboBoxstore.Text);
                    ip1.permit_number = txtpernitnum.Text;
                    ip1.supplier_id = allowed;
                    ip1.permit_date = permitdate.Value;
                    ip1.item_id = int.Parse(comboBoxitem.Text);
                    ip1.quantity = int.Parse(txtquantity.Text);
                    exportmodel.SaveChanges();
                    MessageBox.Show("updated successfully ^_^");
                    listBox1.Items.Add(int.Parse(txtpernitnum.Text));
                    txtid.Text = txtpernitnum.Text = comboBoxitem.Text =
                    comboBoxstore.Text = comboBoxsupname.Text = txtquantity.Text = " ";
                }
                else
                {
                    MessageBox.Show("please enter All values to Add");
                }
            }
            else
            {
                MessageBox.Show("not found to update");
            }

        }

        //delete
        private void btndelete_Click(object sender, EventArgs e)
        {
            ExchangePermit ip1 = exportmodel.ExchangePermits.Find(int.Parse(txtid.Text));
            if (ip1 != null)
            {
                exportmodel.ExchangePermits.Remove(ip1);
                exportmodel.SaveChanges();
                MessageBox.Show("Deleted successfuly ^_^");
                txtid.Text = txtpernitnum.Text = comboBoxitem.Text =
                    comboBoxstore.Text = comboBoxsupname.Text = txtquantity.Text = " ";
            }
            else
            {
                MessageBox.Show("not found to delete");
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
