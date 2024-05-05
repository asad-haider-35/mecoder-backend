using Mecoder.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Application.IServices
{
    public interface IQuizService
    {
        string CalculateResult(QuizResponseDTO quizResponse);
        QuizDTO GetQuiz(int id);
    }
}
