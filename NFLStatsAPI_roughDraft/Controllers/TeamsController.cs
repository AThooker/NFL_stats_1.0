using Microsoft.AspNetCore.Mvc;
using NFLStatsAPI_roughDraft.Models;
using System.Collections.Generic;
using NFLStatsAPI_roughDraft.DataAccess;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NFLStatsAPI_roughDraft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamAccessProvider _teamAccessProvider;
        public TeamsController(ITeamAccessProvider teamAccessProvider)
        {
            _teamAccessProvider = teamAccessProvider;
        }

        //No need for posting teams, not yet anyways
        // POST api/<TeamsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}


        // GET: api/<TeamsController>
        [HttpGet]
        public List<Team> Get()
        {
            return _teamAccessProvider.GetTeams();
        }

        // GET api/<TeamsController>/5
        [HttpGet("{id}")]
        public Team TeamDetails(int id)
        {
            return _teamAccessProvider.GetTeamInfoById(id);
        }

        

        // PUT api/<TeamsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Team team)
        {
            if(ModelState.IsValid)
            {
                _teamAccessProvider.UpdateTeam(team);
                return Ok();
            }
            return BadRequest();
        }

        // DELETE api/<TeamsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var team = _teamAccessProvider.GetTeamInfoById(id);
            if(team == null)
            {
                return NotFound();
            }
            _teamAccessProvider.DeleteTeam(id);
            return Ok();
        }
    }
}
