using NFLStatsAPI_roughDraft.Models;
using System.Collections.Generic;

namespace NFLStatsAPI_roughDraft.DataAccess
{
    public interface IScheduleAccessProvider
    {
        Schedule GetScheduleByTeamId(int id);
        List<Schedule> GetSchedulesByYear(string season);
    }
}
