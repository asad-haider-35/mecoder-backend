using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Application.DTOs
{
    public class QuizQuestionResponseDTO
    {
        public int Id { get; set; }
        public int QuizResponseId { get; set; }
        public int QuestionId { get; set; }
        public int ResponseId { get; set; }
        public int AcquiredScore { get; set; }
    }
}
