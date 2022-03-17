using NFLStatsAPI_roughDraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLStatsAPI_roughDraft.DataAccess
{
    public interface IDataAccessProvider
    {
        void UpdateTeam(Team team);
        void DeleteTeam(int id);
        Team GetTeamInfoById(int id);
        List<Team> GetTeams();
    }
}
