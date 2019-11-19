using System;
using System.Collections.Generic;
using XPression;

/*
 *TODO:
 * UFCL_FF_MatchID_HD (ShowMatchID):
 *  Добавить логотипы клубов
 *
 */


namespace titleuefafutsal.model
{
    class xpPlayer
    {
        public xpBaseObject PlayerName;
        public xpBaseObject PlayerSurname;
        public xpBaseObject PlayerNumber;
        public xpBaseObject PlayerRole;
    }

    public class GXPression
    {
        private xpEngine Project;
        private xpScene CurrentScene;

        public GXPression(string FileName)
        {
            try
            {
                Project = new xpEngine();
                Project.LoadProject(FileName);
                CurrentScene = new xpScene();
            }
            catch (Exception e)
            {
                ErrorHandler.ShowError(e.Message);
            }
        }

        //UFCL_FF_MatchID_HD

        public void ShowMatchID(string ClubName1, string ClubName2, string Club1Logo, string Club2Logo, string Arena, string DateTime, bool Semifinal = false)
        {
            xpBaseObject clubName1, clubName2, arena, datetime, semifinal;
            xpBaseShader club1Logo, club2Logo;
            xpMaterial club1LogoMaterial, club2LogoMaterial;

            if (Project != null)
            {
                _HideScene();
                Project.GetSceneByName("UFCL_FF_MatchID_HD", out CurrentScene);

                CurrentScene.GetObjectByName("ClubName1", out clubName1);
                CurrentScene.GetObjectByName("ClubName2", out clubName2);
                CurrentScene.GetObjectByName("Arena", out arena);
                CurrentScene.GetObjectByName("DateTime", out datetime);
                CurrentScene.GetObjectByName("SemiFinal", out semifinal);

                (semifinal as xpTextObject).Visible = Semifinal;
                (clubName1 as xpTextObject).Text = ClubName1;
                (clubName2 as xpTextObject).Text = ClubName2;
                (arena as xpTextObject).TextWithTags = Arena;
                (datetime as xpTextObject).Text = DateTime;

                Project.GetMaterialByName("ClubLogo1", out club1LogoMaterial);
                club1LogoMaterial.GetShaderByName("Texture", out club1Logo);
                club1Logo.FileName = Club1Logo;
                club1Logo.ReloadFile();

                Project.GetMaterialByName("ClubLogo2", out club2LogoMaterial);
                club2LogoMaterial.GetShaderByName("Texture", out club2Logo);
                club2Logo.FileName = Club2Logo;
                club2Logo.ReloadFile();

                //CurrentScene.SceneDirector.Position = 0;
                CurrentScene.SceneDirector.Play();
                CurrentScene.SetOnline(0);
            }
        }

        public void ShowOfficials(string Referee, string SecondReferee, string ThirdOfficial, string TimeKeeper)
        {
            xpBaseObject referee, secondReferee, thirdOfficial, timeKeeper;

            if (Project != null)
            {
                _HideScene();
                Project.GetSceneByName("UFCL_LT_MatchOfficials_HD", out CurrentScene);

                CurrentScene.GetObjectByName("Referee", out referee);
                CurrentScene.GetObjectByName("SecondReferee", out secondReferee);
                CurrentScene.GetObjectByName("ThirdOfficial", out thirdOfficial);
                CurrentScene.GetObjectByName("TimeKeeper", out timeKeeper);

                (referee as xpTextObject).TextWithTags = Referee;
                (secondReferee as xpTextObject).TextWithTags = SecondReferee;
                (thirdOfficial as xpTextObject).TextWithTags = ThirdOfficial;
                (timeKeeper as xpTextObject).TextWithTags = TimeKeeper;

                //CurrentScene.SceneDirector.Position = 0;
                CurrentScene.SceneDirector.Play();
                CurrentScene.SetOnline(0);
            }
        }

