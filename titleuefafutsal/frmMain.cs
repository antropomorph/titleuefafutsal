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

        public GXPression xpression;
        public Settings gameSettings = new Settings();
        Team Club1 = new Team();
        Team Club2 = new Team();
        List<Player> Club1Team = new List<Player>();
        List<Player> Club2Team = new List<Player>();
        Player Player1 = new Player();
        Player Player2 = new Player();

        private bool remoteClientConnected = false;

        private RemoteClient remoteClient;

        public frmMain()
        {
            InitializeComponent();
            if (File.Exists(GAMESETTINGS))
            {
                gameSettings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(GAMESETTINGS));
                cbSemiFinal.Checked = gameSettings.SemiFinal;
            }
        }

        String GetLogDateTime()
        {
            return DateTime.Now.ToString();
        }

        public void Log(TextBox TextBoxLog, string Text)
        {
            TextBoxLog.Invoke(new Action(() =>
                TextBoxLog.AppendText("[" + GetLogDateTime() + "]: " + Text + Environment.NewLine)));
        }

        public void SetTime(TextBox TextBoxLog, string Text)
        {
            TextBoxLog.Invoke(new Action(() =>
                TextBoxLog.Text = Text));
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
                {
                    xpression.ShowMatchID(Club1.Name, Club2.Name, Club1.Logo, Club2.Logo, gameSettings.Arena, gameSettings.DateTime, gameSettings.SemiFinal);
                }
        }

        private void rbTeamHome_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                {
                    Club1Team.Clear();
                    if (dgvClub1.Rows.Count != 0)
                    {
                        foreach (var p in dgvClub1.Rows)
                        {
                            Player temp = new Player();
                            temp.Name = ((DataGridViewRow)p).Cells["dgcClub1PlayerName"].Value.ToString();
                            temp.Surname = ((DataGridViewRow)p).Cells["dgcClub1PlayerSurname"].Value.ToString();
                            temp.Number = ((DataGridViewRow)p).Cells["dgcClub1PlayerNumber"].Value.ToString();
                            temp.Role = ((DataGridViewRow)p).Cells["dgcClub1PlayerRole"].Value.ToString();
                            Club1Team.Add(temp);
                        }
                    }
                    xpression.ShowTeam(Club1.Logo, Club1.Name, Club1.Coach, Club1Team);
                }
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
                    xpression.ShowBigScore(Club1.Name, Club2.Name, Club1.Logo, Club2.Logo, Club1.Score, Club2.Score, gameSettings.TimePeriod);
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeam FrmTeam = new frmTeam();
            FrmTeam.ShowDialog();
            this.teamTableAdapter1.Fill(this.databaseDataSet.Team);
            this.playerTableAdapter1.Fill(this.databaseDataSet.Player);
        }

        private void teamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Player". При необходимости она может быть перемещена или удалена.
            this.playerTableAdapter1.Fill(this.databaseDataSet.Player);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Team". При необходимости она может быть перемещена или удалена.
            this.teamTableAdapter1.Fill(this.databaseDataSet.Team);

            this.playerTableAdapter2.Fill(this.databaseDataSet.Player);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Team". При необходимости она может быть перемещена или удалена.
            this.teamTableAdapter2.Fill(this.databaseDataSet.Team);
        }

        private void teamBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.teamBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void cbClub1_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedValue != null)
            {
                Club1.ID = (sender as ComboBox).SelectedValue.ToString();
                Club1.Name = ((DataRowView)(sender as ComboBox).SelectedItem).Row["ClubName"].ToString();
                playerBindingSource1.Filter = "IDClub = " + Club1.ID + " AND IsVisible=True";

                Club1.Logo = ((DataRowView)(sender as ComboBox).SelectedItem).Row["ClubLogo"].ToString();
                Club1.Coach = ((DataRowView)(sender as ComboBox).SelectedItem).Row["ClubCoach"].ToString();
                Club1.CoachTitle = ((DataRowView)(sender as ComboBox).SelectedItem).Row["ClubCoachTitle"].ToString();
                Club1.NameShort = ((DataRowView)(sender as ComboBox).SelectedItem).Row["ClubNameShort"].ToString();
                LoadPicture(Club1.Logo, pbTeamHomeLogo);

                Club1Team.Clear();

                if (dgvClub1.Rows.Count != 0)
                {
                    foreach (var p in dgvClub1.Rows)
                    {
                        Player temp = new Player();
                        temp.Name = ((DataGridViewRow)p).Cells["dgcClub1PlayerName"].Value.ToString();
                        temp.Surname = ((DataGridViewRow)p).Cells["dgcClub1PlayerSurname"].Value.ToString();
                        temp.Number = ((DataGridViewRow)p).Cells["dgcClub1PlayerNumber"].Value.ToString();
                        temp.Role = ((DataGridViewRow)p).Cells["dgcClub1PlayerRole"].Value.ToString();
                        Club1Team.Add(temp);
                    }
                }
            }
        }

        private void dgvClub1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClub1.SelectedRows.Count > 0)
            {
                Player1.Name = dgvClub1.CurrentRow.Cells["dgcClub1PlayerName"].Value.ToString();
                Player1.Surname = dgvClub1.CurrentRow.Cells["dgcClub1PlayerSurname"].Value.ToString();
                Player1.Number = dgvClub1.CurrentRow.Cells["dgcClub1PlayerNumber"].Value.ToString();
            }
        }


        private void LoadPicture(string picturePath, PictureBox pictureBox)
        {
            try
            {
                if (picturePath != string.Empty)
                    if (System.IO.File.Exists(picturePath))
                    {
                        pictureBox.ImageLocation = picturePath;
                        pictureBox.Load();
                    }
            }
            catch (Exception e)
            {

            }
        }

        private void rbTimeoutClub1_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                    xpression.ShowTimeout(Club1.Logo);
        }

        private void rbCoachHome_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                    xpression.ShowCoach(Club1.Logo, Club1.Coach, Club1.CoachTitle);
        }

        private void rbPlayerHome_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                    xpression.ShowPlayer(Club1.Logo, Player1.Number, Player1.Surname);
        }

        private void rbBallPossession_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                    xpression.ShowBallPossession(nudPossessionClub1.Value.ToString(), nudPossessionClub2.Value.ToString(), Club1.Logo, Club2.Logo);
        }

        private void btnMatchSummary_Click(object sender, EventArgs e)
        {
            frmMatchSummary FrmMatchSummary = new frmMatchSummary(Club1, Club2);
            FrmMatchSummary.Owner = this;
            if (FrmMatchSummary.ShowDialog() == DialogResult.OK)
            {
                rbClearGraphics.Checked = false;
            }
        }


        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                rbClearGraphics.Checked = true;
            }
            if (e.KeyCode == Keys.F5)
            {
                rbUpScore.Checked = true;
            }
        }

        private void tbPeriod_TextChanged(object sender, EventArgs e)
        {
            gameSettings.Period = (sender as TextBox).Text;
        }

        private void tbTimePeriod_Validated(object sender, EventArgs e)
        {
            gameSettings.TimePeriod = (sender as TextBox).Text;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            gameSettings.HomeFouls = Convert.ToInt32((sender as NumericUpDown).Value);
            if (xpression != null)
                xpression.SetHomeFouls(gameSettings.HomeFouls);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Club1.Score = (sender as NumericUpDown).Value.ToString();
            Club1.Score = gameSettings.HomeScore;
            if (xpression != null)
                xpression.SetScore(Club1.Score, Club2.Score);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            //Club2.Score = (sender as NumericUpDown).Value.ToString();
            Club2.Score = gameSettings.GuestScore;
            if (xpression != null)
                xpression.SetScore(Club1.Score, Club2.Score);
        }

        private void rbUpScore_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                {
                    gameSettings.Period = tbPeriod.Text;
                    Log(tbLog, "HomeFouls = " + gameSettings.HomeFouls.ToString());
                    Log(tbLog, "GuestFouls = " + gameSettings.GuestFouls.ToString());
                    xpression.ShowUpscore(Club1, Club2, gameSettings);
                }
        }

        private void cbClub2_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedValue != null)
            {
                Club2.ID = (sender as ComboBox).SelectedValue.ToString();
                Club2.Name = ((DataRowView)(sender as ComboBox).SelectedItem).Row["ClubName"].ToString();
                playerBindingSource2.Filter = "IDClub = " + Club2.ID + " AND IsVisible=True";

                Club2.Logo = ((DataRowView)(sender as ComboBox).SelectedItem).Row["ClubLogo"].ToString();
                Club2.Coach = ((DataRowView)(sender as ComboBox).SelectedItem).Row["ClubCoach"].ToString();
                Club2.CoachTitle = ((DataRowView)(sender as ComboBox).SelectedItem).Row["ClubCoachTitle"].ToString();
                Club2.NameShort = ((DataRowView)(sender as ComboBox).SelectedItem).Row["ClubNameShort"].ToString();
                LoadPicture(Club2.Logo, pbTeamGuestLogo);

                Club2Team.Clear();

                if (dgvClub2.Rows.Count != 0)
                {
                    foreach (var p in dgvClub2.Rows)
                    {
                        Player temp = new Player();
                        temp.Name = ((DataGridViewRow)p).Cells["dgcClub2PlayerName"].Value.ToString();
                        temp.Surname = ((DataGridViewRow)p).Cells["dgcClub2PlayerSurname"].Value.ToString();
                        temp.Number = ((DataGridViewRow)p).Cells["dgcClub2PlayerNumber"].Value.ToString();
                        temp.Role = ((DataGridViewRow)p).Cells["dgcClub2PlayerRole"].Value.ToString();
                        Club2Team.Add(temp);
                    }
                }
            }
        }

        private void rbPlayerGuest_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                    xpression.ShowPlayer(Club2.Logo, Player2.Number, Player2.Surname);
        }

        private void rbCoachGuest_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                    xpression.ShowCoach(Club2.Logo, Club2.Coach, Club2.CoachTitle);
        }

        private void rbTimeoutClub2_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                    xpression.ShowTimeout(Club2.Logo);
        }

        private void dgvClub2_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClub2.SelectedRows.Count > 0)
            {
                Player2.Name = dgvClub2.CurrentRow.Cells["dgcClub2PlayerName"].Value.ToString();
                Player2.Surname = dgvClub2.CurrentRow.Cells["dgcClub2PlayerSurname"].Value.ToString();
                Player2.Number = dgvClub2.CurrentRow.Cells["dgcClub2PlayerNumber"].Value.ToString();
            }
        }

        private void rbTeamGuest_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)
                {
                    Club2Team.Clear();
                    if (dgvClub2.Rows.Count != 0)
                    {
                        foreach (var p in dgvClub2.Rows)
                        {
                            Player temp = new Player();
                            temp.Name = ((DataGridViewRow)p).Cells["dgcClub2PlayerName"].Value.ToString();
                            temp.Surname = ((DataGridViewRow)p).Cells["dgcClub2PlayerSurname"].Value.ToString();
                            temp.Number = ((DataGridViewRow)p).Cells["dgcClub2PlayerNumber"].Value.ToString();
                            temp.Role = ((DataGridViewRow)p).Cells["dgcClub2PlayerRole"].Value.ToString();
                            Club2Team.Add(temp);
                        }
                    }
                    xpression.ShowTeam(Club2.Logo, Club2.Name, Club2.Coach, Club2Team);
                }
        }

        private void nudPossessionClub1_ValueChanged(object sender, EventArgs e)
        {
            nudPossessionClub2.Value = 100 - nudPossessionClub1.Value;
        }

        private void btnGroupStandings_Click(object sender, EventArgs e)
        {
            FrmGroupStandings frmGroupStandings = new FrmGroupStandings();
            frmGroupStandings.Owner = this;
            if (frmGroupStandings.ShowDialog() == DialogResult.OK)
            {
                rbClearGraphics.Checked = false;
            }
        }

        private void btnConnectTimeServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!remoteClientConnected)
                {
                    remoteClientConnected = true;
                    ClientConnect(gameSettings);
                    (sender as Button).Text = "Отключиться от табло";

                }
                else
                {
                    ClientDisconnect();
                    (sender as Button).Text = "Подключиться к табло";
                    remoteClientConnected = false;
                }
            }
            catch (Exception ex)
            {
                Log(tbLog, ex.Message);
            }
        }

        public void ClientConnect(Settings gameInfo)
        {
            remoteClient = new RemoteClient(gameSettings);
            remoteClient.LogMessage += (s) => Invoke(new Action(() => Log(tbLog, s)));
            remoteClient.LogMessage += (s) => Invoke(new Action(() => SetTime(tbTime, s)));
            remoteClient.SetHomeScore += (s) => Invoke(new Action(() => SetHomeScore(nudHomeScore, s)));
            remoteClient.SetGuestScore += (s) => Invoke(new Action(() => SetGuestScore(nudGuestScore, s)));
            remoteClient.SetHomeFouls += (s) => Invoke(new Action(() => SetHomeFouls(nudHomeFouls, s)));
            remoteClient.SetGuestFouls += (s) => Invoke(new Action(() => SetGuestFouls(nudGuestFouls, s)));

            remoteClient.Start();
        }

        public void ClientDisconnect()
        {
            if (remoteClient != null)
            {
                remoteClient.Stop();
            }
        }

        public void SetHomeScore(NumericUpDown numericUpDown, string Text)
        {
            numericUpDown.Invoke(new Action(() =>
                numericUpDown.Value = Convert.ToInt32(Text)));
        }

        public void SetGuestScore(NumericUpDown numericUpDown, string Text)
        {
            numericUpDown.Invoke(new Action(() =>
                numericUpDown.Value = Convert.ToInt32(Text)));
        }

        public void SetHomeFouls(NumericUpDown numericUpDown, string Text)
        {
            numericUpDown.Invoke(new Action(() =>
                numericUpDown.Value = Convert.ToInt32(Text)));
        }

        public void SetGuestFouls(NumericUpDown numericUpDown, string Text)
        {
            numericUpDown.Invoke(new Action(() =>
                numericUpDown.Value = Convert.ToInt32(Text)));
        }

        private void tbTime_TextChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                //if ((sender as RadioButton).Checked)
                try
                {
                    xpression.SetTime((sender as TextBox).Text);
                } catch(Exception ext)
                {
                    Log(tbLog, ext.Message);
                }
        }

        private void rbYellowHome_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)

                    xpression.ShowCard(Club1, Player1, false);
        }

        private void rbRedHome_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)

                    xpression.ShowCard(Club1, Player1, true);
        }

        private void rbYellowGuest_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)

                    xpression.ShowCard(Club2, Player2, false);
        }

        private void rbRedGuest_CheckedChanged(object sender, EventArgs e)
        {
            if (xpression != null)
                if ((sender as RadioButton).Checked)

                    xpression.ShowCard(Club2, Player2, true);
        }

        private void nudGuestFouls_ValueChanged(object sender, EventArgs e)
        {
            gameSettings.GuestFouls = Convert.ToInt32((sender as NumericUpDown).Value);
            if (xpression != null)
                xpression.SetGuestFouls(gameSettings.GuestFouls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFreeGraphics frmFreeGraphics = new FrmFreeGraphics();
            frmFreeGraphics.Owner = this;
            if (frmFreeGraphics.ShowDialog() == DialogResult.OK)
            {
                rbClearGraphics.Checked = false;
            }
        }
    }
}
