using CIMS.UserControls.CtrlCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIMS.Users
{
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            ctrlUserInfo1.LoadUserInfo(UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
