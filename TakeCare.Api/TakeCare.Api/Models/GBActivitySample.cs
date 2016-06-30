using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TakeCare.Api.Models
{
    public class GBActivitySample
    {
        private string _timeStampString;
        private DateTime _timeStampDateTime;
        private int _intensity;
        private int _steps;
        private int _type;
        private int _customValue;
        private string _macAddress;

        public string Timestamp
        {
            get { return _timeStampString; }
            set
            {
                _timeStampString = value;
                DateTime.TryParse(_timeStampString, out _timeStampDateTime);
            }
        }

        public DateTime TimeStampDateTime
        {
            get { return _timeStampDateTime; }
            set { _timeStampDateTime = value; }
        }

        public int Intensity
        {
            get { return _intensity; }
            set { _intensity = value; }
        }
        public int Steps
        {
            get { return _steps; }
            set { _steps = value; }
        }

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int CustomValue
        {
            get { return _customValue; }
            set { _customValue = value; }
        }

        public string MacAddress
        {
            get { return _macAddress; }
            set { _macAddress = value; }
        }

        public string ToString()
        {
            return "GBActivitySample{" +
                   "timestamp=" + _timeStampString +
                   ", intensity=" + _intensity +
                   ", steps=" + _steps +
                   ", customValue=" + _customValue +
                   ", type=" + _type +
                   '}';
        }
    }
}