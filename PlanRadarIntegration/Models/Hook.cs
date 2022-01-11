using System;

namespace PlanRadarIntegration.Models
{
    public class Hook
    {
            public int Id { get; set; }
            public WebHookIncome Income { get; set; }
            public string IncomeAsString { get; set; }
            // public Data.Log Parsed { get; set; }
            public DateTime Created { get; set; }
            public bool IsParsed { get; set; }
            public long CompanyId { get; set; }
    }
    
}