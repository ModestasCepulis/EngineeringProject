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
    public partial class frmRegisterMenu : Form
    {
        public frmRegisterMenu()
        {
            InitializeComponent();
        }

        private void tbNewUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewRegister_Click(object sender, EventArgs e)
        {
            if (tbNewUsername.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid username, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbNewUsername.Clear();
            }
            if (tbNewPassword.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid password, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbNewPassword.Clear();
            }
            else
            {
                MessageBox.Show("New account created!!", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tbNewUsername.Clear();
                tbNewPassword.Clear();
                this.Close();
            }
        }
    }
}
