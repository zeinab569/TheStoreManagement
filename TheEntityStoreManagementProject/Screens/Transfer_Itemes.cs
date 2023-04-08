using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TheEntityStoreManagementProject.Screens
{
    public partial class Transfer_Itemes : Form
    {
        InventoryEntities transfertmodel = new InventoryEntities();
        public Transfer_Itemes()
        {
            InitializeComponent();
        }


        private void Transfer_Itemes_Load(object sender, EventArgs e)
        {
            foreach (store s in transfertmodel.stores)
            {
                comboBoxfromstore.Items.Add(s.id);
                comboBoxtostore.Items.Add(s.id);
            }
            foreach (supplier sp in transfertmodel.suppliers)
            {
                comboBoxsupname.Items.Add(sp.name);
            }
            foreach (item it in transfertmodel.items)
            {
                comboBoxitem.Items.Add(it.id);
            }
        }


        //Display All
        private void btndisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (InventoryEntities imodel = new InventoryEntities())
            {
                listTransferResultBindingSource.DataSource = imodel.ListTransfer();
            }
            foreach (TransferItem i in transfertmodel.TransferItems)
            {
                listBox1.Items.Add(i.id);

            }
        }

        //Add Transfer Item
        private void btnadd_Click(object sender, EventArgs e)
        {
            TransferItem item1 = new TransferItem();
            TransferItem item2 = transfertmodel.TransferItems.Find(int.Parse(txtid.Text));
            supplier s = new supplier();
            s.name = comboBoxsupname.Text;

            var allowed = (from s1 in transfertmodel.suppliers
                           where s1.name == s.name
                           select s1.id).FirstOrDefault();
            if (item2 == null)
            {
                if (txtid.Text != null && comboBoxitem.Text != null && comboBoxsupname.Text != null && txtquantity.Text != null && txtvalid.Text != null)
                {
                    item1.id = int.Parse(txtid.Text);
                    item1.from_store_id = int.Parse(comboBoxfromstore.Text);
                    item1.to_store_id = int.Parse(comboBoxtostore.Text);
                    item1.supplierid = allowed;
                    item1.item_id = int.Parse(comboBoxitem.Text);
                    item1.production_date = productiondate.Value;
                    item1.validity_period = int.Parse(txtvalid.Text);
                    item1.quantity = int.Parse(txtquantity.Text);
                    transfertmodel.TransferItems.Add(item1);
                    transfertmodel.SaveChanges();
                    MessageBox.Show("added successfully ^_^");
                    listBox1.Items.Add(int.Parse(txtid.Text));
                    txtid.Text = txtvalid.Text = comboBoxitem.Text = comboBoxtostore.Text =
                    comboBoxfromstore.Text = comboBoxsupname.Text = txtquantity.Text = " ";
                }
            }
            else
            {
                MessageBox.Show("already Exist");
            }
        }


        private void comboBoxitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iditem = int.Parse(comboBoxitem.Text);
            item i = transfertmodel.items.Find(iditem);
            if (i != null)
            {
                var x = (i.production_date.Value);
                var y = (i.expire_date.Value);
                var z = y - x;
                productiondate.Value = x;
                txtvalid.Text = z.ToString();



            }
        }

        //update transfer
        private void btnupdate_Click(object sender, EventArgs e)
        {
            TransferItem item1 = new TransferItem();

            supplier s = new supplier();
            s.name = comboBoxsupname.Text;

            var allowed = (from s1 in transfertmodel.suppliers
                           where s1.name == s.name
                           select s1.id).FirstOrDefault();

            if (txtid.Text != null)
            {
                TransferItem item2 = transfertmodel.TransferItems.Find(int.Parse(txtid.Text));
                if (item2 != null)
                {
                    if (txtid.Text != null && comboBoxitem.Text != null && comboBoxsupname.Text != null && txtquantity.Text != null && txtvalid.Text != null)
                    {
                        item1.id = int.Parse(txtid.Text);
                        item1.from_store_id = int.Parse(comboBoxfromstore.Text);
                        item1.to_store_id = int.Parse(comboBoxtostore.Text);
                        item1.supplierid = allowed;
                        item1.item_id = int.Parse(comboBoxitem.Text);
                        item1.production_date = productiondate.Value;
                        item1.validity_period = int.Parse(txtvalid.Text);
                        item1.quantity = int.Parse(txtquantity.Text);

                        transfertmodel.SaveChanges();
                        MessageBox.Show("updated successfully ^_^");
                        listBox1.Items.Add(int.Parse(txtid.Text));
                        txtid.Text = txtvalid.Text = comboBoxitem.Text = comboBoxtostore.Text =
                        comboBoxfromstore.Text = comboBoxsupname.Text = txtquantity.Text = " ";
                    }
                    else
                    {
                        MessageBox.Show("please Enter valid Data");
                    }
                }
                else
                {
                    MessageBox.Show("not found to update");
                }
            }
            else
            {
                MessageBox.Show("please Enter id");
            }

        }

        //delete transfer
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text != null)
            {
                TransferItem item2 = transfertmodel.TransferItems.Find(int.Parse(txtid.Text));
                if (item2 != null)
                {
                    transfertmodel.TransferItems.Remove(item2);
                    transfertmodel.SaveChanges();
                    MessageBox.Show("Deleted successfuly ^_^");
                    txtid.Text = txtvalid.Text = comboBoxitem.Text = comboBoxtostore.Text =
                        comboBoxfromstore.Text = comboBoxsupname.Text = txtquantity.Text = " ";

                }
                else
                {
                    MessageBox.Show("not found to delete ");
                }
            }
            else
            {
                MessageBox.Show("please Enter id");
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
