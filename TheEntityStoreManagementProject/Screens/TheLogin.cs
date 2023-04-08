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
    public partial class TheLogin : Form
    {
        InventoryEntities logmodel = new InventoryEntities();
        public TheLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login user1 = new Login();
            user1.username = textBox1.Text;
            user1.password = textBox2.Text;

            var allowed = (from s1 in logmodel.Logins
                           where s1.username == user1.username
                           && s1.password == user1.password
                           select s1.id).FirstOrDefault();
            if (allowed > 0)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("not allowed");
            }
        }
    }
}
