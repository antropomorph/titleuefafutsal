using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using titleuefafutsal.model;

namespace titleuefafutsal
{
    public partial class frmTeam : Form
    {
        Team tempTeam = new Team();

        public frmTeam()
        {
            InitializeComponent();

            /*cbTeamList.DataSource = this.teams;
            cbTeamList.ValueMember = "ID";
            cbTeamList.DisplayMember = "Name";*/

            /* tbTeamName.DataBindings.Add("Text", this.teams, "Name");
            tbTeamNameShort.DataBindings.Add("Text", this.teams, "NameShort");
            //tbTeamNation.DataBindings.Add("Text", dtTeams, "TeamNation");
            //tbTeamNationShort.DataBindings.Add("Text", dtTeams, "TeamNationShort");
            tbTeamCoach.DataBindings.Add("Text", this.teams, "Coach");
            //tbTeamCoachTitle.DataBindings.Add("Text", dtTeams, "TeamCoachTitle");
            tbLogo.DataBindings.Add("Text", this.teams, "Logo");*/
        }

        private void miAddTeam_Click(object sender, EventArgs e)
        {
            /* tempTeam = this.teams.AddNew();
             cbTeamList.SelectedValue = tempTeam.ID;*/
        }

        private void teamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void frmTeam_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Player". При необходимости она может быть перемещена или удалена.
            this.playerTableAdapter.Fill(this.databaseDataSet.Player);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Team". При необходимости она может быть перемещена или удалена.
            this.teamTableAdapter.Fill(this.databaseDataSet.Team);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cdTeam.ShowDialog() == DialogResult.OK)
            {
                clubColorTextBox.Text = cdTeam.Color.ToArgb().ToString("X");
            }
        }

        private void clubColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != String.Empty)
            {
                (sender as TextBox).BackColor = Color.FromArgb(Convert.ToInt32((sender as TextBox).Text, 16));
            }
            else
            {
                (sender as TextBox).BackColor = SystemColors.Window;
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            if (ofdLogo.ShowDialog() == DialogResult.OK)
            {
                clubLogoTextBox.Text = ofdLogo.FileName;
                LoadPicture(ofdLogo.FileName);
            }
        }

        private void teamBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            tempTeam.ID = ((DataRowView)teamBindingSource.Current).Row["IDClub"].ToString();
            tempTeam.Name = ((DataRowView)teamBindingSource.Current).Row["ClubName"].ToString();
            tempTeam.NameShort = ((DataRowView)teamBindingSource.Current).Row["ClubNameShort"].ToString();

            LoadPicture(((DataRowView)teamBindingSource.Current).Row["ClubLogo"].ToString());
            playerBindingSource.Filter = "IDClub = " + tempTeam.ID;
        }

        private void playerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ((DataRowView)playerBindingSource.Current).Row["IDClub"] = tempTeam.ID;
            this.Validate();
            this.playerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void LoadPicture(string picturePath)
        {
            try
            {
                if (picturePath != string.Empty)
                    if (System.IO.File.Exists(picturePath))
                    {
                        pbClubLogo.ImageLocation = picturePath;
                        pbClubLogo.Load();
                    }
            }
            catch (Exception e)
            {

            }
        }

        private void frmTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
