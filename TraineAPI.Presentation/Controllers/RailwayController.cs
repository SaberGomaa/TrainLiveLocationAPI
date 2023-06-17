using AutoMapper;
using Contracts;
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

                var railways = _mapper.Map<IEnumerable<RailwayDto>>(result);

                return Ok(railways);
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
