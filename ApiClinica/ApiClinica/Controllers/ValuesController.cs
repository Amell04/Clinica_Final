using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiClinica.Models;

namespace ApiClinica.Controllers
{
    public class ValuesController : ApiController
       
    {

        Modelo db = new Modelo();
        // GET api/values
        public IEnumerable<veterinario> Get()
        {
            return db.veterinario.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
