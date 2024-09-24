using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set;}
        public string FullName { get; set;}
        public string Address { get; set;}
    }
}