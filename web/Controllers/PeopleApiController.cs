using models.Domain;
using services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Z.E.R.O_1.web.Controllers
{
    [RoutePrefix("api/person")]
    public class PeopleApiController : ApiController
    {
        private PeopleService _PeopleService;
        // GET api/<controller>
      [HttpGet]
      [Route]
      public HttpResponseMessage GetAll()
        {
            ItemViewModel<People> response = new ItemViewModel<People>();
            response.Item = _PeopleService.SelectAll();
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}