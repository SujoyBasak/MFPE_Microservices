using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AuditSeverityModule.Models;
using AuditSeverityModule.Providers;
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
        [HttpGet]
        public AuditRequest Get()
        {
            AuditRequest req = new AuditRequest();
            req.ProjectName = "Test";
            req.ProjectManagerName = "Sujoy B";
            req.ApplicationOwnerName = "Basak";
            AuditDetail ad = new AuditDetail();
            ad.Type = "Internal";
            //ad.Date = new DateTime(01, 01, 2020);
            Questions q = new Questions();

            q.Question1 = true;
            q.Question2 = true;
            q.Question3 = true;
            q.Question4 = true;
            q.Question5 = true;
            ad.questions = q;
            req.Auditdetails = ad;            

            return req;
        }

        // POST: api/AuditSeverity
        [HttpPost]
        public IActionResult Post([FromBody]AuditRequest req)    //Change Here
        {
            SeverityProvider obj = new SeverityProvider();

            var response=obj.SeverityResponse(req);
            if (response == null)
                return BadRequest();
            

            return Ok(response);
        }
        
    }
}
