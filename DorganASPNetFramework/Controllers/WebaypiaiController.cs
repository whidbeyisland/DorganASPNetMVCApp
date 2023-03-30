using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using DorganASPNetFramework;
using System.Net.Http.Headers;
using System.Text;

using System.Data.Entity.Infrastructure;
using System.Web.Http.Description;

namespace DorganASPNetFramework.Controllers
{
    public class WebaypiaiController : ApiController
    {
        private dorgandbEntities db = new dorgandbEntities();

        // GET: api/Webaypiai
        public IEnumerable<string> Get()
        {
            // return new string[] { "value1", "value2" };
            TestBEntity[] testBEntities = db.TestBEntities.ToArray<TestBEntity>();
            string[] toReturn = { "value1", "value2", "value3" };
            toReturn[2] = testBEntities.Length.ToString();
            return toReturn;
        }

        //public HttpResponseMessage Get()
        //{
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");
        //    response.Content = new StringContent("hello", Encoding.Unicode);
        //    response.Headers.CacheControl = new CacheControlHeaderValue()
        //    {
        //        MaxAge = TimeSpan.FromMinutes(20)
        //    };
        //    return response;
        //}

        //public IEnumerable<TestBEntity> GetTestBEntities()
        //{
        //    return db.TestBEntities.AsEnumerable();
        //}

        // GET: api/Webaypiai/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Webaypiai
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Webaypiai/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Webaypiai/5
        public void Delete(int id)
        {
        }
    }
}
