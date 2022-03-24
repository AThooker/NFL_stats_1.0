using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NFLStatsAPI_roughDraft.DataAccess;
using NFLStatsAPI_roughDraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLStatsAPI_roughDraft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StandingsController : ControllerBase
    {
        private readonly IStandingsAccessProvider _standingsAccess;
        public StandingsController(IStandingsAccessProvider standingsAccess)
        {
            _standingsAccess = standingsAccess;
        }
        [HttpGet]
        public List<Standings> GetStandings()
        {
            var standings = _standingsAccess.GetStandings();
            var orderedStandings = standings.OrderBy(s => s.cnf);
            return orderedStandings.ToList();
        }
        [HttpGet("{id}")]
        public Standings GetStandingsByTeamId(int id)
        {
            return _standingsAccess.GetStandingsByTeamId(id);
        }

    }
}
