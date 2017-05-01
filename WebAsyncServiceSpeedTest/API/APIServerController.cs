using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAsyncServiceSpeedTest.API
{
    [Route("api/[controller]/[action]")]
    public class ServerController : Controller
    {
        [HttpGet]
        public JsonResult GetAPI1()
        {
            Thread.Sleep(1000);
            var record = new { id = 1 };
            return Json(record);
        }

        [HttpGet]
        public JsonResult GetAPI2()
        {
            Thread.Sleep(2000);
            var record = new { id = 2 };
            return Json(record);
        }
    }
}
