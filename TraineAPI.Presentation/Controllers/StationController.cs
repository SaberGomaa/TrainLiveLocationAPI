using AutoMapper;
using Contracts;
using Entites;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace TraineAPI.Presentation.Controllers
{

    [Route("api/station/[action]")]

    [ApiController]
    public class StationController:ControllerBase
    {

        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;

        public StationController(IRepositoryManegar repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //لما تيجى تضيف محطة يبقى هتضيف كل المحطات اللى هيعدى عليها القطر الواحد بنفس id
        //لما تيجى تضيف كمان قطر وتضيفلة محطات هتكرر نفس العملية ملكش دعوة المحطة موجوده قبل كدا ولا لا 

        [HttpGet(Name = "GetAllStation")]
        public IActionResult GetAllStation()
        {
            var Station = _repository.Station.GetAllStations();
            var StationDTO = _mapper.Map<IEnumerable<StationDto>>(Station);
            return Ok(StationDTO);
        }

        [HttpGet("{id:int}", Name = "GetStationsInRailway")]
        public IActionResult GetStationsInRailway(int id)
        {
            var Station = _repository.Station.GetAllStations().Where(c=>c.RailwayId.Equals(id));
            var StationDTO = _mapper.Map<IEnumerable<StationDto>>(Station);
            return Ok(StationDTO);
        }

        [HttpGet(Name = "GetStationById")]
        public IActionResult GetStationById(int Id)
        {
            var Station = _repository.Station.GetStationById(Id);
            if (Station == null)
            {
                return NotFound($"there is no Station with id{Id}");
            }
            else
            {
                var StationDTO = _mapper.Map<StationDto>(Station);

                return Ok(StationDTO);
            }
        }


        [HttpPost(Name = "CreateStation")]
        public IActionResult CreateStation([FromBody] StationForCreateDto station)
        {
            ArgumentNullException.ThrowIfNull(station);

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

                var StationEntity = _mapper.Map<Station>(station);
                _repository.Station.CreateStation(StationEntity);
                _repository.Save();
                var StationToReturn = _mapper.Map<StationDto>(StationEntity);
                return CreatedAtRoute("GetStationById", new { id = StationToReturn.Id }, StationToReturn);
            

        }



        [HttpDelete(Name = "DeleteStation")]
        public IActionResult DeleteStation(int Id)
        {
            var tks = _repository.Ticket.GetAllTikets().Where(c=>c.StationArrivalId.Equals(Id));

            foreach (var t in tks)
            {
                _repository.Ticket.DeleteTikcket(t);
            }

            var station = _repository.Station.GetStationById(Id);
            ArgumentNullException.ThrowIfNull(station);
            _repository.Station.DeleteStation(station);
            _repository.Save();
            return Ok($"Station with id {Id} already has been deleted");
        }

        [HttpPut(Name = "UpdateStation")]
        public IActionResult UpdateStation([FromBody] StationForUpdateDto station, int StationId)
        {
            var Selectedstation = _repository.Station.GetStationById(StationId);
            ArgumentNullException.ThrowIfNull(Selectedstation);
            var stationEntity = _mapper.Map(station, Selectedstation);
            _repository.Station.UpdateStation(stationEntity);
            _repository.Save();
            return Ok($"the station with id {StationId} has been updeted successfully");
        }
    }
}
