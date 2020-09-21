using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AuditSeverityModule.Models;
using AuditSeverityModule.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AuditSeverityModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditSeverityController : ControllerBase
    {

        // POST: api/AuditSeverity
        [HttpPost]
        public void Post()
        {
            Severity obj = new Severity();
            obj.Response(new AuditRequest());            

        }
        
    }
}
