using AutoMapper;
using Contracts;
using Entites;
using Entites.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineAPI.Presentation.Controllers
{
    [Route("api/Post/[action]")]

    [ApiController]
    public class PostController : ControllerBase
    {

        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;

        public PostController(IRepositoryManegar repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetPosts")]
        public ActionResult GetAllPosts()
        {
            try
            {

                var posts = _repository.Post.GetAllPosts();

                var postDtos = _mapper.Map<IEnumerable<PostDto>>(posts);


                if (postDtos == null)
                {
                    return StatusCode(404, "Empty");
                }
                else
                {
                    return Ok(postDtos);
                }
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id:int}", Name = "GetPost")]
        public ActionResult GetPost(int id)
        {
            try
            {

                var post = _repository.Post.GetPostById(id);

                var postDtos = _mapper.Map<PostDto>(post);

                if (postDtos == null)
                {
                    return StatusCode(404, "Empty");
                }
                else
                {
                    return Ok(postDtos);
                }
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }


        [HttpPost(Name = "createPost")]
        public ActionResult CreatePost([FromBody] PostCreationDto post)
        {
            ArgumentNullException.ThrowIfNull(post);

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var postEntity = _mapper.Map<Post>(post);
            _repository.Post.CreatePost(postEntity);

            _repository.Save();
            var ReturnedPost = _mapper.Map<PostDto>(postEntity);
            return CreatedAtRoute("GetPost", new { Id = ReturnedPost.Id }, ReturnedPost);
        }

            //[HttpPost(Name = "createPost")]
            //[ProducesResponseType(StatusCodes.Status201Created)]
            //[ProducesResponseType(StatusCodes.Status400BadRequest)]
            //public ActionResult CreatePost([FromForm] PostCreationDto post)
            //{
            //    ArgumentNullException.ThrowIfNull(post);
            //    if (!ModelState.IsValid)
            //        return UnprocessableEntity(ModelState);

            //    if (post.image == null || post.image.Length == 0)
            //        return BadRequest("Please select an image file to upload.");

            //    string fileName = post.image.FileName;
            //    var path = $@"h:\root\home\trainlocationapi-001\www\site1\wwwroot\postimages\" + fileName;

            //    using (var stream = new FileStream(path, FileMode.Create))
            //    {
            //        post.image.CopyTo(stream);
            //    }

            //    var postEntity = _mapper.Map<Post>(post);
            //    postEntity.Img = "http://trainlocationapi-001-site1.atempurl.com/wwwroot/postimages/" + fileName;
            //    _repository.Post.CreatePost(postEntity);

            //    _repository.Save();
            //    var ReturnedPost= _mapper.Map<PostDto>(postEntity);
            //    return CreatedAtRoute("GetPost", new { Id = ReturnedPost.Id }, ReturnedPost);
            //}


            [HttpPut("{Id:int}", Name = "UpdatePost")]
        public IActionResult UpdatePost([FromBody] PostUpdateDto post, int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"Post with id  {Id}  already has deleted");
            }
            else
            {
                var SelectedPost = _repository.Post.GetPostById(Id);
                ArgumentNullException.ThrowIfNull(SelectedPost);
                var postEntity = _mapper.Map(post, SelectedPost);
                _repository.Post.UpdatePost(postEntity);
                _repository.Save();
                return Ok($"the Post with id {Id} has been updeted successfully");
            }
        }

        [HttpDelete("{Id:int}", Name = "DeletePost")]
        public IActionResult DeletePost(int Id)
        {
            var comments = _repository.Comment.GetCommentsByPostId(Id);
            var reports = _repository.Report.GetAllReports().Where(c => c.UserId.Equals(Id));

            if (comments != null) 
            {
                foreach(var comment in comments)
                {
                    _repository.Comment.DeleteComment(comment);
                }
            }

            if (reports != null)
            {
                foreach (var report in reports)
                {
                    _repository.Report.DeleteReport(report);
                }
            }
            var post = _repository.Post.GetPostById(Id);
            ArgumentNullException.ThrowIfNull(post);
            _repository.Post.DeletePost(post);
            _repository.Save();
            return Ok($"Post with id {Id} deleted");
        }
    }
}
