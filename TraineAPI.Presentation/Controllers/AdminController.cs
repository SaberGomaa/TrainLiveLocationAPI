using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Shared.DTOs;
using AutoMapper;
using Entites;
using Entites.Models;
using Microsoft.AspNetCore.Http;

namespace TraineAPI.Presentation.Controllers
{
    [Route("api/Admin/[action]")]

    [ApiController]
    //(ControllerBase)which provides all necessary behavior for the derived class
    [ApiExplorerSettings(IgnoreApi = true)]

    public class AdminController : ControllerBase
    {
        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;

        public AdminController(IRepositoryManegar repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet(Name = "Admins")]
        public IActionResult GetAdmins()
        {
            try
            {
                //var Admins = _repository.Admin.GetAllAdmins();

                //var AdminsDto = Admins.Select(
                //    c => new AdminDto(c.Id, c.Name, c.Password, c.Phone, c.Email , c.AdminDegree  ))
                //    .ToList();

                var Admins = _repository.Admin.GetAllAdmins();

                var AdminsDto = _mapper.Map<IEnumerable<AdminDto>>(Admins);

                if (AdminsDto == null)
                {
                    return StatusCode(404, "Empty");
                }
                else
                {
                    return Ok(AdminsDto);
                }
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [Route("{phone}/{password}")]
        [HttpGet]
        public IActionResult GetLoginAdmin(string phone , string password)
        {
            try
            {

                var admin = _repository.Admin.LoginForAdmin(phone , password);

                var adminDTO = _mapper.Map<AdminDto>(admin);
                ArgumentNullException.ThrowIfNull(adminDTO);
                if (adminDTO == null)
                {
                    return StatusCode(404, "Not Found");
                }
                else
                {
                    return Ok(adminDTO);
                }

            }
            catch
            {
                return StatusCode(500, "Internal server error");

            }
        }


        [HttpGet("{id:int}", Name = "GetAdmin")]
        public IActionResult GetAdmin(int id)
        {
            try
            {
                var admin = _repository.Admin.GetAdminById(id);

                var adminDTO = _mapper.Map<AdminDto>(admin);
                ArgumentNullException.ThrowIfNull(adminDTO);
                if (adminDTO == null)
                {
                    return StatusCode(404, "Empty");
                }
                else
                {
                    return Ok(adminDTO);
                }

            }
            catch
            {
                return StatusCode(500, "Internal server error");

            }
        }

        [HttpPost(Name = "CreateAdmin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateAdmin([FromForm] AdminCreationDto admin)
        {
            ArgumentNullException.ThrowIfNull(admin);

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            if (admin.image == null || admin.image.Length == 0)
                return BadRequest("Please select an image file to upload.");

            string fileName = admin.image.FileName;
            //string fullPath = Path.Combine(@"h:\root\home\saberelsayed-001\www\trainapi\dashborad\", fileName);

            var path = $@"h:\root\home\trainlocationapi-001\www\site1\wwwroot\adminimages\" + fileName;

            using (var stream = new FileStream(path, FileMode.Create))
            {
                admin.image.CopyTo(stream);
            }

            var entitAdminEntity = _mapper.Map<Admin>(admin);
            entitAdminEntity.image = "http://trainlocationapi-001-site1.atempurl.com/wwwroot/adminimages/" + fileName;

            _repository.Admin.CreateAdmin(entitAdminEntity);

            _repository.Save();
            var adminToReturn = _mapper.Map<AdminDto>(entitAdminEntity);
            return CreatedAtRoute("GetAdmin", new { Id = adminToReturn.Id }, adminToReturn);
        }

        [HttpPut("{Id:int}", Name = "UpdateAdmin")]
        public IActionResult UpdateAdmin([FromForm] AdminUpdateDto admin, int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"Admin with id  {Id}  already has deleted");
            }
            else
            {
                var SelectedAdmin = _repository.Admin.GetAdminById(Id);
                ArgumentNullException.ThrowIfNull(SelectedAdmin);

                if (admin.image == null || admin.image.Length == 0)
                    return BadRequest("Please select an image file to upload.");

                string fileName = admin.image.FileName;
                //string fullPath = Path.Combine(@"h:\root\home\saberelsayed-001\www\trainapi\dashborad\", fileName);

                var path = $@"h:\root\home\trainlocationapi-001\www\site1\wwwroot\adminimages\" + fileName;

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    admin.image.CopyTo(stream);
                }


                var AdminEntity = _mapper.Map(admin, SelectedAdmin);
                AdminEntity.image = "http://trainlocationapi-001-site1.atempurl.com/wwwroot/adminimages/" + fileName;

                _repository.Admin.UpdateAdmin(AdminEntity);
                _repository.Save();
                return Ok($"the Admin with id {Id} has been updeted successfully");
            }
        }

        [HttpDelete("{Id:int}", Name = "DeleteAdmin")]
        public IActionResult DeleteAdmin(int Id)
        {
            var admin = _repository.Admin.GetAdminById(Id);
            ArgumentNullException.ThrowIfNull(admin);
            _repository.Admin.DeleteAdmin(admin);
            _repository.Save();
            return Ok($"Admin with id {Id} deleted");
        }


    }
}
