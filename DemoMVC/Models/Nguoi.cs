using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DemoMVC.Models
{
    [Table("Nguoi")]
    public class Nguoi
    {
        [Key]
        public string? Id { get; set;}
        public string? Name { get; set;}
        public string Addrest { get; set; }

    }
}