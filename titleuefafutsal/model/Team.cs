using System;
using System.Collections.Generic;

namespace titleuefafutsal.model
{
    public class Team
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string NameShort { get; set; }
        public string Coach { get; set; }
        public string CoachTitle { get; set; }
        public string Logo { get; set; }
        public string Color { get; set; }
        public List<Player> Players { get; set; }

        public string AttemptsOnTarget = "0";
        public string TotalAttempts = "0";
        public string Corners = "0";
        public string Fouls1 = "0";
        public string Fouls2 = "0";
        public string Yellow1 = "0";
        public string Yellow2 = "0";
        public string Red1 = "0";
        public string Red2 = "0";
        public string Score = "0";
    }
}
