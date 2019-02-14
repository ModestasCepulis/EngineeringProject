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
    public partial class frmNewStock : Form
    {

        frmMainMenu home = new frmMainMenu();

        public frmNewStock()
        {
            InitializeComponent();
        }

        public frmNewStock(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void frmNewStock_Load(object sender, EventArgs e)
        {
            txtStockID.Text = Stock.getNextStockID().ToString("000");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //validate data

            if (txtCostPrice.Text.Equals(""))
            {
                MessageBox.Show("You entered invalid amount! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCostPrice.Focus();
                return; 
            }
            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("You entered invalid stock type! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
           


            //instantiate Stock Object
            Stock myStock = new Stock(Convert.ToInt32(txtStockID.Text), txtDescription.Text, Convert.ToDecimal(txtCostPrice.Text),
                Convert.ToDecimal(txtSalePrice.Text), Convert.ToInt32(txtQty.Text), String.Format("{0:dd-MMM-yy}", txtDateAdded.Text), "A");


            //INSERT Stock record into stock table
            myStock.regStock();

            //Display Confirmation Message
            MessageBox.Show("Stock " + txtStockID.Text + " Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtDescription.Clear();
            txtCostPrice.Clear();
            txtSalePrice.Clear();
            txtQty.Clear();

            txtStockID.Text = Stock.getNextStockID().ToString("00000");
            txtDescription.Focus();


        }
    }
}
