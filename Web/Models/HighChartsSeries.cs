using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class HighchartsSeries
    {
        public string name { get; set; }
        public List<decimal> data { get; set; }
    }
}