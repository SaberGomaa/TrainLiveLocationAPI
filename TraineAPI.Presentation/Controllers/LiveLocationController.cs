using AutoMapper;
using Contracts;
using Entites;
using Entites.Models;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineAPI.Presentation.Controllers
{

    [Route("api/LiveLocation/[action]")]

    [ApiController]
    //(ControllerBase)which provides all necessary behavior for the derived class
    public class LiveLocationController : ControllerBase
    {
        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;
        static Dictionary<double, (double Longitude, double Latitude)> locationas = new Dictionary<double, (double Longitude, double Latitude)>();

        public LiveLocationController(IRepositoryManegar repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

       
           
        //[HttpGet(Name = "Locations")]
        //public IActionResult GetLocations()
        //{
        //    try
        //    {
        //        var Locations = _repository.LiveLocation.GetAllLocations();

        //        var LocationsDto = _mapper.Map<IEnumerable<LiveLocationDto>>(Locations);

        //        if (LocationsDto == null)
        //        {
        //            return StatusCode(404, "Empty");
        //        }
        //        else
        //        {
        //            return Ok(LocationsDto);
        //        }
        //    }
        //    catch
        //    {
        //        return StatusCode(500, "Internal server error");
        //    }
        //}

      


        [HttpGet(Name = "GetLocation")]
        public IActionResult GetLocation(int TrainId)
        {
            try
            {

                if (!locationas.ContainsKey(TrainId))
                {
                    locationas[TrainId] = (0 , 0);
                }

                var Locations = _repository.LiveLocation.GetLocationsForTrain(TrainId);

                var Longitude = _mapper.Map<IEnumerable<LongitudeDto>>(Locations);

                var CorrectLongitude = Longitude.GroupBy(i => i)
                    .OrderByDescending(grp =>
                    grp.Count()).Select(grp => grp.Key).FirstOrDefault();


                var Latitude = _mapper.Map<IEnumerable<LatitudeDto>>(Locations);

                var CorrectLatitude = Latitude.GroupBy(i => i)
                    .OrderByDescending(grp =>
                    grp.Count()).Select(grp => grp.Key).FirstOrDefault();

                var LocationsForOneTrainToDelete = _repository.LiveLocation.GetLocationsForTrain(TrainId);

                foreach (var Loc in LocationsForOneTrainToDelete)
                {
                    _repository.LiveLocation.DeleteLocation(Loc);
                }

                _repository.Save();

               

                if (CorrectLatitude == null || CorrectLongitude == null)
                {
                    return Ok(new { Longitude = locationas[TrainId].Longitude, Latitude = locationas[TrainId].Latitude });
                }
                else
                {
                    locationas[TrainId] = (CorrectLongitude.Longitude , CorrectLatitude.Latitude);
                    return Ok(new { Longitude = locationas[TrainId].Longitude, Latitude = locationas[TrainId].Latitude });
                }
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }




        [HttpPost(Name = "CreateLocation")]
        public IActionResult CreateLocation([FromBody] LiveLocationCreationDto location)
        {
            try
            {

                ArgumentNullException.ThrowIfNull(location);

                if (!ModelState.IsValid)
                    return UnprocessableEntity(ModelState);

                var entity = _mapper.Map<LiveLocation>(location);

                _repository.LiveLocation.CreateLocation(entity);

                _repository.Save();

                var LocationToReturn = _mapper.Map<LiveLocationDto>(entity);

                return Ok(LocationToReturn);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }

        }

       
    }
}
