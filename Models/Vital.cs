using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vitalchecker.Models
{
    public class Vital
    {
        public double Temperature { get; set; }
        public int Pulse { get; set; }
        public int Resporation { get; set; }
        public int BloodPressureS { get; set; }
        public int BloodPressureD { get; set; }

    }
}