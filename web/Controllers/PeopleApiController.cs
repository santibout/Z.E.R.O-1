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
    [RoutePrefix("api")]
    
    public class PeopleApiController : ApiController
    {
        PeopleService personService = new PeopleService();
        // GET api/<controller>
        [Route("person"), HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                ItemViewModel2<People> response = new ItemViewModel2<People>();
                response.Items = personService.SelectAll();
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // GET api/<controller>/5
        [Route("person/{id:int}"), HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                ItemResponse<People> response = new ItemResponse<People>();
                response.Item = personService.SelectById(id);

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // POST api/<controller>
        [Route("person/manage"), HttpPost]
        public HttpResponseMessage Insert(PeopleAddRequest model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                ItemResponse<int> response = new ItemResponse<int>();
                response.Item = personService.Insert(model);

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // PUT api/<controller>/5
        [Route("person/{id:int}"), HttpPut]
        public HttpResponseMessage Update(PeopleUpdateRequest model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                personService.Update(model);
                return Request.CreateResponse(HttpStatusCode.OK, new SuccessResponse());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // DELETE api/<controller>/5
        [Route("person/{id:int}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                personService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new SuccessResponse());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}