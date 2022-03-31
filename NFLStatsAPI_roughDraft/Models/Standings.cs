using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NFLStatsAPI_roughDraft.Models
{
    public class Standings
    {
        [Key]
        public int standingsId { get; set; }
        [ForeignKey(nameof(teamName))]
        public int team_id { get; set; }
        public virtual string teamName { get; set; }
        public string season { get; set; }
        //Number of Games Played
        public int g { get; set; }
        //Wins
        public int w { get; set; }
        //losses
        public int l { get; set; }
        public int t { get; set; }
        public decimal w_to_l_percent { get; set; }
        //points for
        public int pf { get; set; }
        //points allowed
        public int pa { get; set; }
        //points differential Scored - Allowed
        public int pd { get; set; }
        //margin of victory (Points Scored - Points Allowed) / Games Played
        public decimal mov { get; set; }
        //strength of schedule
        public decimal sos { get; set; }
        //Simple Rating System, Team quality compared to average
        public decimal srs { get; set; }
        //Offensive SRS
        public decimal osrs { get; set; }
        //Defensive SRS
        public decimal dsrs { get; set; }
        //conference
        public string cnf { get; set; }
        public string div_leader { get; set; }
        public string wild_card { get; set; }
    }
}
