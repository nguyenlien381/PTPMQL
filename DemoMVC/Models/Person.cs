using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    public class Person 
    {
        [Key]
        public string Căncướccôngdân { get; set;}
        public string Họtên { get; set;}
        public string Quêquán { get; set; }
    }   
}