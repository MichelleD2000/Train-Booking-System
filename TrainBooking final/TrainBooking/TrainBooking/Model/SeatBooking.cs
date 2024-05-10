using System.ComponentModel.DataAnnotations;
namespace TrainBooking.Model
{
    public class SeatBooking
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TrainName { get; set; }
        [Required]
        public string TrainDate { get; set; }
        [Required]
        public string TrainTime { get; set; }
        [Required]
        public string FromStation { get; set; }
        [Required]
        public string ToStation { get; set; }
        [Required]
        public string NIC { get; set; }
        [Required]
        public string PassengerName { get; set; }
        [Required]
        public string Numberofseats { get; set; }
    }

}
