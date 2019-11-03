using System;
using XPression;

/*
 *TODO:
 * UFCL_FF_MatchID_HD (ShowMatchID):
 *  Добавить логотипы клубов
 *
 */


namespace titleuefafutsal.model
{
    class GXPression
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

        public void ShowMatchID(string ClubName1, string ClubName2, string Arena, string DateTime, bool Semifinal = false)
        {
            xpBaseObject clubName1, clubName2, arena, datetime, semifinal;

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

        public void ShowBigScore(string ClubName1, string ClubName2, string ClubScore1, string ClubScore2, string Period)
        {
            xpBaseObject clubname1, clubname2, clubscore1, clubscore2, period;

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
