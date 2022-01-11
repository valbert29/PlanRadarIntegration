using System.ComponentModel.DataAnnotations;

namespace PlanRadarIntegration.Models
{
    public class LoginModel
    {
        [DataType(DataType.Text), Required]
        public string Login { get; set; }
        [DataType(DataType.Password), Required]
        public string Password { get; set; }
    }
}