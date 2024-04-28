using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Infrastructure.Models
{
    public class QuestionOption
    {
        public required int Id { get; set; }
        public required int QuestionId { get; set; }
        public required string Text { get; set; }
        public required int Score { get; set; }
    }
}
