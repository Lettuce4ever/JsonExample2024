using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample2024.Models
{
    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public int Population { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public override string ToString()
        {
            return $@"
Name: {Name}
Location: {Location}
Details:{Details}
Population:{Population}
Latitude:{Latitude}
Longitude:{Longitude}
";
        }
    }
}
