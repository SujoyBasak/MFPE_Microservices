using AuditChecklistModule.Models;
using AuditChecklistModule.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditChecklistModule.Providers
{
    public class ChecklistProvider
    {
        Checklist obj = new Checklist();

        public List<Questions> QuestionsProvider(string type)
        {
            var list = obj.GetQuestions(type);

            if (list != null)
                return list;
            else
                return null;
        }
    }
}
