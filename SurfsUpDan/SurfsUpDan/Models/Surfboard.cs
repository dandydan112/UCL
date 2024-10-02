namespace SurfsUpDan.Models
{
    public class Surfboard
    {
        public int SurfboardId { get; set; }
        public string Name { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Thickness { get; set; }
        public float Volume { get; set; }
        public string Type { get; set; }
        public decimal PricePerDay { get; set; }
        public string Equipment { get; set; }
    }


}
