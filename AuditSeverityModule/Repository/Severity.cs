﻿using AuditSeverityModule.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AuditSeverityModule.Repository
{
    public class Severity : ISeverity
    {
        Uri baseAddress = new Uri("https://localhost:44386/api");   //Port No.
        HttpClient client;

        public Severity()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;

        }
        
        public List<AuditBenchmark> Response(InternalQuestions request)
        {
            List<AuditBenchmark> ls = new List<AuditBenchmark>();

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/AuditBenchmark").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                ls = JsonConvert.DeserializeObject<List<AuditBenchmark>>(data);
            }
            return ls;
            

        }
    }
}
