using AuditBenchmarkModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmarkModule.Repository
{
    public class BenchmarkRepo : IBenchmark
    {
        List<AuditBenchmark> AuditBenchmarkList = new List<AuditBenchmark>()
        {
            new AuditBenchmark
            {
                AuditType="Internal",
                BenchmarkNoAnswers=3
            },
            new AuditBenchmark
            {
                AuditType="SOX",
                BenchmarkNoAnswers=1
            }

        };
        public List<AuditBenchmark> GetNolist() 
        {
            return AuditBenchmarkList;
        }
    }
}
