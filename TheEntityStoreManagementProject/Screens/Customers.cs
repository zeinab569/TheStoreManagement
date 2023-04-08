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
    public partial class Customers : Form
    {
        InventoryEntities cusmodel = new InventoryEntities();
        public Customers()
        {
            InitializeComponent();
        }

        //Display All
        private void btndisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            foreach (customer s in cusmodel.customers)
            {
                comboBox1.Items.Add(s.id);
                listBox1.Items.Add(s.name);
            }
        }

        //Add customer
        private void btnadd_Click(object sender, EventArgs e)
        {
            customer c1 = new customer();
            customer c2 = cusmodel.customers.Find(int.Parse(txtid.Text));
            if (c2 == null)
            {
                c1.id = int.Parse(txtid.Text);
                c1.email = txtemail.Text;
                c1.name = txtname.Text;
                c1.phone = txtphone.Text;
                c1.fax = txtfax.Text;
                c1.mobile = txtmobile.Text;
                c1.website = txtwebsite.Text;
                cusmodel.customers.Add(c1);
                cusmodel.SaveChanges();
                MessageBox.Show("added successfuly ^_^");
                comboBox1.Items.Add(int.Parse(txtid.Text));
                listBox1.Items.Add(txtname.Text);
                txtid.Text = txtname.Text = txtemail.Text = txtphone.Text = txtwebsite.Text = txtmobile.Text = txtfax.Text = " ";
            }
            else
            {
                MessageBox.Show("this customer exist already");
            }
        }

        //update customer
        private void btnupdate_Click(object sender, EventArgs e)
        {
            customer c1 = cusmodel.customers.Find(int.Parse(txtid.Text));
            if (c1 != null)
            {
                if (txtname != null && txtphone != null && txtfax != null && txtmobile != null && txtwebsite != null && txtemail != null)
                {
                    c1.email = txtemail.Text;
                    c1.phone = txtphone.Text;
                    c1.name = txtname.Text;
                    c1.fax = txtfax.Text;
                    c1.website = txtwebsite.Text;
                    cusmodel.SaveChanges();
                    comboBox1.Items.Add(txtid.Text);
                    listBox1.Items.Add(txtname.Text);
                    MessageBox.Show("updated successfuly ^_^");
                    txtid.Text = txtname.Text = txtemail.Text = txtphone.Text = txtwebsite.Text = txtmobile.Text = txtfax.Text = " ";
                }
                else
                {
                    MessageBox.Show("please enter valid data");
                }
            }
            else
            {
                MessageBox.Show("not found this customer to update");
            }
        }

        //delete customer
        private void btndelete_Click(object sender, EventArgs e)
        {
            customer c1 = cusmodel.customers.Find(int.Parse(txtid.Text));
            if (c1 != null)
            {
                cusmodel.customers.Remove(c1);
                MessageBox.Show("Are You Sure");
                cusmodel.SaveChanges();
                comboBox1.Items.Remove(txtid.Text);
                listBox1.Items.Remove(txtid.Text);
                MessageBox.Show("Deleted successfuly ^_^");
                txtid.Text = txtname.Text = txtemail.Text = txtphone.Text = txtwebsite.Text = txtmobile.Text = txtfax.Text = " ";
            }
            else
            {
                MessageBox.Show("not found this customer to delete");
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
