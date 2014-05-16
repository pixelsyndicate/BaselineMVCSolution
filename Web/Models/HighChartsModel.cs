using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class HighchartsModel
    {
        public List<string> Categories { get; set; }
        public List<HighchartsSeries> Series { get; set; }
    }
}