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
    public partial class Suppliers : Form
    {
        InventoryEntities supmodel = new InventoryEntities();
        public Suppliers()
        {
            InitializeComponent();
        }
        //Display All
        private void btndisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            foreach (supplier s in supmodel.suppliers)
            {
                comboBox1.Items.Add(s.id);
                listBox1.Items.Add(s.name);
            }
        }

        //Add supplier
        private void btnadd_Click(object sender, EventArgs e)
        {
            supplier s1 = new supplier();
            supplier s2 = supmodel.suppliers.Find(int.Parse(txtid.Text));
            if (s2 == null)
            {
                s1.id = int.Parse(txtid.Text);
                s1.email = txtemail.Text;
                s1.phone = txtphone.Text;
                s1.name = txtname.Text;
                s1.fax = txtfax.Text;
                s1.website = txtwebsite.Text;
                s1.mobile = txtmobile.Text;
                supmodel.suppliers.Add(s1);
                supmodel.SaveChanges();
                MessageBox.Show("added successfuly ^_^");
                comboBox1.Items.Add(int.Parse(txtid.Text));
                listBox1.Items.Add(txtname.Text);
                txtid.Text = txtname.Text = txtemail.Text = txtphone.Text = txtwebsite.Text = txtmobile.Text = txtfax.Text = " ";

            }
            else
            {
                MessageBox.Show("this supplier exidting already");
            }
        }

        //update supplier
        private void btnupdate_Click(object sender, EventArgs e)
        {
            supplier s1 = supmodel.suppliers.Find(int.Parse(txtid.Text));
            if (s1 != null)
            {
                if (txtname != null && txtphone != null && txtfax != null && txtmobile != null && txtwebsite != null && txtemail != null)
                {
                    s1.email = txtemail.Text;
                    s1.phone = txtphone.Text;
                    s1.name = txtname.Text;
                    s1.fax = txtfax.Text;
                    s1.website = txtwebsite.Text;
                    supmodel.SaveChanges();
                    comboBox1.Items.Add(txtid.Text);
                    listBox1.Items.Add(txtname.Text);
                    MessageBox.Show("added successfuly ^_^");
                    txtid.Text = txtname.Text = txtemail.Text = txtphone.Text = txtwebsite.Text = txtmobile.Text = txtfax.Text = " ";
                }
                else
                {
                    MessageBox.Show("please enter valid data");
                }
            }
            else
            {
                MessageBox.Show("not found this supplier to update");
            }
        }

        //delete supplier
        private void btndelete_Click(object sender, EventArgs e)
        {
            supplier s1 = supmodel.suppliers.Find(int.Parse(txtid.Text));
            if (s1 != null)
            {
                //ImportPermit ip = new ImportPermit();
                //ip.supplier_id=int.Parse(txtid.Text);

                //supmodel.ImportPermits.Remove(ip);
                //supmodel.SaveChanges();
                supmodel.suppliers.Remove(s1);
                supmodel.SaveChanges();
                comboBox1.Items.Remove(txtid.Text);
                listBox1.Items.Remove(txtid.Text);
                MessageBox.Show("Deleted successfuly ^_^");
                txtid.Text = txtname.Text = txtemail.Text = txtphone.Text = txtwebsite.Text = txtmobile.Text = txtfax.Text = " ";
            }
            else
            {
                MessageBox.Show("notfound this supplier to delete");
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
