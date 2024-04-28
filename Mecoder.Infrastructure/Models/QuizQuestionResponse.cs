using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Infrastructure.Models
{
    public class QuizQuestionResponse
    {
        public required int Id { get; set; }
        public required int QuizResponseId { get; set; }
        public required int QuestionId { get; set; }
        public required int Response { get; set; }
    }
}
