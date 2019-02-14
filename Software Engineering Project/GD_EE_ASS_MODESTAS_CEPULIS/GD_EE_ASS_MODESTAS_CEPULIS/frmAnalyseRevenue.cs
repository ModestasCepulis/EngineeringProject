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
    public partial class frmAnalyseRevenue : Form
    {
        frmMainMenu home = new frmMainMenu();

        public frmAnalyseRevenue()
        {
            InitializeComponent();
        }

        //the argument constructer
        public frmAnalyseRevenue(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Revenue listed!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picMain_Click(object sender, EventArgs e)
        {

        }

        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {
            picMain.Visible = true;
        }
    }
}
