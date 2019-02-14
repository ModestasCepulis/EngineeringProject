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
    public partial class frmAnalyseOrders : Form
    {
        frmMainMenu home = new frmMainMenu();

        public frmAnalyseOrders()
        {
            InitializeComponent();
        }

        //the argument constructer
        public frmAnalyseOrders(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {

        }

        private void tlmnuBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void frmAnalyseOrders_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            gbCustomerDetails.Visible = true;
            gbOrderDetails.Visible = true;
            MessageBox.Show("Order listed!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
    }
}
