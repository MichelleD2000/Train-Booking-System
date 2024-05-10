using Microsoft.AspNetCore.Mvc;
using TrainBooking.Model;
using TrainBooking.Data;
using TrainBooking.DTO;
using AutoMapper;
using System.Collections.Generic;

namespace TrainBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatBookingController : Controller
    {
        private readonly IMapper mapper; 
        private readonly SeatBookingRepository repository;

        public SeatBookingController(SeatBookingRepository seatBookingRepository, IMapper _mapper)
        {
            repository = seatBookingRepository;
            mapper = _mapper;
        }

        [HttpPost]
        public ActionResult CreateSeatBooking(SeatBookingCreateDTO seatbookingCreate)
        {
            var seatbooking = mapper.Map<SeatBooking>(seatbookingCreate);
            if (repository.CreateSeatBooking(seatbooking))
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet("{id}", Name = "GetByTrainName")]
        public ActionResult<SeatBookingRepository> GetSeatBooking(int id) 
        {
            var seatbooking = repository.GetSeatBooking(id);
            if (seatbooking != null)
                return Ok(mapper.Map<SeatBookingReadDTO>(seatbooking));
            else
                return NotFound();
        }

        [HttpGet]
        public ActionResult<IEnumerable<SeatBookingReadDTO>> GetSeatBookings() 
        {
            var seatbookings = repository.GetSeatBookings(); 
            return Ok(mapper.Map<IEnumerable<SeatBookingReadDTO>>(seatbookings));
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteSeatBooking(int id)
        {
            var seatbooking = repository.GetSeatBooking(id);
            if (seatbooking != null) 
            {
                repository.RemoveSeatBooking(seatbooking);
                return Ok();
            }
            else
                return NotFound();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateSeatBooking(int id, SeatBookingCreateDTO createDTO)
        {
            var seatbooking = mapper.Map<SeatBooking>(createDTO);
            seatbooking.Id = id;
            if (repository.UpdateSeatBooking(seatbooking)) 
                return Ok();
            else
                return NotFound();
        }
    }
}