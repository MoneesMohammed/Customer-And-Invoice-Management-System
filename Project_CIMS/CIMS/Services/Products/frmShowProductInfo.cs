using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIMS.Services.Products
{
    public partial class frmShowProductInfo : Form
    {
        public frmShowProductInfo(int ProductID)
        {
            InitializeComponent();
            ctrlProductInfo1.LoadProductInfo(ProductID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
