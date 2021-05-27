using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerRequestExample.Request
{
    public class SomeRequest : IExamplesProvider<SomeRequest>
    {
        public int Id { get; set; }

        public SomeRequest GetExamples()
        {
            return new SomeRequest
            {
                Id = 10
            };
        }
    }
}
