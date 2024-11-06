using SurfsUpBlazor.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurfsUpBlazor.Models
{
    public class Surfboard
    {
        public int SurfboardId { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Thickness { get; set; }
        public double Volume { get; set; }
        public double PriceOfPurchase { get; set; }
        public string? Equipment { get; set; }
        public double HourlyPrice { get; set; }
    }
}
