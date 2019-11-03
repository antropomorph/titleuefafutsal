using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using titleuefafutsal.model;

namespace titleuefafutsal
{
    public partial class frmTeam : Form
    {
        BindingList<Team> teams;
        Team tempTeam;

        public frmTeam(List<Team> teams)
        {
            InitializeComponent();
            this.teams = new BindingList<Team>(teams);
            cbTeamList.DataSource = this.teams;
            cbTeamList.ValueMember = "ID";
            cbTeamList.DisplayMember = "Name";

            tbTeamName.DataBindings.Add("Text", this.teams, "Name");
            tbTeamNameShort.DataBindings.Add("Text", this.teams, "NameShort");
            //tbTeamNation.DataBindings.Add("Text", dtTeams, "TeamNation");
            //tbTeamNationShort.DataBindings.Add("Text", dtTeams, "TeamNationShort");
            tbTeamCoach.DataBindings.Add("Text", this.teams, "Coach");
            //tbTeamCoachTitle.DataBindings.Add("Text", dtTeams, "TeamCoachTitle");
            tbLogo.DataBindings.Add("Text", this.teams, "Logo");
        }

        private void miAddTeam_Click(object sender, EventArgs e)
        {
            tempTeam = this.teams.AddNew();
            cbTeamList.SelectedValue = tempTeam.ID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tempTeam.Name = tbTeamName.Text;
            tempTeam.NameShort = tbTeamNameShort.Text;
            tempTeam.Logo = tbLogo.Text;
            tempTeam.Coach = tbTeamCoach.Text;
            this.teams.
            //this.teams.Add(tempTeam);
        }
    }
}
