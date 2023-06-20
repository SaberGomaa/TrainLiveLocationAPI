using AutoMapper;
using Contracts;
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
