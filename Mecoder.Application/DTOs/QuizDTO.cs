using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Application.DTOs
{
    public class QuizDTO
    {
        public QuizDTO()
        {
            Questions = new List<QuestionDTO>();
        }

        public required int Id { get; set; }
        public required string Name { get; set; }

        public IList<QuestionDTO> Questions { get; set; }
    }
}
