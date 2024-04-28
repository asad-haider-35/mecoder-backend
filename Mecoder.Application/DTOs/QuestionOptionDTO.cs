using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Application.DTOs
{
    public class QuestionOptionDTO
    {
        public required int Id { get; set; }
        public required int QuestionId { get; set; }
        public required string Text { get; set; }
        public required int Score { get; set; }
    }
}
