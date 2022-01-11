using Microsoft.AspNetCore.Mvc;
using PlanRadarIntegration.Models;

namespace PlanRadarIntegration.Controllers
{
    public class AuthController:Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            return View();
        }
    }
}