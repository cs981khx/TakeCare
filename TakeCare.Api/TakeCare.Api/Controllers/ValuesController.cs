using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Ajax.Utilities;
using TakeCare.Api.DAL;
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
        public void Post([FromBody]GBActivitySample[] activityFromBand)
        {
            //List<Activity> activities = MapActivityFromBandToDbActivity(activityFromBand);

            using (var db = new TakeCareContext())
            {

                var dbActivities = db.Set<Activity>();
                var dbDevices = db.Set<Device>();
                
                ////find a matching device and link it to activities
                //var device =
                //    dbDevices.FirstOrDefault(
                //        d => d.MacAddress.ToLower() == activityFromBand.FirstOrDefault().MacAddress.ToLower());
                //if (device != null) device.Activities = activities;

                //dbActivities.AddRange(activities);

                db.SaveChanges();
            }

        }

        private List<Activity> MapActivityFromBandToDbActivity(GBActivitySample activityFromBand)
        {
            List<Activity> activities = new List<Activity>();
            //foreach (GBActivitySample actBand in activityFromBand)
            //{
                var act = new Activity()
                {
                    TimeStamp = ConvertMilliSecondToDateTime(activityFromBand.Timestamp),
                    Category = activityFromBand.Type,
                    HeartRate = activityFromBand.CustomValue,
                    Intensity = activityFromBand.Intensity,
                    Steps = activityFromBand.Intensity
                };
            //}
            return activities;
        }

        private DateTime? ConvertMilliSecondToDateTime(int timestamp)
        {
            //TODO do a proper conversion later
            return DateTime.Now;
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
