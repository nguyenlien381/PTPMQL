using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Phanphoi
    {
        [Key]
        public string? Nhaphanphoi { get; set;}
        public string? Maphanphoi { get; set;}
    }
}