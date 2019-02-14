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
    public partial class frmChangeOrder : Form
    {

        frmMainMenu home = new frmMainMenu();

        public frmChangeOrder()
        {
            InitializeComponent();
        }

        public frmChangeOrder(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmChangeOrder_Load(object sender, EventArgs e)
        {

        }

        private void lblChooceToChange_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our system!", "Check Out Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbTotalPrice.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbChooseToChange_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbEircode_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCounty_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTown_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearEverything()
        {
            tbStreet.Clear();
            tbTown.Clear();
            tbCounty.Clear();
            tbEircode.Clear();
            tbOrderType.Clear();
            tbAmount.Clear();
        }

        private void btnNewOrderAdd_Click(object sender, EventArgs e)
        {
       

            if (tbStreet.Text.Equals(""))
            {
                MessageBox.Show("You did not enter valid street, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbStreet.Clear();
            }         
            else if (tbTown.Text.Equals(""))
            {
                MessageBox.Show("You did not enter valid town, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbTown.Clear();
            }

            else if (tbCounty.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid county, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbCounty.Clear();
            }
            else if (tbEircode.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a eircode, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbEircode.Clear();
            }
            else if(tbOrderType.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid order type, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbOrderType.Clear();
            }
            else if (tbAmount.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid amount, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbAmount.Clear();
            }
            else
            {
                MessageBox.Show("Customer details updated!", "Update Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                clearEverything();
            }

        }

        private void lblOrderAddress_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
