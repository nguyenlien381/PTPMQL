using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Employy
    {
        [Key]
        public int Ma { get; set;}
        public string Hoten { get; set;}
        public string Tuoi { get; set;}
        public string Diachi { get; set;}
    }
}