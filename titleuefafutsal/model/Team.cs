using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titleuefafutsal.model
{
    public class Team
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string NameShort { get; set; }
        public string Coach { get; set; }
        public string Logo { get; set; }
        public string Color { get; set; }
        public List<Player> Players { get; set; }

        public Team()
        {
            this.ID = Guid.NewGuid().ToString();
        }
    }
}
