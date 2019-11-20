using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using titleuefafutsal.model;

namespace titleuefafutsal
{
    public partial class FrmGroupStandings : Form
    {
        frmMain main;

        public FrmGroupStandings()
        {
            InitializeComponent();
        }

        private void teamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void FrmGroupStandings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Team". При необходимости она может быть перемещена или удалена.
            this.teamTableAdapter.Fill(this.databaseDataSet.Team);
            main = this.Owner as frmMain;

        }

        private void teamBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.teamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Team Club1, Club2, Club3, Club4;
            Club1 = new Team();
            Club2 = new Team();
            Club3 = new Team();
            Club4 = new Team();

            Club1.PTS = dgvGroupStandings.Rows[0].Cells["dgvcPTS"].Value.ToString();
            Club1.P = dgvGroupStandings.Rows[0].Cells["dgvcP"].Value.ToString();
            Club1.W = dgvGroupStandings.Rows[0].Cells["dgvcW"].Value.ToString();
            Club1.D = dgvGroupStandings.Rows[0].Cells["dgvcD"].Value.ToString();
            Club1.L = dgvGroupStandings.Rows[0].Cells["dgvcL"].Value.ToString();
            Club1.GF = dgvGroupStandings.Rows[0].Cells["dgvcGF"].Value.ToString();
            Club1.GA = dgvGroupStandings.Rows[0].Cells["dgvcGA"].Value.ToString();
            Club1.Logo = dgvGroupStandings.Rows[0].Cells["dgvcClubLogo"].Value.ToString();
            Club1.Name = dgvGroupStandings.Rows[0].Cells["dgvcClubName"].Value.ToString();

            Club2.PTS = dgvGroupStandings.Rows[1].Cells["dgvcPTS"].Value.ToString();
            Club2.P = dgvGroupStandings.Rows[1].Cells["dgvcP"].Value.ToString();
            Club2.W = dgvGroupStandings.Rows[1].Cells["dgvcW"].Value.ToString();
            Club2.D = dgvGroupStandings.Rows[1].Cells["dgvcD"].Value.ToString();
            Club2.L = dgvGroupStandings.Rows[1].Cells["dgvcL"].Value.ToString();
            Club2.GF = dgvGroupStandings.Rows[1].Cells["dgvcGF"].Value.ToString();
            Club2.GA = dgvGroupStandings.Rows[1].Cells["dgvcGA"].Value.ToString();
            Club2.Logo = dgvGroupStandings.Rows[1].Cells["dgvcClubLogo"].Value.ToString();
            Club2.Name = dgvGroupStandings.Rows[1].Cells["dgvcClubName"].Value.ToString();

            Club3.PTS = dgvGroupStandings.Rows[2].Cells["dgvcPTS"].Value.ToString();
            Club3.P = dgvGroupStandings.Rows[2].Cells["dgvcP"].Value.ToString();
            Club3.W = dgvGroupStandings.Rows[2].Cells["dgvcW"].Value.ToString();
            Club3.D = dgvGroupStandings.Rows[2].Cells["dgvcD"].Value.ToString();
            Club3.L = dgvGroupStandings.Rows[2].Cells["dgvcL"].Value.ToString();
            Club3.GF = dgvGroupStandings.Rows[2].Cells["dgvcGF"].Value.ToString();
            Club3.GA = dgvGroupStandings.Rows[2].Cells["dgvcGA"].Value.ToString();
            Club3.Logo = dgvGroupStandings.Rows[2].Cells["dgvcClubLogo"].Value.ToString();
            Club3.Name = dgvGroupStandings.Rows[2].Cells["dgvcClubName"].Value.ToString();

            Club4.PTS = dgvGroupStandings.Rows[3].Cells["dgvcPTS"].Value.ToString();
            Club4.P = dgvGroupStandings.Rows[3].Cells["dgvcP"].Value.ToString();
            Club4.W = dgvGroupStandings.Rows[3].Cells["dgvcW"].Value.ToString();
            Club4.D = dgvGroupStandings.Rows[3].Cells["dgvcD"].Value.ToString();
            Club4.L = dgvGroupStandings.Rows[3].Cells["dgvcL"].Value.ToString();
            Club4.GF = dgvGroupStandings.Rows[3].Cells["dgvcGF"].Value.ToString();
            Club4.GA = dgvGroupStandings.Rows[3].Cells["dgvcGA"].Value.ToString();
            Club4.Logo = dgvGroupStandings.Rows[3].Cells["dgvcClubLogo"].Value.ToString();
            Club4.Name = dgvGroupStandings.Rows[3].Cells["dgvcClubName"].Value.ToString();
            if (main.xpression != null)
                main.xpression.ShowGroupStandings(Club1, Club2, Club3, Club4);
        }
    }
}