        public void ShowBigScore(string ClubName1, string ClubName2, string Club1Logo, string Club2Logo, string ClubScore1, string ClubScore2, string Period)
        {
            xpBaseObject clubname1, clubname2, clubscore1, clubscore2, period;
            xpBaseShader club1Logo, club2Logo;
            xpMaterial club1LogoMaterial, club2LogoMaterial;

            if (Project != null)
            {
                _HideScene();
                Project.GetSceneByName("UFCL_LT_HT_FT_HD", out CurrentScene);

                CurrentScene.GetObjectByName("ClubName1", out clubname1);
                CurrentScene.GetObjectByName("ClubName2", out clubname2);
                CurrentScene.GetObjectByName("ClubScore1", out clubscore1);
                CurrentScene.GetObjectByName("ClubScore2", out clubscore2);
                CurrentScene.GetObjectByName("Period", out period);

                (clubname1 as xpTextObject).Text = ClubName1;
                (clubname2 as xpTextObject).Text = ClubName2;
                (clubscore1 as xpTextObject).Text = ClubScore1;
                (clubscore2 as xpTextObject).Text = ClubScore2;
                (period as xpTextObject).Text = Period;

                Project.GetMaterialByName("ClubLogo1", out club1LogoMaterial);
                club1LogoMaterial.GetShaderByName("Texture", out club1Logo);
                club1Logo.FileName = Club1Logo;
                club1Logo.ReloadFile();

                Project.GetMaterialByName("ClubLogo2", out club2LogoMaterial);
                club2LogoMaterial.GetShaderByName("Texture", out club2Logo);
                club2Logo.FileName = Club2Logo;
                club2Logo.ReloadFile();

                //CurrentScene.SceneDirector.Position = 0;
                CurrentScene.SceneDirector.Play();
                CurrentScene.SetOnline(0);

            }
        }

        public void ShowBallPossession(string ClubPossession1, string ClubPossession2, string Club1Logo, string Club2Logo)
        {
            xpBaseObject clubPossession1, clubPossession2;
            xpBaseShader club1Logo, club2Logo;
            xpMaterial club1LogoMaterial, club2LogoMaterial;

            if (Project != null)
            {
                _HideScene();
                Project.GetSceneByName("UFCL_OverlayClock_BallPossession_HD", out CurrentScene);

                CurrentScene.GetObjectByName("ClubPossession1", out clubPossession1);
                CurrentScene.GetObjectByName("ClubPossession2", out clubPossession2);

                (clubPossession1 as xpTextObject).Text = ClubPossession1;
                (clubPossession2 as xpTextObject).Text = ClubPossession2;


                Project.GetMaterialByName("ClubLogo1", out club1LogoMaterial);
                club1LogoMaterial.GetShaderByName("Texture", out club1Logo);
                club1Logo.FileName = Club1Logo;
                club1Logo.ReloadFile();

                Project.GetMaterialByName("ClubLogo2", out club2LogoMaterial);
                club2LogoMaterial.GetShaderByName("Texture", out club2Logo);
                club2Logo.FileName = Club2Logo;
                club2Logo.ReloadFile();

                //CurrentScene.SceneDirector.Position = 0;
                CurrentScene.SceneDirector.Play();
                CurrentScene.SetOnline(0);
            }
        }

        public void ShowTimeout(string ClubLogo)
        {
            xpBaseShader clubLogo;
            xpMaterial clubLogoMaterial;

            if (Project != null)
            {
                _HideScene();
                Project.GetSceneByName("UFCL_LT_TimeOut_HD", out CurrentScene);

                Project.GetMaterialByName("ClubLogo", out clubLogoMaterial);
                clubLogoMaterial.GetShaderByName("Texture", out clubLogo);
                clubLogo.FileName = ClubLogo;
                clubLogo.ReloadFile();

                //CurrentScene.SceneDirector.Position = 0;
                CurrentScene.SceneDirector.Play();
                CurrentScene.SetOnline(0);
            }
        }

