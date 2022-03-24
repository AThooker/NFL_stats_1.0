using NFLStatsAPI_roughDraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLStatsAPI_roughDraft.DataAccess
{
    public class StandingsAccessProvider : IStandingsAccessProvider
    {
        private readonly PostgreSqlContext _context;
        public StandingsAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }
        public List<Standings> GetStandings()
        {
            return _context.standings.ToList();
        }

        public Standings GetStandingsByTeamId(int id)
        {
            var teamStandings = _context.standings.FirstOrDefault(t => t.team_id == id);
            return teamStandings;
        }
    }
}
