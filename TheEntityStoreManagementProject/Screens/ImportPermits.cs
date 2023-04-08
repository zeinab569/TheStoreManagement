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
    public partial class ImportPermits : Form
    {
        InventoryEntities importmodel = new InventoryEntities();
        public ImportPermits()
        {
            InitializeComponent();
        }

        
        private void ImportPermits_Load(object sender, EventArgs e)
        {
            foreach (store s in importmodel.stores)
            {
                comboBoxstore.Items.Add(s.id);
            }
            foreach (supplier sp in importmodel.suppliers)
            {
                comboBoxsupname.Items.Add(sp.name);
            }
            foreach (item it in importmodel.items)
            {
                comboBoxitem.Items.Add(it.id);
            }
        }

        //display All
        private void btndisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (InventoryEntities imodel = new InventoryEntities())
            {
                listImportResultBindingSource.DataSource = imodel.ListImport();
            }
            foreach (ImportPermit i in importmodel.ImportPermits)
            {
                listBox1.Items.Add(i.permit_number);

            }
        }

        //Add Importpermits
        private void btnadd_Click(object sender, EventArgs e)
        {
            ImportPermit ip1 = new ImportPermit();
            ImportPermit ip2 = importmodel.ImportPermits.Find(int.Parse(txtid.Text));
            supplier s = new supplier();
            s.name = comboBoxsupname.Text;

            var allowed = (from s1 in importmodel.suppliers
                           where s1.name == s.name
                           select s1.id).FirstOrDefault();

            if (ip2 == null)
            {
                if (txtid.Text != null && comboBoxitem.Text != null && txtpernitnum.Text != null && comboBoxsupname.Text != null && txtquantity.Text != null && txtvalid.Text != null)
                {
                    ip1.permit_id = int.Parse(txtid.Text);
                    ip1.store_id = int.Parse(comboBoxstore.Text);
                    ip1.permit_number = txtpernitnum.Text;
                    ip1.supplier_id = allowed;
                    ip1.production_date = productiondate.Value;
                    ip1.permit_date = permitdate.Value;
                    ip1.item_id = int.Parse(comboBoxitem.Text);
                    ip1.quantity = int.Parse(txtquantity.Text);
                    ip1.validity_period = int.Parse(txtvalid.Text);

                    importmodel.ImportPermits.Add(ip1);
                    importmodel.SaveChanges();
                    MessageBox.Show("added successfully ^_^");
                    listBox1.Items.Add(int.Parse(txtpernitnum.Text));
                    txtid.Text = txtpernitnum.Text = txtvalid.Text = comboBoxitem.Text =
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

        //update
        private void btnupdate_Click(object sender, EventArgs e)
        {
            supplier s = new supplier();
            s.name = comboBoxsupname.Text;

            var allowed = (from s1 in importmodel.suppliers
                           where s1.name == s.name
                           select s1.id).FirstOrDefault();

            if (txtid.Text != null)
            {
                ImportPermit ip1 = importmodel.ImportPermits.Find(int.Parse(txtid.Text));

                if (ip1 != null)
                {
                    if (txtid.Text != null && comboBoxitem.Text != null && txtpernitnum.Text != null && comboBoxsupname.Text != null && txtquantity.Text != null && txtvalid.Text != null)
                    {
                        ip1.store_id = int.Parse(comboBoxstore.Text);
                        ip1.permit_number = txtpernitnum.Text;
                        ip1.supplier_id = allowed;
                        ip1.production_date = productiondate.Value;
                        ip1.permit_date = permitdate.Value;
                        ip1.item_id = int.Parse(comboBoxitem.Text);
                        ip1.quantity = int.Parse(txtquantity.Text);
                        ip1.validity_period = int.Parse(txtvalid.Text);
                        importmodel.SaveChanges();
                        MessageBox.Show("updated successfully ^_^");
                        txtid.Text = txtpernitnum.Text = txtvalid.Text = comboBoxitem.Text =
                        comboBoxstore.Text = comboBoxsupname.Text = txtquantity.Text = " ";
                    }
                    else
                    {
                        MessageBox.Show("please Enter All values to update");
                    }
                }
                else
                {
                    MessageBox.Show("not found to update ");
                }
            }
            else
            {
                MessageBox.Show("enter id to update");
            }


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ImportPermit ip2 = importmodel.ImportPermits.Find(int.Parse(txtid.Text));
            if (ip2 != null)
            {
                importmodel.ImportPermits.Remove(ip2);
                importmodel.SaveChanges();
                MessageBox.Show("Deleted successfuly ^_^");
                txtid.Text = txtpernitnum.Text = txtvalid.Text = comboBoxitem.Text =
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

        //fill data for item in textbox
        private void comboBoxitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iditem = int.Parse(comboBoxitem.Text);
            item i = importmodel.items.Find(iditem);
            if (i != null)
            {
                var x = (i.production_date.Value);
                var y = (i.expire_date.Value);
                var z = y - x;
                productiondate.Value = x;
                txtvalid.Text = z.ToString();
            }
        }
    }
}
