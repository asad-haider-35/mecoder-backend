using Mecoder.Application.Converters;
using Mecoder.Application.DTOs;
using Mecoder.Application.IServices;
using Mecoder.Infrastructure.IRepositories;
using Mecoder.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Application.Services
{
    public class QuizService: IQuizService
    {
        private readonly IQuizRepository _quizRepository;

        public QuizService(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }

        public QuizDTO GetQuiz(int id)
        {
            try
            {

                Quiz entity = _quizRepository.Get(id);

                if (entity == null)
                    throw new ApplicationException("Quiz not found");

                QuizDTO dto = entity.ConvertToDto();

                if (dto == null)
                    throw new ApplicationException("Quiz conversion error");

                return dto;
            }
            catch (ApplicationException appEx)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
