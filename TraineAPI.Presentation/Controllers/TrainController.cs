using AutoMapper;
using Contracts;
using Entites;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineAPI.Presentation.Controllers
{
    [Route("api/train/[action]")]
    [ApiController]
    public class TrainController :ControllerBase
    {

        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;

        public TrainController(IRepositoryManegar repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        //[HttpGet(Name = "GetAllConductor")]
        //public IActionResult GetAllConductor()
        //{
        //    var Trains = _repository.Train.GetAllTrain();
        //    var ConductorDTO = _mapper.Map<IEnumerable<ConductorDto>>(Trains);
        //    return Ok(ConductorDTO);
        //}


        //[HttpGet(Name = "GetAllDriver")]
        //public IActionResult GetAllDriver()
        //{
        //    var Trains = _repository.Train.GetAllTrain();
        //    var DriverDTO = _mapper.Map<IEnumerable<DreiverDto>>(Trains);
        //    return Ok(DriverDTO);
        //}


        [HttpGet(Name = "GetTrains")]
        public IActionResult GetTrains()
        {
            var Trains = _repository.Train.GetAllTrain();
            var trainDTO = _mapper.Map<IEnumerable<TrainDto>>(Trains);
            return Ok(trainDTO);
        }



        [HttpGet(Name = "GetTrainById")]
        public IActionResult GetTrainById(int Id)
        {
            var Train = _repository.Train.GetTrainById(Id);
            if (Train == null)
            {
                return NotFound($"there is no user with id{Id}");
            }
            else
            {
                var TrainDTO = _mapper.Map<TrainDto>(Train);

                return Ok(TrainDTO);
            }
        }


        [HttpPost(Name = "CreateTrain")]
        public IActionResult CreateTrain([FromBody] TrainCreationDto train)
        {
            ArgumentNullException.ThrowIfNull(train);

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var TrainEntity = _mapper.Map<Train>(train);
            _repository.Train.CreateTrain(TrainEntity);
            _repository.Save();
            var TrainToReturn = _mapper.Map<TrainDto>(TrainEntity);
            return CreatedAtRoute("GetUserById", new { id = TrainToReturn.Id }, TrainToReturn);


        }



        [HttpDelete(Name = "DeleteTrain")]
        public IActionResult DeleteTrain(int Id)
        {
            var train = _repository.Train.GetTrainById(Id);
            ArgumentNullException.ThrowIfNull(train);
            _repository.Train.DeleteTrain(train);
            _repository.Save();
            return Ok($"Train with id {Id} already has been deleted");
        }


        [HttpPut(Name = "UpdateTrain")]
        public IActionResult UpdateTrain([FromBody] TrainUpdatenDto train, int trainId)
        {
            var SelectedTrain = _repository.Train.GetTrainById(trainId);
            ArgumentNullException.ThrowIfNull(SelectedTrain);
            var TrainyEntity = _mapper.Map(train, SelectedTrain);
            _repository.Train.UpdateTrain(TrainyEntity);
            _repository.Save();
            return Ok($"the train with id {trainId} has been updeted successfully");
        }

    }
}
