using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Ajax.Utilities;
using TakeCare.Api.DAL;

namespace TakeCare.Api.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]Activity deserializedActivity)
        {
            // deserialise the JSON  into object
            // insert them 
            //Device deserializedDevice = JsonConvert.DeserializeObject<Device>(jsonMacAddress);
            //Activity deserializedActivity = JsonConvert.DeserializeObject<Activity>(jsonDataFromDevice);

            using (var db = new TakeCareContext())
            {
                //var macadress = db.Devices
                //    .Where(d => d.MacAddress.ToLower() == deserializedDevice.MacAddress.ToLower())
                //    .FirstOrDefault();

                var activities = db.Set<Activity>();
                //foreach(Activity activity in deserializedActivity)
                //{
                    activities.Add(deserializedActivity);
                //}                

                db.SaveChanges();
            }

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
