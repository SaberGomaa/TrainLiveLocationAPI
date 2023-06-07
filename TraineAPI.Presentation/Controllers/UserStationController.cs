using AutoMapper;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineAPI.Presentation.Controllers
{
    [Route("api/user/[action]")]

    [ApiController]
    public class UserStationController : ControllerBase
    {

        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;

        public UserStationController(IRepositoryManegar repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet(Name = "UserInStation")]
        public ActionResult UserInStation(int StationId)
        {
            var users = _repository.Ticket.GetAllTikets().Where(x => x.StationArrivalId == StationId).Select(x => new { Id = x.Id, Phone = x.UserPhone, Name = x.UserName });
            return Ok(users);
        }

    }
}
