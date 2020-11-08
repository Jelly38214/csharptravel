using System.Reflection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;


namespace Faketravel.API.Controllers
{
    [Route("api/[Controller]")]
    public class TestAPIController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Value1", "Value3" };
        }
    }
}