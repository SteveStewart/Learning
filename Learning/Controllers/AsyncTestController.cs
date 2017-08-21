using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Learning.Controllers
{
    public class AsyncTestController : Controller
    {
        [HttpGet, Route("api/asynctest/GetTest")]
        public async Task<bool> GetTest()
        {
            var client = new HttpClient();
            await client.GetAsync("http://google.co.uk");
            return true;
        }

        [HttpGet, Route("api/asynctest/GetTestMultiple")]
        public async Task<bool> GetTestMultiple()
        {
            var url = @"Http://google.co.uk";
            var client = new HttpClient();
            
            var t1 = client.GetAsync(url);
            var t2 = client.GetByteArrayAsync("http://google.co.uk");

            await Task.WhenAll(t1, t2);

            return true;
        }
    }
}