using AutoMapper;
using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace TraineAPI.Presentation.Controllers
{
    [Route("api/Railway/[action]")]
    [ApiController]
    public class RailwayController : ControllerBase
    {
        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;
        public RailwayController(IRepositoryManegar repository , IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;   
        }

        [HttpGet]
        public IActionResult GetAllRailways()
        {
            try
            {
                var result = _repository.railway.GetAllRailway();

                var railways = _mapper.Map<IEnumerable<ReturnedRailwayDto>>(result);

                return Ok(railways);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult CreateRailway(RailwayDto  railway)
        {
            if (railway != null)
            {
                var r = _mapper.Map<Railway>(railway);
                _repository.railway.CreateRailway(r);
                _repository.Save();
                return Ok();
            }else
                return BadRequest();
        }

        [HttpPut]
        public IActionResult UpdateRailway(int id ,[FromBody] ReturnedRailwayDto railway) 
        {
            var r = _repository.railway.GetRailwayById(id);
            var rail = _mapper.Map(railway , r);

            if(r.Id == rail.Id)
            {
                _repository.railway.UpdateRailway(rail);
                _repository.Save();
                return Ok();
            }
            else return BadRequest("Not Matched Data");
        }

        [HttpDelete]
        [Route("{id:int}" , Name = "DeleteRailway")]
        public IActionResult DeleteRailway(int id)
        {
            
            var r = _repository.railway.GetRailwayById(id);
            if(r == null) return BadRequest($"Not Found Railway with id {id}");
            _repository.railway.DeleteRailway(r);
            _repository.Save();
            return Ok("Railway Deleted successfuly");
        }

    }
}
