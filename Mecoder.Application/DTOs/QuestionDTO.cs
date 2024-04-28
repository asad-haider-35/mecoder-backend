using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Application.DTOs
{
    public class QuestionDTO
    {
        public required int Id { get; set; }
        public required int QuizId { get; set; }
        public required string Text { get; set; }
    }
}
