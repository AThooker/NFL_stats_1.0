using NFLStatsAPI_roughDraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLStatsAPI_roughDraft.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;
        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }
        public List<Team> GetTeams()
        {
            return _context.teams.ToList();
        }
        public Team GetTeamInfoById(int id)
        {
            return _context.teams.FirstOrDefault(t => t.teamid == id);
        }

        public void UpdateTeam(Team team)
        {
            _context.teams.Update(team);
            _context.SaveChanges();
        }
        public void DeleteTeam(int id)
        {
            var team = _context.teams.FirstOrDefault(t => t.teamid == id);
            _context.teams.Remove(team);
            _context.SaveChanges();
        }

        //public void AddTeam(Team team)
        //{
            //_context.teams.Add(team)
        //}
    }
}
