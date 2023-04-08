using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEntityStoreManagementProject.Reporting_For_Store;

namespace TheEntityStoreManagementProject.Screens
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            TheLogin l = new TheLogin();
            l.Show();
            this.Hide();    
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            ImportPermits im = new ImportPermits();   
            im.Show();
            this.Hide();
            
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            ExportPermits im = new ExportPermits();
            im.Show();
            this.Hide();
        }

        private void btnstore_Click(object sender, EventArgs e)
        {
            TheStore theStore = new TheStore();
            theStore.Show();
            this.Hide();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void btnsuppliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();  
            suppliers.Show();
            this.Hide();
        }

        private void btnrstore_Click(object sender, EventArgs e)
        {
            StoreReport s = new StoreReport();
            s.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsReport productsReport = new ProductsReport();
            productsReport.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transfer_Itemes transfer_Itemes = new Transfer_Itemes();
            transfer_Itemes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TransferItemReport transferItemReport = new TransferItemReport();
            transferItemReport.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CloseToExpire ex = new CloseToExpire();
            ex.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AlreadyExpire al = new AlreadyExpire();
            al.Show();

        }
    }
}
