using Microsoft.AspNetCore.Mvc;
using NFLStatsAPI_roughDraft.DataAccess;
using NFLStatsAPI_roughDraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NFLStatsAPI_roughDraft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public TeamsController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
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
            return _dataAccessProvider.GetTeams();
        }

        // GET api/<TeamsController>/5
        [HttpGet("{id}")]
        public Team TeamDetails(int id)
        {
            return _dataAccessProvider.GetTeamInfoById(id);
        }

        

        // PUT api/<TeamsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Team team)
        {
            if(ModelState.IsValid)
            {
                _dataAccessProvider.UpdateTeam(team);
                return Ok();
            }
            return BadRequest();
        }

        // DELETE api/<TeamsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var team = _dataAccessProvider.GetTeamInfoById(id);
            if(team == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteTeam(id);
            return Ok();
        }
    }
}
