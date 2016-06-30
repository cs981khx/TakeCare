using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TakeCare.Api.Models
{
    public class ActivityReturn
    {
        public string MacAddress { get; set; }

        public string Description { get; set; }
        public int StepCount { get; set; }
        public string DateTimeStamp { get; set; }
        public int Intensity { get; set; }
        public string ActivityType { get; set; }
    }
}