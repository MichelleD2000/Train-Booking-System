using System.ComponentModel.DataAnnotations;
namespace TrainBooking.DTO
{
    public class SeatBookingCreateDTO
    {
        public string TrainName { get; set; }

        public string TrainDate { get; set; }

        public string TrainTime { get; set; }

        public string FromStation { get; set; }

        public string ToStation { get; set; }

        public string NIC { get; set; }

        public string PassengerName { get; set; }

        public string Numberofseats { get; set; }
    }
}
