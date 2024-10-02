namespace SurfsUpDan.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int SurfboardId { get; set; }
        public Surfboard Surfboard { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
    }


}
