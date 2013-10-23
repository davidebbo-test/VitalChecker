using vitalchecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace vitalchecker.Controllers
{
    public class VitalsController : ApiController
    {
        Vital[] vitals = new Vital[]
        { 
            new Vital { Temperature = 104.3, Pulse = 10, Resporation = 10, BloodPressureD = 110, BloodPressureS = 115 }, 
            new Vital { Temperature = 104.3, Pulse = 10, Resporation = 10, BloodPressureD = 110, BloodPressureS = 115 }, 
            new Vital { Temperature = 104.3, Pulse = 10, Resporation = 10, BloodPressureD = 110, BloodPressureS = 115 }
        };

        public IEnumerable<Vital> GetAllVitals()
        {
            return vitals;
        }

        //public IHttpActionResult GetVital(int id)
        //{
        //    var product = products.FirstOrDefault((p) => p.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}


        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}