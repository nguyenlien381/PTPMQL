using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Daily
    {
        [Key]
        public string MaDaily { get; set;}
        public string TenDaily { get; set;}
        public string Diachi { get; set; }
        public string NguoiDaidien { get;set; }
        public string Dienthoai { get; set; }

    }
}