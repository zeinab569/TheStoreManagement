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
    public partial class Product : Form
    {
        InventoryEntities itemmodel = new InventoryEntities();
        public Product()
        {
            InitializeComponent();
        }

        //DisplayAll
        private void btndisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            foreach (item i in itemmodel.items)
            {
                comboBox1.Items.Add(i.id);
                listBox1.Items.Add(i.name);
            }
        }

        //Add product
        private void btnadd_Click(object sender, EventArgs e)
        {
            item p1 = new item();
            item p2 = itemmodel.items.Find(int.Parse(txtid.Text));
            if (p2 == null)
            {
                p1.id = int.Parse(txtid.Text);
                p1.code = txtCode.Text;
                p1.name = txtname.Text;
                p1.unit_of_measurement = txtunit.Text;
                p1.production_date = productiondate.Value;
                p1.expire_date=expiredate.Value;
                itemmodel.items.Add(p1);
                itemmodel.SaveChanges();
                MessageBox.Show("added successfuly ^_^");
                comboBox1.Items.Add(int.Parse(txtid.Text));
                listBox1.Items.Add(txtname.Text);
                txtid.Text = txtname.Text = txtCode.Text = txtunit.Text = " ";
            }
            else
            {
                MessageBox.Show("already exist ");
            }
        }

        //update product
        private void btnupdate_Click(object sender, EventArgs e)
        {
            item p1 = itemmodel.items.Find(int.Parse(txtid.Text));
            if (p1 != null)
            {
                if (txtCode.Text != null && txtname.Text != null && txtunit.Text != null)
                {
                    p1.code = txtCode.Text;
                    p1.name = txtname.Text;
                    p1.unit_of_measurement = txtunit.Text;
                    p1.production_date = productiondate.Value;
                    p1.expire_date = expiredate.Value;
                    MessageBox.Show("Are You sure");
                    itemmodel.SaveChanges();
                    MessageBox.Show("updated succfully ^_^");
                    txtid.Text = txtname.Text = txtCode.Text = txtunit.Text = " ";
                }
                else
                {
                    MessageBox.Show("please enter valid date to update");
                }
            }
            else
            {
                MessageBox.Show("not found this product");
            }
        }

        //delete product
        private void btndelete_Click(object sender, EventArgs e)
        {
            item p1 = itemmodel.items.Find(int.Parse(txtid.Text));
            if (p1 != null)
            {
                MessageBox.Show("Are You sure");
                itemmodel.items.Remove(p1);
                itemmodel.SaveChanges();
                MessageBox.Show("Deleted successfuly ^_^");
                comboBox1.Items.Remove(txtid.Text);
                listBox1.Items.Remove(txtid.Text);
                txtid.Text = txtname.Text = txtCode.Text = txtunit.Text = " ";
            }
            else
            {
                MessageBox.Show("not found this product");
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
