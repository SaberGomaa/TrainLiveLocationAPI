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
    [Route("api/Report/[action]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;

        public ReportController(IRepositoryManegar repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        [HttpGet(Name = "GetAllReports")]
        public IActionResult GetAllReports()
        {
            try
            {
                var r = _repository.Report.GetAllReports();

                var reports = _mapper.Map<IEnumerable<ReportDto>>(r);

                if (reports is null)
                {
                    return StatusCode(404, "Empty");

                }
                else
                {
                    return Ok(reports);
                }
            }
            catch
            {
                return StatusCode(404, "Not Found");
            }
        }



        [HttpGet("{id:int}", Name = "GetReportsForPost")]
        public IActionResult GetReportsForPost(int id)
        {
            try
            {
                var r = _repository.Report.GetAllReports().Where(r => r.PostId.Equals(id));

                var reports = _mapper.Map<IEnumerable<ReportDto>>(r);

                if (reports is null)
                {
                    return StatusCode(404, "Empty");
                }
                else
                {
                    return Ok(reports);
                }
            }
            catch
            {
                return StatusCode(404, "Not Found");
            }
        }
        [HttpPost(Name = "CreateReport")]
        public IActionResult CreateReport(ReportCreationDto r)
        {
            try
            {
                var report = _mapper.Map<Report>(r);

                _repository.Report.CreateReport(report);
                _repository.Save();
                return Ok("Created");
            }catch
            {
                return BadRequest("Error");
            }
        }

        [HttpDelete("{id:int}", Name ="DeleteReport")]
        public IActionResult DeleteReport(int id)
        {
            try
            {
                var r = _repository.Report.GetReportById(id);
                _repository.Report.DeleteReport(r);
                _repository.Save();
                return Ok("Delete Sucessfully");
            }
            catch
            {
                return BadRequest("Error");
            }
        }
    }
}
