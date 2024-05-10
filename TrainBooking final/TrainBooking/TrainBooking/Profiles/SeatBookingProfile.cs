using AutoMapper;
using TrainBooking.Model;
using TrainBooking.DTO;
namespace TrainBooking.Profiles
{
    public class SeatBookingProfile:Profile
    {
        public SeatBookingProfile() 
        {
            CreateMap<SeatBooking, SeatBookingReadDTO>();
            CreateMap<SeatBookingCreateDTO, SeatBooking>();
        }
    }
}
