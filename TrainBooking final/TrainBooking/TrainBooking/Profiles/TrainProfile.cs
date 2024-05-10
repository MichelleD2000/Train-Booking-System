using AutoMapper;
using TrainBooking.Model;
using TrainBooking.DTO;
namespace TrainBooking.Profiles
{
    public class TrainProfile:Profile
    {
        public TrainProfile() 
        {
            CreateMap<Train, TrainReadDTO>();
            CreateMap<TrainCreateDTO, Train>();
        }
    }
}
