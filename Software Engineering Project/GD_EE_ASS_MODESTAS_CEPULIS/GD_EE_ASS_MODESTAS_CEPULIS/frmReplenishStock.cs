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
    public partial class frmReplenishStock : Form
    {

        frmMainMenu home = new frmMainMenu();

        public frmReplenishStock()
        {
            InitializeComponent();
        }

        public frmReplenishStock(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void frmReplenishStock_Load(object sender, EventArgs e)
        {
            //load combo with stockNo and Description for all stock
            DataSet ds = new DataSet();
            ds = Stock.getStock(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboStock.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validate data


            //instantiate Stock Object
            Stock myStock = new Stock();
            myStock.setStockNo(Convert.ToInt32(txtStockNo.Text));
            myStock.setDescription(txtDescription.Text);
            myStock.setCostPrice(Convert.ToDecimal(txtCostPrice.Text));
            myStock.setSalePrice(Convert.ToDecimal(txtSalePrice.Text));
            myStock.setQty(Convert.ToInt32(txtQty.Text));


            //INSERT Stock record into stock table
            myStock.updStock();

            //Display Confirmation Message
            MessageBox.Show("Stock " + txtStockNo.Text + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            grpStock.Visible = false;

            cboStock.SelectedIndex = -1;

        }
        private void cboStock_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if resetting combo, ignore
            if (cboStock.SelectedIndex == -1)
            {
                return;
            }
            //find stock details
            Stock updStock = new Stock();
            updStock.getStock(Convert.ToInt32(cboStock.Text.Substring(0, 3)));

            if (updStock.getStockNo().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockNo.Focus();
                return;
            }

            //display Stock details
            txtStockNo.Text = updStock.getStockNo().ToString("000");
            txtDescription.Text = updStock.getDescription();
            txtCostPrice.Text = updStock.getCostPrice().ToString();
            txtSalePrice.Text = updStock.getSalePrice().ToString();
            txtQty.Text = updStock.getQty().ToString();

            //display details
            grpStock.Visible = true;
        }
    }
}
