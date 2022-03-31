using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NFLStatsAPI_roughDraft.Models
{
    public class Schedule
    {
        [Key]
        public int scheduleID { get; set; }
        [ForeignKey(nameof(team))]
        public int teamid { get; set; }
        public string team { get; set; }
        public string season { get; set; }
        public string week_1 { get; set; }
        public string week_2 { get; set; }
        public string week_3 { get; set; }
        public string week_4 { get; set; }
        public string week_5 { get; set; }
        public string week_6 { get; set; }
        public string week_7 { get; set; }
        public string week_8 { get; set; }
        public string week_9 { get; set; }
        public string week_10 { get; set; }
        public string week_11 { get; set; }
        public string week_12 { get; set; }
        public string week_13 { get; set; }
        public string week_14 { get; set; }
        public string week_15 { get; set; }
        public string week_16 { get; set; }
        public string week_17 { get; set; }
        public string week_18 { get; set; }
    }
}
