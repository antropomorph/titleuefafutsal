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

        public void ShowGroupStandings(Team Club1, Team Club2, Team Club3, Team Club4)
        {
            xpBaseObject ClubName1, ClubName2, ClubName3, ClubName4,
                c1pts, c1p, c1w, c1d, c1l, c1gf, c1ga,
                c2pts, c2p, c2w, c2d, c2l, c2gf, c2ga,
                c3pts, c3p, c3w, c3d, c3l, c3gf, c3ga,
                c4pts, c4p, c4w, c4d, c4l, c4gf, c4ga;

            xpBaseShader ClubLogo1, ClubLogo2, ClubLogo3, ClubLogo4;
            xpMaterial ClubLogo1Material, ClubLogo2Material, ClubLogo3Material, ClubLogo4Material;

            if (Project != null)
            {
                _HideScene();
                Project.GetSceneByName("UFCL_FF_GroupStandings_HD", out CurrentScene);

                //Teams Name
                CurrentScene.GetObjectByName("ClubName1", out ClubName1);
                CurrentScene.GetObjectByName("ClubName2", out ClubName2);
                CurrentScene.GetObjectByName("ClubName3", out ClubName3);
                CurrentScene.GetObjectByName("ClubName4", out ClubName4);
                (ClubName1 as xpTextObject).Text = Club1.Name;
                (ClubName2 as xpTextObject).Text = Club2.Name;
                (ClubName3 as xpTextObject).Text = Club3.Name;
                (ClubName4 as xpTextObject).Text = Club4.Name;

                //Team1
                CurrentScene.GetObjectByName("ClubPTS1", out c1pts);
                CurrentScene.GetObjectByName("ClubP1", out c1p);
                CurrentScene.GetObjectByName("ClubW1", out c1w);
                CurrentScene.GetObjectByName("ClubD1", out c1d);
                CurrentScene.GetObjectByName("ClubL1", out c1l);
                CurrentScene.GetObjectByName("ClubGF1", out c1gf);
                CurrentScene.GetObjectByName("ClubGA1", out c1ga);

                (c1pts as xpTextObject).Text = Club1.PTS;
                (c1p as xpTextObject).Text = Club1.P;
                (c1w as xpTextObject).Text = Club1.W;
                (c1d as xpTextObject).Text = Club1.D;
                (c1l as xpTextObject).Text = Club1.L;
                (c1gf as xpTextObject).Text = Club1.GF;
                (c1ga as xpTextObject).Text = Club1.GA;


                //Team2
                CurrentScene.GetObjectByName("ClubPTS2", out c2pts);
                CurrentScene.GetObjectByName("ClubP2", out c2p);
                CurrentScene.GetObjectByName("ClubW2", out c2w);
                CurrentScene.GetObjectByName("ClubD2", out c2d);
                CurrentScene.GetObjectByName("ClubL2", out c2l);
                CurrentScene.GetObjectByName("ClubGF2", out c2gf);
                CurrentScene.GetObjectByName("ClubGA2", out c2ga);

                (c2pts as xpTextObject).Text = Club2.PTS;
                (c2p as xpTextObject).Text = Club2.P;
                (c2w as xpTextObject).Text = Club2.W;
                (c2d as xpTextObject).Text = Club2.D;
                (c2l as xpTextObject).Text = Club2.L;
                (c2gf as xpTextObject).Text = Club2.GF;
                (c2ga as xpTextObject).Text = Club2.GA;

                //Team3
                CurrentScene.GetObjectByName("ClubPTS3", out c3pts);
                CurrentScene.GetObjectByName("ClubP3", out c3p);
                CurrentScene.GetObjectByName("ClubW3", out c3w);
                CurrentScene.GetObjectByName("ClubD3", out c3d);
                CurrentScene.GetObjectByName("ClubL3", out c3l);
                CurrentScene.GetObjectByName("ClubGF3", out c3gf);
                CurrentScene.GetObjectByName("ClubGA3", out c3ga);

                (c3pts as xpTextObject).Text = Club3.PTS;
                (c3p as xpTextObject).Text = Club3.P;
                (c3w as xpTextObject).Text = Club3.W;
                (c3d as xpTextObject).Text = Club3.D;
                (c3l as xpTextObject).Text = Club3.L;
                (c3gf as xpTextObject).Text = Club3.GF;
                (c3ga as xpTextObject).Text = Club3.GA;

                //Team4
                CurrentScene.GetObjectByName("ClubPTS4", out c4pts);
                CurrentScene.GetObjectByName("ClubP4", out c4p);
                CurrentScene.GetObjectByName("ClubW4", out c4w);
                CurrentScene.GetObjectByName("ClubD4", out c4d);
                CurrentScene.GetObjectByName("ClubL4", out c4l);
                CurrentScene.GetObjectByName("ClubGF4", out c4gf);
                CurrentScene.GetObjectByName("ClubGA4", out c4ga);

                (c4pts as xpTextObject).Text = Club4.PTS;
                (c4p as xpTextObject).Text = Club4.P;
                (c4w as xpTextObject).Text = Club4.W;
                (c4d as xpTextObject).Text = Club4.D;
                (c4l as xpTextObject).Text = Club4.L;
                (c4gf as xpTextObject).Text = Club4.GF;
                (c4ga as xpTextObject).Text = Club4.GA;


                //Teams logos
                Project.GetMaterialByName("ClubLogo1", out ClubLogo1Material);
                ClubLogo1Material.GetShaderByName("Texture", out ClubLogo1);
                ClubLogo1.FileName = Club1.Logo;
                ClubLogo1.ReloadFile();

                Project.GetMaterialByName("ClubLogo2", out ClubLogo2Material);
                ClubLogo2Material.GetShaderByName("Texture", out ClubLogo2);
                ClubLogo2.FileName = Club2.Logo;
                ClubLogo2.ReloadFile();

                Project.GetMaterialByName("ClubLogo3", out ClubLogo3Material);
                ClubLogo3Material.GetShaderByName("Texture", out ClubLogo3);
                ClubLogo3.FileName = Club3.Logo;
                ClubLogo3.ReloadFile();

                Project.GetMaterialByName("ClubLogo4", out ClubLogo4Material);
                ClubLogo4Material.GetShaderByName("Texture", out ClubLogo4);
                ClubLogo4.FileName = Club4.Logo;
                ClubLogo4.ReloadFile();

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