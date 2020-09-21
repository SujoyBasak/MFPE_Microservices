using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditBenchmarkModule.Repository;
using AuditBenchmarkModule.Models;

namespace AuditBenchmarkModule.Providers
{
    public class BenchmarkProvider
    {
        BenchmarkRepo obj = new BenchmarkRepo();

        public List<AuditBenchmark> GetBenchmark()
        {
            return obj.GetNolist();
        }
    }
}
