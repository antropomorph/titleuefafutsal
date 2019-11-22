using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace titleuefafutsal
{
    public partial class FrmFreeGraphics : Form
    {
        frmMain main;

        public FrmFreeGraphics()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (main.xpression != null)
                main.xpression.ShowFreeGraphics(tbFreeText.Text);
        }

        private void FrmFreeGraphics_Load(object sender, EventArgs e)
        {
            main = this.Owner as frmMain;

        }
    }
}
