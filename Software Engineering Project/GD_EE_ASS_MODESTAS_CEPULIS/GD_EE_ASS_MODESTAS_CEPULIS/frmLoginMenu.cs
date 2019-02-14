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
    public partial class frmLoginMenu : Form
    {
 
        frmMainMenu home = new frmMainMenu();

        public frmLoginMenu()
        {
            InitializeComponent();
        }

        public frmLoginMenu(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegisterMenu frmRegisterMenu = new frmRegisterMenu();
            frmRegisterMenu.ShowDialog();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (tbUsername.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid username, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbUsername.Clear();
            }
            if (tbPassword.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid password, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbPassword.Clear();
            }
            else
            {
                home.loginCount=1;

                MessageBox.Show("Success! Welcome to the system.", "Welcome to the system", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tbUsername.Clear();
                tbPassword.Clear();
                this.Hide();
                home.Visible = true;


            }
        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.Visible = true;
        }
    }
}
