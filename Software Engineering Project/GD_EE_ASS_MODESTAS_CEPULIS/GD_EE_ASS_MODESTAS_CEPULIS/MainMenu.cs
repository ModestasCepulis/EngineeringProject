using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    public partial class frmMainMenu : Form
    {
        public int loginCount = 0;

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginCount == 0)
            {
                MessageBox.Show("You did not login! Please login in the login menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
            frmNewOrder frmNewOrder = new frmNewOrder(this);
            this.Hide();
            frmNewOrder.ShowDialog();
            }
            
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(loginCount == 0)
            {
                MessageBox.Show("You did not login! Please login in the login menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmNewCustomer frmNewCustomer = new frmNewCustomer(this);
                this.Hide();
                frmNewCustomer.Show();
            }
    
        }

        private void mnsChangeCustomer_Click(object sender, EventArgs e)
        {
            if (loginCount == 0)
            {
                MessageBox.Show("You did not login! Please login in the login menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmChangeCustomerDetails frmChangeCustomerDetails = new frmChangeCustomerDetails(this);
                this.Hide();
                frmChangeCustomerDetails.ShowDialog();
            }
        }

        private void mnsChangeOrder_Click(object sender, EventArgs e)
        {
            if (loginCount == 0)
            {
                MessageBox.Show("You did not login! Please login in the login menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmChangeOrder frmChangeOrder = new frmChangeOrder(this);
                this.Hide();
                frmChangeOrder.ShowDialog();
            }

        }

        private void mnsDispatchOrder_Click(object sender, EventArgs e)
        {
            if (loginCount == 0)
            {
                MessageBox.Show("You did not login! Please login in the login menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmDispatchOrder frmDispatchOrder = new frmDispatchOrder(this);
                this.Hide();
                frmDispatchOrder.ShowDialog();
            }
            
        }

        private void mnsCancelOrder_Click(object sender, EventArgs e)
        {
            if (loginCount == 0)
            {
                MessageBox.Show("You did not login! Please login in the login menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                    frmCancelOrder frmCancelOrder = new frmCancelOrder(this);
                    this.Hide();
                    frmCancelOrder.ShowDialog();
            }
            
        }

        private void mnsListDailyDeliveries_Click(object sender, EventArgs e)
        {
            if (loginCount == 0)
            {
                MessageBox.Show("You did not login! Please login in the login menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
            frmAnalyseDeliveries frmListDailyDeliveries = new frmAnalyseDeliveries();
            this.Hide();
            frmListDailyDeliveries.ShowDialog();
            }
            
        }

        private void mnsAnalyseOrders_Click(object sender, EventArgs e)
        {
            if (loginCount == 0)
            {
                MessageBox.Show("You did not login! Please login in the login menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmAnalyseOrders frmAnalyseOrders = new frmAnalyseOrders(this);
                this.Hide();
                frmAnalyseOrders.ShowDialog();
            }
            
        }

        private void mnsAnalyseRevenue_Click(object sender, EventArgs e)
        {
            if (loginCount == 0)
            {
                MessageBox.Show("You did not login! Please login in the login menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
              frmAnalyseRevenue frmAnalyseRevenue = new frmAnalyseRevenue(this);
            this.Hide();
            frmAnalyseRevenue.ShowDialog();  
            }
            
        }

        private void mnsRemoveCustomer_Click(object sender, EventArgs e)
        {

            if (loginCount == 0)
            {
                MessageBox.Show("You did not login! Please login in the login menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                    frmRemoveCustomerDetails frmRemoveCustomerDetails = new frmRemoveCustomerDetails(this);
            this.Hide();
            frmRemoveCustomerDetails.ShowDialog();
            }
            
        }

        private void mnsCustomers_Click(object sender, EventArgs e)
        {
          

        }

        private void newStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginCount == 0)
            {
                MessageBox.Show("You did not login! Please login in the login menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
            frmNewStock frmNewStock = new frmNewStock(this);
            this.Hide();
            frmNewStock.Show();
            }
            
        }

        private void replenishStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginCount == 0)
            {
                MessageBox.Show("You did not login! Please login in the login menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
             frmReplenishStock frmReplenishStock = new frmReplenishStock(this);
            this.Hide();
            frmReplenishStock.Show();   
            }
            
        }

        private void loginMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmLoginMenu frmLoginMenu = new frmLoginMenu();
            this.Hide();
            frmLoginMenu.Show();            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
