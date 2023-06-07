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
    [Route("api/Comment/[action]")]

    [ApiController]

    public class CommentController : ControllerBase
    {


        private readonly IRepositoryManegar _repository;
        private readonly IMapper _mapper;

        public CommentController(IRepositoryManegar repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet (Name = "GetComments")]
        public ActionResult GetAllComments()
        {
            try
            {
               
                var comments = _repository.Comment.GetAllComments();

                var commentDtos = _mapper.Map<IEnumerable<CommentDto>>(comments);

                if (commentDtos == null)
                {
                    return StatusCode(404, "Empty");
                }
                else
                {
                    return Ok(commentDtos);
                }
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }



        [HttpGet("{id:int}", Name = "GetComment")]
        public IActionResult GetComment(int id)
        {
            try
            {

                var comment = _repository.Comment.GetCommentById(id);

                var CommentDTO = _mapper.Map<CommentDto>(comment);

                if (CommentDTO == null)
                {
                    return StatusCode(404, "Empty");
                }
                else
                {
                    return Ok(CommentDTO);
                }

            }
            catch
            {
                return StatusCode(500, "Internal server error");

            }
        }



        [HttpGet("{PostId:int}", Name = "GetCommentsForPost")]
        public IActionResult GetCommentsForPost(int PostId)
        {
            try
            {

                var comment = _repository.Comment.GetCommentsByPostId(PostId);

                var CommentDTO = _mapper.Map<IEnumerable<ReturnedComment>>(comment);

                if (CommentDTO == null)
                {
                    return StatusCode(404, "Empty");
                }
                else
                {
                    return Ok(CommentDTO);
                }

            }
            catch
            {
                return StatusCode(500, "Internal server error");

            }
        }


        [HttpPost(Name ="createComment")]
        public ActionResult CreateComment(CommentDto comment) 
        {
            ArgumentNullException.ThrowIfNull(comment);

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var commentEntity = _mapper.Map<Comment>(comment);
            _repository.Comment.CreateComment(commentEntity);

            _repository.Save();
            var ReturnedComment = _mapper.Map<ReturnedComment>(commentEntity);
            return CreatedAtRoute("GetComment", new { Id = ReturnedComment.Id }, ReturnedComment);

        }


        [HttpDelete("{Id:int}", Name = "DeleteComment")]
        public IActionResult DeleteComment(int Id)
        {
            var comment = _repository.Comment.GetCommentById(Id);
            ArgumentNullException.ThrowIfNull(comment);
            _repository.Comment.DeleteComment(comment);
            _repository.Save();
            return Ok($"Comment with id {Id} deleted");
        }


        [HttpPut("{Id:int}", Name = "UpdateComment")]
        public IActionResult UpdateComment([FromBody] CommentUpdateDto comment, int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"Comment with id  {Id}  already has deleted");
            }
            else
            {
                var SelectedComment = _repository.Comment.GetCommentById(Id);
                ArgumentNullException.ThrowIfNull(SelectedComment);
                var CommentEntity = _mapper.Map(comment, SelectedComment);
                _repository.Comment.UpdateComment(CommentEntity);
                _repository.Save();
                return Ok($"the Comment with id {Id} has been updeted successfully");
            }
        }

      


    }
}
