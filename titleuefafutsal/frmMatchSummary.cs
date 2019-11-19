using System;
using System.Windows.Forms;
using titleuefafutsal.model;

namespace titleuefafutsal
{
    public partial class frmMatchSummary : Form
    {
        frmMain main;
        Team Club1, Club2;
        public frmMatchSummary(Team Club1, Team Club2)
        {
            InitializeComponent();
            this.Club1 = Club1;
            this.Club2 = Club2;

            tbClub1AttemtpsOnTarget.Text = Club1.AttemptsOnTarget;
            tbClub1TotalAttempts.Text = Club1.TotalAttempts;
            tbClub1Corners.Text = Club1.Corners;
            tbClub11stFouls.Text = Club1.Fouls1;
            tbClub11stYellow.Text = Club1.Yellow1;
            tbClub11stRed.Text = Club1.Red1;
            tbClub12ndFouls.Text = Club1.Fouls2;
            tbClub12ndYellow.Text = Club1.Yellow2;
            tbClub12ndRed.Text = Club1.Red2;

            tbClub2AttemtpsOnTarget.Text = Club2.AttemptsOnTarget;
            tbClub2TotalAttempts.Text = Club2.TotalAttempts;
            tbClub2Corners.Text = Club2.Corners;
            tbClub21stFouls.Text = Club2.Fouls1;
            tbClub21stYellow.Text = Club2.Yellow1;
            tbClub21stRed.Text = Club2.Red1;
            tbClub22ndFouls.Text = Club2.Fouls2;
            tbClub22ndYellow.Text = Club2.Yellow2;
            tbClub22ndRed.Text = Club2.Red2;
        }

        private void frmMatchSummary_Load(object sender, EventArgs e)
        {
            main = this.Owner as frmMain;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Club1.AttemptsOnTarget = tbClub1AttemtpsOnTarget.Text;
            Club1.TotalAttempts = tbClub1TotalAttempts.Text;
            Club1.Corners = tbClub1Corners.Text;
            Club1.Fouls1 = tbClub11stFouls.Text;
            Club1.Yellow1 = tbClub11stYellow.Text;
            Club1.Red1 = tbClub11stRed.Text;
            Club1.Fouls2 = tbClub12ndFouls.Text;
            Club1.Yellow2 = tbClub12ndYellow.Text;
            Club1.Red2 = tbClub12ndRed.Text;

            Club2.AttemptsOnTarget = tbClub2AttemtpsOnTarget.Text;
            Club2.TotalAttempts = tbClub2TotalAttempts.Text;
            Club2.Corners = tbClub2Corners.Text;
            Club2.Fouls1 = tbClub21stFouls.Text;
            Club2.Yellow1 = tbClub21stYellow.Text;
            Club2.Red1 = tbClub21stRed.Text;
            Club2.Fouls2 = tbClub22ndFouls.Text;
            Club2.Yellow2 = tbClub22ndYellow.Text;
            Club2.Red2 = tbClub22ndRed.Text;

            if (main.xpression != null)
                main.xpression.ShowStatistics(Club1, Club2, main.gameSettings);
        }
    }
}