using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Domain.Base
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
