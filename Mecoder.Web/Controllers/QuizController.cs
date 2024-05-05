using Mecoder.Application.DTOs;
using Mecoder.Application.IServices;
using Mecoder.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Mecoder.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _quizService;

        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetQuiz(int id)
        {
            try
            {
                ResponseModel<QuizDTO> response = new ResponseModel<QuizDTO>();

                response.Data = _quizService.GetQuiz(id);

                if (response.Data == null)
                {
                    response.StatusCode = HttpStatusCode.NotFound;
                    response.Message = "Quiz with specified ID not found";

                    return NotFound(response);
                }

                response.StatusCode = HttpStatusCode.OK;
                response.Message = "Quiz with specified ID fetched successfully";

                return Ok(response);

            }
            catch(ApplicationException appEx)
            {
                ResponseModel<object> response = new ResponseModel<object>();

                response.StatusCode = HttpStatusCode.BadRequest;
                response.Message = appEx.Message;

                return BadRequest(response);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("CalculateResult")]
        public IActionResult CalculateResult([FromBody] QuizResponseDTO quizResponse)
        {
            try
            {
                ResponseModel<string> response = new ResponseModel<string>();

                response.Data = _quizService.CalculateResult(quizResponse);

                response.StatusCode = HttpStatusCode.OK;
                response.Message = "Quiz with specified ID fetched successfully";

                return Ok(response);
            }
            catch (ApplicationException appEx)
            {
                ResponseModel<object> response = new ResponseModel<object>();

                response.StatusCode = HttpStatusCode.BadRequest;
                response.Message = appEx.Message;

                return BadRequest(response);
            }
            catch (Exception)
            {
                throw;
            }
        }
    
    }
}
