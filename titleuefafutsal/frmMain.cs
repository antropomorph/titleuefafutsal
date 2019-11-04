using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
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
        Team Club1 = new Team();
        Team Club2 = new Team();
        Player Player1 = new Player();
        Player Player2 = new Player();

        public frmMain()
        {
            InitializeComponent();
            if (File.Exists(GAMESETTINGS))
            {
                gameSettings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(GAMESETTINGS));
                cbSemiFinal.Checked = gameSettings.SemiFinal;
            }

            /*if (File.Exists(TEAMS))
            {
                teams = JsonConvert.DeserializeObject<List<Team>>(File.ReadAllText(TEAMS));
            }*/
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
                    xpression.ShowMatchID(Club1.Name, "Test2", gameSettings.Arena, gameSettings.DateTime, gameSettings.SemiFinal);
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
           // File.WriteAllText(TEAMS, JsonConvert.SerializeObject(teams, Formatting.Indented));
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
                    xpression.ShowBigScore(Club1.Name, "test2", "3", "10", "HALF-TIME");
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeam FrmTeam = new frmTeam();
            FrmTeam.ShowDialog();
            this.teamTableAdapter.Fill(this.databaseDataSet.Team);
            this.playerTableAdapter.Fill(this.databaseDataSet.Player);
        }

        private void teamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Player". При необходимости она может быть перемещена или удалена.
            this.playerTableAdapter.Fill(this.databaseDataSet.Player);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Team". При необходимости она может быть перемещена или удалена.
            this.teamTableAdapter.Fill(this.databaseDataSet.Team);
        }

        private void teamBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.teamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void cbClub1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbClub1_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedValue != null)
            {
                Club1.ID = (sender as ComboBox).SelectedValue.ToString();
                Club1.Name = ((DataRowView)teamBindingSource.Current).Row["ClubName"].ToString();
                playerBindingSource.Filter = "IDClub = " + Club1.ID;
            }
        }

        private void dgvClub1_SelectionChanged(object sender, EventArgs e)
        {
           /* if (dgvClub1.SelectedRows.Count != 0)
            {
                Player1.Name = dgvClub1.CurrentRow.Cells["PlayerName"].ToString();
                Player1.Surname = dgvClub1.CurrentRow.Cells["PlayerSurname"].ToString();
            }*/
        }
    }
}
