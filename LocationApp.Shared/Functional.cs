using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Shared
{
    public static class Functional
    {
        public static Result Success() 
        {
            var result = new Result();
            result.Success();

            return result;
        }

        public static Result Failure(string message)
        {
            var result = new Result();
            result.Fail(message);

            return result;
        }
    }
}
