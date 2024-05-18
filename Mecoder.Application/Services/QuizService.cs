using Mecoder.Application.Converters;
using Mecoder.Application.DTOs;
using Mecoder.Application.Enums;
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
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string CalculateResult(QuizResponseDTO quizResponse)
        {
            try
            {
                QuizDTO quiz = GetQuiz(quizResponse.QuizId);

                var introvertResponses = quizResponse.QuizQuestionResponses.Where(x => x.AcquiredScore == (int)PersonalityCategoryScore.Introvert).ToList();
                var ambivertResponses = quizResponse.QuizQuestionResponses.Where(x => x.AcquiredScore == (int)PersonalityCategoryScore.Ambivert).ToList();
                var extrovertResponses = quizResponse.QuizQuestionResponses.Where(x => x.AcquiredScore == (int)PersonalityCategoryScore.Extrovert).ToList();

                Dictionary<string, int> result = new Dictionary<string, int>()
                {
                    { PersonalityCategoryScore.Introvert.ToString(), introvertResponses.Count },
                    { PersonalityCategoryScore.Ambivert.ToString(), ambivertResponses.Count },
                    { PersonalityCategoryScore.Extrovert.ToString(), extrovertResponses.Count }
                };

                string finalResult = string.Empty;

                if (introvertResponses.Count == ambivertResponses.Count && introvertResponses.Count > extrovertResponses.Count)
                {
                    finalResult = PersonalityCategoryScore.Introvert.ToString();
                }
                else if (extrovertResponses.Count == ambivertResponses.Count && extrovertResponses.Count > introvertResponses.Count)
                {
                    finalResult = PersonalityCategoryScore.Extrovert.ToString();
                }
                else if (extrovertResponses.Count == introvertResponses.Count)
                {
                    finalResult = PersonalityCategoryScore.Ambivert.ToString();
                }
                else
                {
                    finalResult = result.OrderByDescending(x => x.Value).FirstOrDefault().Key;
                }

                return finalResult;
            }
            catch (ApplicationException)
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
