using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIMS.Help
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void linkedin_Click(object sender, EventArgs e)
        {
            llbllinkedin.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mounes-alshawashi-466396372/");
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            llblGitHub.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/MoneesMohammed");
        }
    }
}
