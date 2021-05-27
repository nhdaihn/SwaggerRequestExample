using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerRequestExample.Response
{
    public class SomeResponse : IExamplesProvider<SomeResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public SomeResponse GetExamples()
        {
            return new SomeResponse
            {
                Id = 10,
                Name = "Peter Packer",
                Age = 16
            };
        }
    }
}
