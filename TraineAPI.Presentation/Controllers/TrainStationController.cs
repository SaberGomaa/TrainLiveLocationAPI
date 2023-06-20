using AutoMapper;
using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace TraineAPI.Presentation.Controllers
{
    [Route("api/TrainStation/[action]")]
    [ApiController]
    public class TrainStationController : ControllerBase
    {
        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;

        public TrainStationController(IMapper mapper , IRepositoryManegar repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetAllStationForTrain")]
        public IActionResult GetAllStationForTrain(int id)
        {
             var result = _repository.TrainInStationTime.GetAllTrainInStationTime().Where(c=>c.TrainId.Equals(id));

            var stations = _mapper.Map<IEnumerable<TrainInStationTimeDto>>(result);
                
            return Ok(stations);
            
        }

        [HttpPost]
        public IActionResult CreateTrainTimeForStation(TrainInStationTimeDto trainTime)
        {
            var t = _mapper.Map<TrainInStationTime>(trainTime);
            _repository.TrainInStationTime.CreateTrainInStationTime(t);
            _repository.Save();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTimeForStation(int TrainId , int StationId)
        {
            var r = _repository.TrainInStationTime.GetAllTrainInStationTime().Where(c=>c.TrainId.Equals(TrainId) && c.StationId.Equals(StationId)).FirstOrDefault();
            if(r != null)
            {
                _repository.TrainInStationTime.DeleteTrainInStationTime(r);
                _repository.Save();
                return Ok("Delete Successfully");
            }
            else
            {
                return BadRequest("Not Found");
            }
        }

    }
}
