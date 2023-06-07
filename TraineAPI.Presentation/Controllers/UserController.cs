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
    [Route("api/user/[action]")]

    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;

        public UserController(IRepositoryManegar repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        [HttpGet(Name = "GetUsers")]
        public IActionResult GetUsers()
        {               
            var Users = _repository.User.GetAllUser();
            var userDTO = _mapper.Map<IEnumerable<userDto>>(Users);
            return Ok(userDTO);
        }



        [HttpGet(Name = "GetUserById")]
        public IActionResult GetUserById(int Id)
        {
            var User = _repository.User.GetUserById(Id);
            if (User == null)
            {
                return NotFound($"there is no user with id{Id}");
            }
            else
            {
                var userDTO = _mapper.Map<userDto>(User);

                return Ok(userDTO);
            }
        }

        [HttpGet(Name = "GetUserTokenById")]
        public IActionResult GetUserTokenById(int Id)
        {
            var User = _repository.User.GetUserById(Id);
            if (User == null)
            {
                return NotFound($"there is no user with id{Id}");
            }
            else
            {
                var userDTO = _mapper.Map<userTokenDTO>(User);

                return Ok(userDTO);
            }
        }


        [HttpGet(Name = "GetTokenById")]
        public IActionResult GetTokenById(int Id)
        {
            var User = _repository.User.GetUserById(Id);
            if (User == null)
            {
                return NotFound($"there is no user with id{Id}");
            }
            else
            {
                var userDTO = _mapper.Map<userTokenDTO>(User);

                return Ok(userDTO);
            }
        }

        [HttpGet(Name = "UserLogin")]
        public IActionResult UserLogin(string Phone,string Password)
        {
            User x = _repository.User.GetUserByPhone(Phone);
            if (x == null)
                return BadRequest("Password or Phone is inCorrect!");
            if ( Password!=x.Password)
            {
                return BadRequest("Password or Phone is inCorrect!");
            }
            else
            {
                var c =_mapper.Map<userDto>(x);
                return Ok(c);
            }
        }

        [HttpPost(Name = "CreateUser")]
        public IActionResult CreateUser([FromBody] UserCreationDto user)
        {
            ArgumentNullException.ThrowIfNull(user);

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);
            
            User s=_repository.User.CheckEmail(user.Email);

            User x = _repository.User.CheckPhone(user.Phone);
            if (s != null || x !=null)
            {
                return BadRequest("UserEmail or UserPhone has already been exist!");
            }
            
            else
            {

                var UserEntity = _mapper.Map<User>(user);
                _repository.User.CreateUser(UserEntity);
                _repository.Save();
                var UserToReturn = _mapper.Map<userDto>(UserEntity);
                return CreatedAtRoute("GetUserById", new { id = UserToReturn.Id }, UserToReturn);
            }

        }

        [HttpPut(Name = "UpdateUser")]
        public IActionResult UpdateUser([FromBody] UserUpdateDto user, int userId)
        {
            var Selecteduser = _repository.User.GetUserById(userId);
            ArgumentNullException.ThrowIfNull(Selecteduser);
            var UseryEntity = _mapper.Map(user, Selecteduser);
            _repository.User.UpdateUser(UseryEntity);
            _repository.Save();
            return Ok($"the user with id {userId} has been updeted successfully");
        }

        [HttpDelete(Name = "DeleteUser")]
        public IActionResult DeleteUser(int Id)
        {


            var posts = _repository.Post.GetAllPosts().Where(x=>x.UserId.Equals(Id));
            var tickets = _repository.Ticket.GetAllTikets().Where(c=>c.UserId.Equals(Id));
            var reports = _repository.Report.GetAllReports().Where(c=>c.UserId.Equals(Id));
            var comments = _repository.Comment.GetAllComments().Where(c => c.UserId.Equals(Id));

            if (comments != null)
            {
                foreach (var comment in comments)
                {
                    _repository.Comment.DeleteComment(comment);
                }
            }

            if (posts != null)
            {
                foreach (var post in posts)
                {
                    _repository.Post.DeletePost(post);
                }
            }
            if(tickets != null)
            {
                foreach(var ticket in tickets)
                {
                    _repository.Ticket.DeleteTikcket(ticket);
                }
            }

            if(reports != null)
            {
                foreach( var report in reports)
                {
                    _repository.Report.DeleteReport(report);
                }
            }

            var user = _repository.User.GetUserById(Id);
            ArgumentNullException.ThrowIfNull(user);
            _repository.User.DeleteUser(user);
            _repository.Save();
            return Ok($"User with id {Id} already has been deleted");
        }

      

    }
}
