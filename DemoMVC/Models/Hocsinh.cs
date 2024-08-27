using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Hocsinh
    {
        [Key]
        public string Tenhs { get; set;}
        public string Lophs { get; set;}
        public int Tuoi { get; set;}
    }
}