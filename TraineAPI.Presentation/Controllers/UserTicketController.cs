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
using System.Xml.Linq;

namespace TraineAPI.Presentation.Controllers
{
    [Route("api/user/[action]")]

    [ApiController]
    public class UserTicketController : ControllerBase
    {

        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;

        public UserTicketController(IRepositoryManegar repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet(Name = "DoctorsInTrain")]
        public IActionResult DoctorsInTrain(int TrainId)
        {
            var usersInTrain = _repository.Ticket.GetAllTikets()
                .Where(x => 
                x.TrainId.Equals(TrainId) && x.UserJop=="Doctor" 
                && x.TakeOffDate.Year == DateTime.Now.Year 
                && x.TakeOffDate.Month == DateTime.Now.Month)
                .GroupBy(x => x.UserId)
                .Select(g => new {
                    TicketId = g.First().Id,
                    userId = g.Key,
                    Jop = g.First().UserJop,
                    UserName = g.First().UserName,
                    UserEmail = g.First().UserEmail,
                    UserPhone = g.First().UserPhone,
                    TakeOffStation = g.First().TakeOffStation,
                    ArrivalStation = g.First().ArrivalStation
                });

            return Ok(usersInTrain);
        }

        [HttpGet(Name = "UsersInTrain")]
        public ActionResult UsersInTrain(int TrainId)
        {
            var usersInTrain = _repository.Ticket.GetAllTikets()
                .Where(x =>
                x.TrainId.Equals(TrainId)
                && x.TakeOffDate.Year == DateTime.Now.Year
                && x.TakeOffDate.Month == DateTime.Now.Month)
                .Select(x => new {
                    TicketId = x.Id,
                    userId = x.UserId,
                    Jop = x.UserJop,
                    UserName = x.UserName,
                    UserEmail = x.UserEmail,
                    UserPhone = x.UserPhone,
                    TakeOffStation = x.TakeOffStation,
                    ArrivalStation = x.ArrivalStation
                });

            return Ok(usersInTrain);
        }

        [HttpGet(Name = "UsersTokenInTrain")]
        public ActionResult UsersTokenInTrain(int TrainId)
        {
            var usersInTrain = _repository.Ticket.GetAllTikets()
                .Where(x =>
                x.TrainId.Equals(TrainId)
                && x.TakeOffDate.Day == DateTime.Now.Day
                && x.TakeOffDate.Year == DateTime.Now.Year
                && x.TakeOffDate.Month == DateTime.Now.Month)
                .Select(x => new {
                    userId = x.UserId,
                    userToken= x.UserToken
                });

            return Ok(usersInTrain);
        }

    }
    
}