        public void ShowCoach(string ClubLogo, string CoachName, string CoachTitle)
        {
            xpBaseShader clubLogo;
            xpMaterial clubLogoMaterial;
            xpBaseObject coachName, coachTitle;

            if (Project != null)
            {
                _HideScene();
                Project.GetSceneByName("UFCL_OverlayClock_CoachID_HD", out CurrentScene);

                CurrentScene.GetObjectByName("CoachName", out coachName);
                CurrentScene.GetObjectByName("CoachTitle", out coachTitle);

                (coachName as xpTextObject).Text = CoachName;
                (coachTitle as xpTextObject).Text = CoachTitle;

                Project.GetMaterialByName("ClubLogo", out clubLogoMaterial);
                clubLogoMaterial.GetShaderByName("Texture", out clubLogo);
                clubLogo.FileName = ClubLogo;
                clubLogo.ReloadFile();

                //CurrentScene.SceneDirector.Position = 0;
                CurrentScene.SceneDirector.Play();
                CurrentScene.SetOnline(0);
            }
        }

        public void ShowTeam(string ClubLogo, string ClubName, string CoachName, List<Player> ClubTeam)
        {
            xpBaseShader clubLogo;
            xpMaterial clubLogoMaterial;
            xpBaseObject clubName, coachName;
            //Dictionary<xpBaseObject, xpBaseObject> clubTeam;
            List<xpPlayer> clubTeam = new List<xpPlayer>();

            if (Project != null)
            {
                _HideScene();
                Project.GetSceneByName("UFCL_FF_Lineup_list_HD", out CurrentScene);

                CurrentScene.GetObjectByName("ClubName", out clubName);
                CurrentScene.GetObjectByName("CoachName", out coachName);

                (clubName as xpTextObject).Text = ClubName;
                (coachName as xpTextObject).Text = CoachName;

                for (int i = 0; i < ClubTeam.Count; i++)
                {
                    xpPlayer temp = new xpPlayer();
                    CurrentScene.GetObjectByName("PlayerName" + (i + 1).ToString(), out temp.PlayerName);
                    CurrentScene.GetObjectByName("PlayerNumber" + (i + 1).ToString(), out temp.PlayerNumber);
                    clubTeam.Add(temp);
                }

                for (int i = 0; i < ClubTeam.Count; i++)
                {
                    string _playerName;
                    if (ClubTeam[i].Role != string.Empty)
                    {
                        _playerName = ClubTeam[i].Surname + " {fntPlayerNormal}(" + ClubTeam[i].Role + ")";
                    }
                    else
                    {
                        _playerName = ClubTeam[i].Surname;
                    }

                    (clubTeam[i].PlayerName as xpTextObject).TextWithTags = _playerName;
                    (clubTeam[i].PlayerName as xpTextObject).Visible = true;
                    (clubTeam[i].PlayerNumber as xpTextObject).Text = ClubTeam[i].Number;
                    (clubTeam[i].PlayerNumber as xpTextObject).Visible = true;
                }

                Project.GetMaterialByName("ClubLogo", out clubLogoMaterial);
                clubLogoMaterial.GetShaderByName("Texture", out clubLogo);
                clubLogo.FileName = ClubLogo;
                clubLogo.ReloadFile();

                //CurrentScene.SceneDirector.Position = 0;
                CurrentScene.SceneDirector.Play();
                CurrentScene.SetOnline(0);
            }
        }

