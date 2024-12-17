using LocationApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Application.Places
{
    public class AddPlaceDto
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Result IsValid()
        {
            if (string.IsNullOrEmpty(Name))
            {
                return Functional.Failure("Name is required");
            }
            if (Latitude <= 0 || Longitude <= 0)
            {
                return Functional.Failure("Latitude and Longitude must be greater than 0");
            }

            return Functional.Success();
        }
    }
}
