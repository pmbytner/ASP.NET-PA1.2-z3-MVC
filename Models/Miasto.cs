using System.ComponentModel.DataAnnotations;

namespace ASP.NET_PA1._2_z3_MVC.Models
{
    public class Miasto
    {
        public int Id { get; set; }
        public string? Nazwa { get; set; }

        public uint? Populacja { get; set; }
        public decimal? Powierzchnia { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataZałożenia { get; set; }
        public string Województwo { get; set; }
    }
}
