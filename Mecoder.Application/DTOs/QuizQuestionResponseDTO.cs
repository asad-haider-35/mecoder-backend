using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Application.DTOs
{
    public class QuizQuestionResponseDTO
    {
        public required int Id { get; set; }
        public required int QuizResponseId { get; set; }
        public required int QuestionId { get; set; }
        public int ResponseId { get; set; }
        public int AquiredScore { get; set; }
    }
}
