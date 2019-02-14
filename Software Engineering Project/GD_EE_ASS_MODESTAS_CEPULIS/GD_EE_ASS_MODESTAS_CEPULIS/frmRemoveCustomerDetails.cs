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
    public partial class frmRemoveCustomerDetails : Form
    {

        frmMainMenu home = new frmMainMenu();

        public frmRemoveCustomerDetails()
        {
            InitializeComponent();
        }

        public frmRemoveCustomerDetails(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void cmbRemoveCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Equals(""))
          
            {
                MessageBox.Show("You did not enter the right password!", "Remove Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Customer status updated!", "Remove Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPassword.Clear();
            }
        }
        
        
    }
}
