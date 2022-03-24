using NFLStatsAPI_roughDraft.Models;
using System.Collections.Generic;

namespace NFLStatsAPI_roughDraft.DataAccess
{
    public interface IStandingsAccessProvider
    {
        List<Standings> GetStandings();
        Standings GetStandingsByTeamId(int id);
    }
}
