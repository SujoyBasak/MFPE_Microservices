using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditChecklistModule.Models;
using AuditChecklistModule.Providers;
using AuditChecklistModule.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuditChecklistModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditChecklistController : ControllerBase
    {
        // GET: api/AuditChecklist
        [HttpGet("{auditType}")]
        public IActionResult Get(string auditType)
        {
            try
            {
                ChecklistProvider obj = new ChecklistProvider();

                var list = obj.QuestionsProvider(auditType);

                if (list != null)
                    return Ok(list);
            }
            catch(Exception)
            {
                return Ok("EXception from AuditChecklist");
            }
            return BadRequest("No input or Wrong Input");
            

            
        }        
    }
}
