using NFLStatsAPI_roughDraft.Models;
using System.Collections.Generic;
using System.Linq;

namespace NFLStatsAPI_roughDraft.DataAccess
{
    public class ScheduleAccessProvider : IScheduleAccessProvider
    {
        private readonly PostgreSqlContext _context;
        public ScheduleAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public Schedule GetScheduleByTeamId(int id)
        {
            return _context.schedules.FirstOrDefault(s => s.teamid == id);
        }

        public List<Schedule> GetSchedulesByYear(string season)
        {
            return _context.schedules.Where(s => s.season == season).ToList();
        }
    }
}
