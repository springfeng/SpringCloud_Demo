using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Steeltoe.Discovery.Client;

namespace api_Order.Controllers
{

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private readonly DiscoveryHttpClientHandler _handler;
        /// <summary>
        /// 调用产品服务的接口API
        /// </summary>
        private const string ProductUrl = "http://product/api/values";
        public ValuesController(IDiscoveryClient client, ILoggerFactory logFactory)
        {
            _handler = new DiscoveryHttpClientHandler(client);
        }


        [HttpGet("product")]
        public async Task<string> GoProductAsync()
        {
            var client = new HttpClient(_handler, false);
            return await client.GetStringAsync(ProductUrl);
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "order 8012";
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
