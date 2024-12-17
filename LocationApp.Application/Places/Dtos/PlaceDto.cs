using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Application.Places
{
    public class PlaceDto
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Coordinate { get; set; }
    }
}
