using AutoMapper;
using Contracts;
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
        public IActionResult GetAllStationForTrain()
        {
             var result = _repository.TrainInStationTime.GetAllTrainInStationTime();

            var stations = _mapper.Map<IEnumerable<TrainInStationTimeDto>>(result);
                
            return Ok(stations);
            
        }

    }
}
