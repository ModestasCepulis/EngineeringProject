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
    public partial class frmAnalyseDeliveries : Form
    {
        frmMainMenu home = new frmMainMenu();

        public frmAnalyseDeliveries()
        {
            home.loginCount = 1;
            InitializeComponent();
        }

        public frmAnalyseDeliveries(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Daily deliveries listed!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtpDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            picMain.Visible = true;
        }
    }
}
