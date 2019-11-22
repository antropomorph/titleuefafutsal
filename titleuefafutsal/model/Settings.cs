namespace titleuefafutsal.model
{
    public class Settings
    {
        public string Arena;
        public string DateTime;
        public string Referee;
        public string SecondReferee;
        public string ThirdOfficial;
        public string TimeKeeper;
        public bool SemiFinal = false;
        public string Period = "1st";
        public string TimePeriod = "HALF TIME";
        public string TimeServerAddress = "192.168.0.102";
        public string TimeServerPort = "12340";
        public bool UseTimeServer = true;

        public string Timer;
        public string  HomeScore = "0";
        public string GuestScore = "0";
        public int HomeFouls = 0;
        public int GuestFouls = 0;
    }
}