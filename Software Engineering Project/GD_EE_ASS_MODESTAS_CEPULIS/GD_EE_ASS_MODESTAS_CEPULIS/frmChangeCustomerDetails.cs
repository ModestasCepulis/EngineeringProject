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
    public partial class frmChangeCustomerDetails : Form
    {
        frmMainMenu home = new frmMainMenu();

        public frmChangeCustomerDetails()
        {
            InitializeComponent();
        }

        //the argument constructer
        public frmChangeCustomerDetails (frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void frmChangeCustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstAndSecondName_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            validation();

        }


        //Creates a method that clears every input made by customer
        private void clearEverything()
        {
            tbFirstName.Clear();
            tbStreet.Clear();
            tbTown.Clear();
            tbCounty.Clear();
            tbEircode.Clear();
            tbNewPhoneNumber.Clear();
            tbSecondName.Clear();
            tbEmailAddress.Clear();
        }

        private void validation()
        {


            if (tbFirstName.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid first name, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbFirstName.Clear();
            }

            else if (tbStreet.Text.Equals(""))
            {
                MessageBox.Show("You did not enter valid street, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbStreet.Clear();
            }
            else if (tbSecondName.Equals(""))
            {
                MessageBox.Show("You did not enter a valid second name, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbSecondName.Clear();
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
            else  if(tbNewPhoneNumber.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid phone number, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbNewPhoneNumber.Clear();
            }
            else if (tbEmailAddress.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid e-mail address, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbEmailAddress.Clear();
            }
            else
            {
                MessageBox.Show("Customer details updated!", "Update Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                clearEverything();
            }
        
        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void tbNewAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lblNewAdress_Click(object sender, EventArgs e)
        {

        }

        private void tbNewInformation_TextChanged(object sender, EventArgs e)
        {

        }

        private void pcbChangeCustomer_Click(object sender, EventArgs e)
        {

        }

        private void tbEmailAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
