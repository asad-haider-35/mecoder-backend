using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Application.DTOs
{
    public class QuizResponseDTO
    {
        public QuizResponseDTO()
        {
            QuizQuestionResponses = new List<QuizQuestionResponseDTO>();
        }

        public int Id { get; set; }
        public int QuizId { get; set; }
        public string? User { get; set; }
        public int TotalAquiredScore { get; set; }
        public string? Result { get; set; }

        public IList<QuizQuestionResponseDTO> QuizQuestionResponses { get; set; }
    }
}
