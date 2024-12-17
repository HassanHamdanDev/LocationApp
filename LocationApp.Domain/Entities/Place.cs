using LocationApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Domain.Entities
{
    public class Place : EntityBase
    {
        public Place()
        {
            CreatedOn = DateTime.Now;
        }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Coordinate => $"{Latitude},{Longitude}";
    }
}
