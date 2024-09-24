using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Sinhvien
    {
        [Key]
        public string Masv { get; set; }
        public string Tensv { get; set; }
        public string Daichi { get; set; }
    }
}