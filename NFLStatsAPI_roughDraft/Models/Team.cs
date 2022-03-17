using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLStatsAPI_roughDraft.Models
{
    public class Team
    {
        //serialized teamID
        public int teamid { get; set; }
        //City & Mascot (i.e. Indianapolis Colts)
        public string name { get; set; } 
    }
}