        public void ShowStatistics(Team Club1, Team Club2, Settings settings)
        {
            xpBaseObject club1Name, club2Name, Period,
                ClubAttemptsOnTarget1, ClubTotalAttempts1, ClubCorners1, ClubFouls1st1, ClubFouls2nd1, ClubYellow1st1, ClubYellow2nd1, ClubRed1st1, ClubRed2nd1, ClubScore1,
                ClubAttemptsOnTarget2, ClubTotalAttempts2, ClubCorners2, ClubFouls1st2, ClubFouls2nd2, ClubYellow1st2, ClubYellow2nd2, ClubRed1st2, ClubRed2nd2, ClubScore2;
            xpBaseShader club1Logo, club2Logo;
            xpMaterial club1LogoMaterial, club2LogoMaterial;

            if (Project != null)
            {
                _HideScene();
                Project.GetSceneByName("UFCL_FF_MatchSummary_HT_FT_HD", out CurrentScene);

                CurrentScene.GetObjectByName("ClubName1", out club1Name);
                CurrentScene.GetObjectByName("ClubName2", out club2Name);
                (club1Name as xpTextObject).Text = Club1.Name;
                (club2Name as xpTextObject).Text = Club2.Name;

                CurrentScene.GetObjectByName("Period", out Period);
                (Period as xpTextObject).Text = settings.TimePeriod;

                //Team1
                CurrentScene.GetObjectByName("ClubAttemptsOnTarget1", out ClubAttemptsOnTarget1);
                CurrentScene.GetObjectByName("ClubTotalAttempts1", out ClubTotalAttempts1);
                CurrentScene.GetObjectByName("ClubCorners1", out ClubCorners1);
                CurrentScene.GetObjectByName("ClubFouls1st1", out ClubFouls1st1);
                CurrentScene.GetObjectByName("ClubFouls2nd1", out ClubFouls2nd1);
                CurrentScene.GetObjectByName("ClubYellow1st1", out ClubYellow1st1);
                CurrentScene.GetObjectByName("ClubYellow2nd1", out ClubYellow2nd1);
                CurrentScene.GetObjectByName("ClubRed1st1", out ClubRed1st1);
                CurrentScene.GetObjectByName("ClubRed2nd1", out ClubRed2nd1);
                CurrentScene.GetObjectByName("ClubScore1", out ClubScore1);

                (ClubAttemptsOnTarget1 as xpTextObject).Text = Club1.AttemptsOnTarget;
                (ClubTotalAttempts1 as xpTextObject).Text = Club1.TotalAttempts;
                (ClubCorners1 as xpTextObject).Text = Club1.Corners;
                (ClubFouls1st1 as xpTextObject).Text = Club1.Fouls1;
                (ClubFouls2nd1 as xpTextObject).Text = Club1.Fouls2;
                (ClubYellow1st1 as xpTextObject).Text = Club1.Yellow1;
                (ClubYellow2nd1 as xpTextObject).Text = Club1.Yellow2;
                (ClubRed1st1 as xpTextObject).Text = Club1.Red1;
                (ClubRed2nd1 as xpTextObject).Text = Club1.Red2;
                (ClubScore1 as xpTextObject).Text = Club1.Score;

                //Team2
                CurrentScene.GetObjectByName("ClubAttemptsOnTarget2", out ClubAttemptsOnTarget2);
                CurrentScene.GetObjectByName("ClubTotalAttempts2", out ClubTotalAttempts2);
                CurrentScene.GetObjectByName("ClubCorners2", out ClubCorners2);
                CurrentScene.GetObjectByName("ClubFouls1st2", out ClubFouls1st2);
                CurrentScene.GetObjectByName("ClubFouls2nd2", out ClubFouls2nd2);
                CurrentScene.GetObjectByName("ClubYellow1st2", out ClubYellow1st2);
                CurrentScene.GetObjectByName("ClubYellow2nd2", out ClubYellow2nd2);
                CurrentScene.GetObjectByName("ClubRed1st2", out ClubRed1st2);
                CurrentScene.GetObjectByName("ClubRed2nd2", out ClubRed2nd2);
                CurrentScene.GetObjectByName("ClubScore2", out ClubScore2);

                (ClubAttemptsOnTarget2 as xpTextObject).Text = Club2.AttemptsOnTarget;
                (ClubTotalAttempts2 as xpTextObject).Text = Club2.TotalAttempts;
                (ClubCorners2 as xpTextObject).Text = Club2.Corners;
                (ClubFouls1st2 as xpTextObject).Text = Club2.Fouls1;
                (ClubFouls2nd2 as xpTextObject).Text = Club2.Fouls2;
                (ClubYellow1st2 as xpTextObject).Text = Club2.Yellow1;
                (ClubYellow2nd2 as xpTextObject).Text = Club2.Yellow2;
                (ClubRed1st2 as xpTextObject).Text = Club2.Red1;
                (ClubRed2nd2 as xpTextObject).Text = Club2.Red2;
                (ClubScore2 as xpTextObject).Text = Club2.Score;


                Project.GetMaterialByName("ClubLogo1", out club1LogoMaterial);
                club1LogoMaterial.GetShaderByName("Texture", out club1Logo);
                club1Logo.FileName = Club1.Logo;
                club1Logo.ReloadFile();

                Project.GetMaterialByName("ClubLogo2", out club2LogoMaterial);
                club2LogoMaterial.GetShaderByName("Texture", out club2Logo);
                club2Logo.FileName = Club2.Logo;
                club2Logo.ReloadFile();

                CurrentScene.SceneDirector.Play();
                CurrentScene.SetOnline(0);
            }
        }

