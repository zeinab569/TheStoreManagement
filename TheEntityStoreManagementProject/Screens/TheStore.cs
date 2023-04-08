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
    public partial class TheStore : Form
    {
        InventoryEntities storemodel = new InventoryEntities();
        public TheStore()
        {
            InitializeComponent();
        }

        //Display All
        private void btndisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            foreach (store s in storemodel.stores)
            {
                comboBox1.Items.Add(s.id);
                listBox1.Items.Add(s.name);
            }
        }

        //Add Stor
        private void btnadd_Click(object sender, EventArgs e)
        {
            store s1 = new store();
            store s2 = storemodel.stores.Find(int.Parse(txtid.Text));
            if (s2 == null)
            {
                s1.id = int.Parse(txtid.Text);
                s1.name = txtname.Text;
                s1.manager_name = txtmnane.Text;
                s1.manager_email = txtemail.Text;
                s1.manager_phone = txtmphone.Text;
                s1.address = txtaddress.Text;
                storemodel.stores.Add(s1);
                storemodel.SaveChanges();
                comboBox1.Items.Add(txtid.Text);
                listBox1.Items.Add(txtname.Text);
                MessageBox.Show("added successfuly ^_^");
                txtid.Text = txtname.Text = txtmnane.Text = txtmphone.Text = txtemail.Text = txtaddress.Text = " ";

            }
            else
            {
                MessageBox.Show("already exist ");
            }
        }

        //update store
        private void btnupdate_Click(object sender, EventArgs e)
        {
            store s2 = storemodel.stores.Find(int.Parse(txtid.Text));
            if (s2 != null)
            {
                if (txtaddress.Text != null && txtemail.Text != null && txtmnane.Text != null && txtmphone.Text != null && txtname.Text != null)
                {
                    s2.manager_email = txtemail.Text;
                    s2.name = txtname.Text;
                    s2.address = txtaddress.Text;
                    s2.manager_phone = txtmphone.Text;
                    s2.manager_name = txtmnane.Text;
                    MessageBox.Show("Are You sure");
                    storemodel.SaveChanges();
                    MessageBox.Show("updated succfully ^_^");
                    txtid.Text = txtname.Text = txtmnane.Text = txtmphone.Text = txtemail.Text = txtaddress.Text = " ";
                }
                else
                {
                    MessageBox.Show("please enter data to update");
                }
            }
            else
            {
                MessageBox.Show("Not found this store to update");
            }
        }

        //delete store
        private void btndelete_Click(object sender, EventArgs e)
        {
            store s2 = storemodel.stores.Find(int.Parse(txtid.Text));
            if (s2 != null)
            {
                MessageBox.Show("Are You sure");
                storemodel.stores.Remove(s2);
                storemodel.SaveChanges();
                MessageBox.Show("Deleted successfuly ^_^");
                comboBox1.Items.Remove(txtid.Text);
                listBox1.Items.Remove(txtid.Text);
                txtid.Text = txtname.Text = txtmnane.Text = txtmphone.Text = txtemail.Text = txtaddress.Text = " ";
            }
            else
            {
                MessageBox.Show("not found this store to delete");
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
