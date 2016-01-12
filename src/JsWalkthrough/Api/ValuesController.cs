namespace Api
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http;

    [Route("values")]
    public class ValuesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            var random = new Random();

            return new[]
            {
                random.Next(0, 10).ToString(),
                random.Next(0, 10).ToString()
            };
        }
    }
}