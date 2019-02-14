using EP_Modestas_Cepulis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    public partial class frmNewCustomer : Form
    {
      
        frmMainMenu home = new frmMainMenu();

        public frmNewCustomer()
        {
 
            InitializeComponent();
        } 

        //the argument constructer
        public frmNewCustomer(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void lblFirstAndSecondName_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbFirstAndLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCustomerAdd_Click(object sender, EventArgs e)
        {
            //validate data
            if(!validEmail(txtEmailAddress.Text))
            {
                MessageBox.Show("Email address is invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }
            validation();

            //instantiate Stock Object
            Customers myCustomers = new Customers(Convert.ToInt32(txtCustomerID.Text), txtFirstName.Text, txtLastName.Text,
                txtAddress.Text, String.Format("{0:dd-MMM-yy}", txtDateOfBirth.Text), txtPhoneNumber.Text, txtEmailAddress.Text, "A", "Username", "Password");


            //INSERT Stock record into stock table
            myCustomers.regCustomer();

            //Display Confirmation Message
            MessageBox.Show("Customer " + txtCustomerID.Text + " Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI

            txtCustomerID.Text = Customers.getNextCustomerID().ToString("00000");


        }

        //Creates a method that clears every input made by customer
        private void clearEverything()
        {
            txtFirstName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtLastName.Clear();
            txtEmailAddress.Clear();
        }

        public void validation()
        {
            //Validation
            if (txtFirstName.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid first name, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtFirstName.Clear();
            }

            else if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("You did not enter valid street, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtAddress.Clear();
            }
            else if(txtLastName.Equals(""))
            {
                MessageBox.Show("You did not enter a valid second name, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLastName.Clear();
            }         
            else if (txtEmailAddress.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid e-mail address, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtEmailAddress.Clear();
            }
            else
            {
                MessageBox.Show("New customer details added!", "New Customers", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                clearEverything();
            }
        }      


        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        public bool validEmail(String inStr)
        {
            if (Regex.IsMatch(inStr,
                           @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + 
                           @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void frmNewCustomer_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = Customers.getNextCustomerID().ToString("000");
        }

        private void gbEnterDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
