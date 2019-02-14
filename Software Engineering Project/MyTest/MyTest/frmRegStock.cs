using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTest
{
    public partial class frmRegStock : Form
    {
        public frmRegStock()
        {
            InitializeComponent();
        }

        private void lblStockNo_Click(object sender, EventArgs e)
        {

        }

        private void frmRegStock_Load(object sender, EventArgs e)
        {
            txtStockNo.Text = Stock.getNextStockNumber().ToString("00000");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Validate data
            //(cost price numeric > 0, all fields gonna be empty)

            //Save the data in the Stock table (database)
            //Initiate insert method
            Stock myStock = new Stock(Convert.ToInt32(txtStockNo.Text), txtDescription.Text, Convert.ToDecimal(txtCost.Text), 15, 22, "A");
            myStock.regStock();


            //Display a confirmation message
            MessageBox.Show("Thank you for registering stock number: " + txtStockNo.Text+ " \nbbye.","Successful",MessageBoxButtons.OK);

            //Reset UI
            txtCost.Clear();
            txtDescription.Clear();
            txtQuantity.Clear();
            txtSale.Clear();
    

            txtStockNo.Text = Stock.getNextStockNumber().ToString("00000");
            txtDescription.Focus();

       
        }
    }
}