        //UFCL_PermClock_HD
        public void ShowUpscore(Team Club1, Team Club2, Settings settings)
        {
            xpBaseObject ClubName1, ClubName2, ClubScore1, ClubScore2, Period;
            xpBaseShader club1Color, club2Color;
            xpMaterial club1ColorMaterial, club2ColorMaterial;

            if (Project != null)
            {
                _HideScene();
                Project.GetSceneByName("UFCL_PermClock_HD", out CurrentScene);

                CurrentScene.GetObjectByName("ClubName1", out ClubName1);
                CurrentScene.GetObjectByName("ClubName2", out ClubName2);
                CurrentScene.GetObjectByName("ClubScore1", out ClubScore1);
                CurrentScene.GetObjectByName("ClubScore2", out ClubScore2);
                CurrentScene.GetObjectByName("Period", out Period);

                (ClubName1 as xpTextObject).Text = Club1.NameShort;
                (ClubName2 as xpTextObject).Text = Club2.NameShort;
                (ClubScore1 as xpTextObject).Text = Club1.Score;
                (ClubScore2 as xpTextObject).Text = Club2.Score;
                (Period as xpTextObject).Text = settings.Period;


                /*Project.GetMaterialByName("ClubLogo1", out club1LogoMaterial);
                club1LogoMaterial.GetShaderByName("Texture", out club1Logo);
                club1Logo.FileName = Club1Logo;
                club1Logo.ReloadFile();

                Project.GetMaterialByName("ClubLogo2", out club2LogoMaterial);
                club2LogoMaterial.GetShaderByName("Texture", out club2Logo);
                club2Logo.FileName = Club2Logo;
                club2Logo.ReloadFile();*/

                //CurrentScene.SceneDirector.Position = 0;
                CurrentScene.SceneDirector.Play();
                CurrentScene.SetOnline(0);
            }
        }
        public void ShowPlayer(string ClubLogo, string PlayerNumber, string PlayerName)
        {
            xpBaseShader clubLogo;
            xpMaterial clubLogoMaterial;
            xpBaseObject PlayerNameNumber;

            if (Project != null)
            {
                _HideScene();
                Project.GetSceneByName("UFCL_OverlayClock_PlayerID_HD", out CurrentScene);

                CurrentScene.GetObjectByName("PlayerNameNumber", out PlayerNameNumber);

                (PlayerNameNumber as xpTextObject).Text = PlayerNumber + " " + PlayerName;

                Project.GetMaterialByName("ClubLogo", out clubLogoMaterial);
                clubLogoMaterial.GetShaderByName("Texture", out clubLogo);
                clubLogo.FileName = ClubLogo;
                clubLogo.ReloadFile();

                //CurrentScene.SceneDirector.Position = 0;
                CurrentScene.SceneDirector.Play();
                CurrentScene.SetOnline(0);
            }
        }

        public bool HideScene()
        {
            if (Project != null)
            {
                if (CurrentScene.SceneDirector.PlayState == PlayState.ps_Playing)
                    return false;
                _HideScene();
            }
            return true;
        }

        private void _HideScene()
        {
            if (Project != null && CurrentScene.Name != null)
            {
                CurrentScene.SceneDirector.Play(true);
            }
        }

        public void KillAll()
        {
            Project.ClearFrameBuffer(0);
        }
    }
}