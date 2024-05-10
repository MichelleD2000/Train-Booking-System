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
    public class TrainController : Controller
    {
        private readonly IMapper mapper;
        private readonly TrainRepository repository;

        public TrainController(TrainRepository trainRepository, IMapper _mapper)
        {
            repository = trainRepository;
            mapper = _mapper;
        }

        [HttpPost]
        public ActionResult CreateTrain(TrainCreateDTO trainCreate)
        {
            var train = mapper.Map<Train>(trainCreate);
            if (repository.CreateTrain(train))
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet("{id}", Name = "GetByID")]
        public ActionResult<TrainRepository> GetTrain(int id)
        {
            var train = repository.GetTrain(id);
            if (train != null)
                return Ok(mapper.Map<TrainReadDTO>(train));
            else
                return NotFound();
        }

        [HttpGet]
        public ActionResult<IEnumerable<TrainReadDTO>> GetTrains()
        {
            var trains = repository.GetTrains();
            return Ok(mapper.Map<IEnumerable<TrainReadDTO>>(trains));
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTrain(int id)
        {
            var train = repository.GetTrain(id);
            if (train != null)
            {
                repository.RemoveTrain(train);
                return Ok();
            }
            else
                return NotFound();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateTrain(int id, TrainCreateDTO createDTO)
        {
            var train = mapper.Map<Train>(createDTO);
            train.Id = id;
            if (repository.UpdateTrain(train))
                return Ok();
            else
                return NotFound();
        }
    }
}
