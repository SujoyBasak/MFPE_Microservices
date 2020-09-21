using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditBenchmarkModule.Models;
using AuditBenchmarkModule.Providers;
using AuditBenchmarkModule.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuditBenchmarkModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditBenchmarkController : ControllerBase   //Port 44386
    {
        // GET: api/AuditBenchmark
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                BenchmarkProvider obj = new BenchmarkProvider();
                return Ok(obj.GetBenchmark());
            }
            catch(Exception)
            {
                return Ok("Exception from AuditBenchmark");
            }
            
        }
       
    }
}
