using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NFLStatsAPI_roughDraft.Models
{
    public class Team
    {
        //serialized teamID
        [Key]
        public int teamid { get; set; }
        //City & Mascot (i.e. Indianapolis Colts)
        public string name { get; set; } 
    }
}
