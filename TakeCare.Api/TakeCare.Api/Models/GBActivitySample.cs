using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TakeCare.Api.Models
{
    public class GBActivitySample
    {
        private int timeStamp;
        private int intensity;
        private int steps;
        private int type;
        private int customValue;
        private string macAddress;

        public int Timestamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        public int Intensity
        {
            get { return intensity; }
            set { intensity = value; }
        }
        public int Steps
        {
            get { return steps; }
            set { steps = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int CustomValue
        {
            get { return customValue; }
            set { customValue = value; }
        }

        public string MacAddress
        {
            get { return macAddress; }
            set { macAddress = value; }
        }

        public GBActivitySample() { }

        public GBActivitySample(int timestamp, int intensity, int steps, int type, int customValue)
        {
            this.timeStamp = timestamp;
            this.intensity = intensity;
            this.steps = steps;
            this.customValue = customValue;
            this.type = type;
        }

        public string ToString()
        {
            return "GBActivitySample{" +
                   "timestamp=" + timeStamp.ToString() +
                   ", intensity=" + intensity +
                   ", steps=" + steps +
                   ", customValue=" + customValue +
                   ", type=" + type +
                   '}';
        }
    }
}