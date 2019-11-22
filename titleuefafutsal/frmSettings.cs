using System;
using System.Windows.Forms;
using titleuefafutsal.model;

namespace titleuefafutsal
{
    public partial class frmSettings : Form
    {
        Settings settings;

        public frmSettings(Settings settings)
        {
            this.settings = settings;
            InitializeComponent();
            tbArena.Text = this.settings.Arena;
            tbDateTime.Text = this.settings.DateTime;
            tbReferee.Text = this.settings.Referee;
            tbSecondReferee.Text = this.settings.SecondReferee;
            tbThirdOfficial.Text = this.settings.ThirdOfficial;
            tbTimeKeeper.Text = this.settings.TimeKeeper;
            tbTimeServerAdress.Text = this.settings.TimeServerAddress;
            tbTimeServerPort.Text = this.settings.TimeServerPort;
            cbUseTimeServer.Checked = this.settings.UseTimeServer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.settings.Arena = tbArena.Text;
            this.settings.DateTime = tbDateTime.Text;
            this.settings.Referee = tbReferee.Text;
            this.settings.SecondReferee = tbSecondReferee.Text;
            this.settings.ThirdOfficial = tbThirdOfficial.Text;
            this.settings.TimeKeeper = tbTimeKeeper.Text;
            this.settings.TimeServerAddress = tbTimeServerAdress.Text;
            this.settings.TimeServerPort = tbTimeServerPort.Text;
            this.settings.UseTimeServer = cbUseTimeServer.Checked;
        }
    }
}
