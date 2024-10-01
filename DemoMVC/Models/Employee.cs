using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Employee : Person
    {
        public string Mã { get; set;}
        public string Điệnthoai { get; set;}
    }
}