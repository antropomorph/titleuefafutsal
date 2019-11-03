using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using titleuefafutsal.model;

namespace titleuefafutsal
{
    public partial class frmMain : Form
    {
        const string GAMESETTINGS = @".\gameSettins.json";
        const string TEAMS = @".\teams.json";

        GXPression xpression;
        Settings gameSettings = new Settings();
        List<Team> teams = new List<Team>();

        public frmMain()
        {
            InitializeComponent();
            if (File.Exists(GAMESETTINGS))
            {
                gameSettings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(GAMESETTINGS));
                cbSemiFinal.Checked = gameSettings.SemiFinal;
            }

            if (File.Exists(TEAMS))
            {
                teams = JsonConvert.DeserializeObject<List<Team>>(File.ReadAllText(TEAMS));
            }
        }

        private void btnKillAll_Click(object sender, EventArgs e)
        {
            if (xpression != null)
                xpression.KillAll();
        }

        private void rbEventTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                    xpression.ShowMatchID("Test1", "Test2", gameSettings.Arena, gameSettings.DateTime, gameSettings.SemiFinal);
        }

        private void rbTeamHome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbClearGraphics_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                    if (!xpression.HideScene())
                        ((RadioButton)sender).Checked = false;
        }

        private void startXPressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdProject.ShowDialog() == DialogResult.OK)
            {
                xpression = new GXPression(ofdProject.FileName);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(GAMESETTINGS, JsonConvert.SerializeObject(gameSettings, Formatting.Indented));
            File.WriteAllText(TEAMS, JsonConvert.SerializeObject(teams, Formatting.Indented));
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings FrmSettings = new frmSettings(gameSettings);
            FrmSettings.ShowDialog();
        }

        private void rbOfficials_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                    xpression.ShowOfficials(gameSettings.Referee, gameSettings.SecondReferee, gameSettings.ThirdOfficial, gameSettings.TimeKeeper);
        }

        private void cbSemiFinal_CheckedChanged(object sender, EventArgs e)
        {
            gameSettings.SemiFinal = (sender as CheckBox).Checked;
        }

        private void rbScoreBig_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                    xpression.ShowBigScore("Test1", "test2", "3", "10", "HALF-TIME");
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeam FrmTeam = new frmTeam(teams);
            FrmTeam.ShowDialog();
        }
    }
}
