using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Ajax.Utilities;
using TakeCare.Api;
using TakeCare.Api.Models;

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
        public HttpResponseMessage Post([FromBody]GBActivitySample[] activityFromBand)
        {
            if (activityFromBand == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "GBActivitySample[] array is null, please check the format of JSON being passed");
            }

            using (var db = new TakeCareEntities())
            {
                var dbActivities = db.Set<Activity>();

                List<Activity> activities = MapActivityFromBandToDbActivity(activityFromBand, db);

                db.Activities.AddRange(activities);

                var recordsUpdated = db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Number of records updated: " + recordsUpdated);
            }
        }

        private List<Activity> MapActivityFromBandToDbActivity(GBActivitySample[] activityFromBand, TakeCareEntities dbContext)
        {
            List<Activity> activities = new List<Activity>();
            foreach (GBActivitySample actBand in activityFromBand)
            {
                Device firstOrDefault = dbContext.Devices.FirstOrDefault(d => d.MacAddress.ToLower() == actBand.MacAddress.ToLower());
                var act = new Activity()
                {
                    TimeStamp = actBand.TimeStampDateTime,
                    Category = actBand.Type,
                    HeartRate = actBand.CustomValue,
                    Intensity = actBand.Intensity,
                    Steps = actBand.Steps,
                };
                activities.Add(act);
                //find a matching device and link it to activities
                //TODO new device needs adding
                act.Id_Device = firstOrDefault?.Id ?? 0;
            }
            return activities;
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
