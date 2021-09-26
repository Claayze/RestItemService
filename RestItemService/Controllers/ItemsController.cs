using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestItemService.Managers;
using ModelLib.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestItemService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ManageItems mgr = new ManageItems();

        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<FootBallPlayer> Get()
        {
            return mgr.Get();
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public FootBallPlayer Get(int id)
        {
            return mgr.Get(id);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public bool Post([FromBody] FootBallPlayer value)
        {
            return mgr.Create(value);
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] FootBallPlayer value)
        {
            return mgr.Update(id, value);
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public FootBallPlayer Delete(int id)
        {
           return mgr.Delete(id);
        }
    }
}
