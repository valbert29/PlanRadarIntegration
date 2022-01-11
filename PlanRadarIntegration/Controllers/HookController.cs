using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PlanRadarIntegration.Models;

namespace PlanRadarIntegration.Controllers
{
    public class HookController : Controller
    {
        public async Task<IActionResult> Save()
        {
            string value;
            using (StreamReader reader = new StreamReader(Request.Body, null, detectEncodingFromByteOrderMarks:true))
            {
                value = await reader.ReadToEndAsync();
            }

            int id = 1;
            try
            {
                id = Program.Hooks.OrderByDescending(i => i.Id).First().Id + 1;
            }
            catch
            {
            }

            Program.Hooks.Add(new Hook { Created = DateTime.Now, IsParsed = false, IncomeAsString = value, Income = WebHookIncome.FromJson(value), Id = id });

            return Ok(200);
        }

        public string GetAll()
        {
            return string.Join(" \n", Program.Hooks.Select(x=>x.IncomeAsString));
        }
        
        
    }
}