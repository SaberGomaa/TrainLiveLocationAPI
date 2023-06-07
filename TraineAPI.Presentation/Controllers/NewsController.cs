using AutoMapper;
using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace TraineAPI.Presentation.Controllers
{

    [ApiController]
    [Route("api/news/[action]")]
    public class NewsController : ControllerBase
    {


        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment host;
        public NewsController(IRepositoryManegar repository, IMapper mapper, IWebHostEnvironment host)
        {
            _repository = repository;
            _mapper = mapper;
            this.host = host;
        }


        [HttpGet(Name = "GetNews")]
        public IActionResult GetNews()
        {
            var News = _repository.news.GetAllNews();
            var NewsDTO = _mapper.Map<IEnumerable<NewsDto>>(News);
            return Ok(NewsDTO);
        }


        [HttpGet(Name = "GetNewsById")]
        public IActionResult GetNewsById(int Id)
        {
            var News = _repository.news.GetNewsById(Id);
            if (News == null)
            {
                return NotFound($"there is no News with id{Id}");
            }
            else
            {
                var NewsDTO = _mapper.Map<NewsDto>(News);

                return Ok(NewsDTO);
            }
        }



        [HttpPost(Name = "CreateNews")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateNews( [FromForm] NewsCreateDto News )
        {
            ArgumentNullException.ThrowIfNull(News);
            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            if (News.image == null || News.image.Length == 0)
                return BadRequest("Please select an image file to upload.");

            string fileName = News.image.FileName;
            //string fullPath = Path.Combine(@"h:\root\home\saberelsayed-001\www\trainapi\dashborad\", fileName);

            var path = $@"h:\root\home\trainlocationapi-001\www\site1\wwwroot\newsimages\" + fileName;

            using (var stream = new FileStream(path, FileMode.Create))
            {
                News.image.CopyTo(stream);
            }

            //image.CopyTo(new FileStream(fullPath, FileMode.Create));
            var NewsEntity = _mapper.Map<News>(News);
            
            NewsEntity.Img = "http://trainlocationapi-001-site1.atempurl.com/wwwroot/newsimages/" + fileName;

            _repository.news.CreateNews(NewsEntity);
            _repository.Save();
            var NewsToReturn = _mapper.Map<NewsDto>(NewsEntity);
            return CreatedAtRoute("GetNewsById", new { id = NewsToReturn.Id }, NewsToReturn);

        }


        //[HttpPost(Name = "CreateNews")]
        //public IActionResult CreateNews([FromBody] NewsCreateDto News)
        //{
        //    ArgumentNullException.ThrowIfNull(News);

        //    if (!ModelState.IsValid)
        //        return UnprocessableEntity(ModelState);


        //    var NewsEntity = _mapper.Map<News>(News);
        //    _repository.news.CreateNews(NewsEntity);
        //    _repository.Save();
        //    var NewsToReturn = _mapper.Map<NewsDto>(NewsEntity);
        //    return CreatedAtRoute("GetNewsById", new { id = NewsToReturn.Id }, NewsToReturn);

        //}


        [HttpDelete(Name = "DeleteNews")]
        public IActionResult DeleteNews(int Id)
        {
            var News = _repository.news.GetNewsById(Id);
            ArgumentNullException.ThrowIfNull(News);
            _repository.news.DeleteNews(News);
            _repository.Save();
            return Ok($"News with id {Id} already has been deleted");
        }


        [HttpPut(Name = "UpdateNews")]
        public IActionResult UpdateNews([FromBody] NewsUpdateDto news, int NewsId)
        {
            var SelectedNews = _repository.news.GetNewsById(NewsId);
            ArgumentNullException.ThrowIfNull(SelectedNews);
            var NewsEntity = _mapper.Map(news, SelectedNews);
            _repository.news.UpdateNews(NewsEntity);
            _repository.Save();
            return Ok($"the News with id {NewsId} has been updeted successfully");
        }
    }
}
