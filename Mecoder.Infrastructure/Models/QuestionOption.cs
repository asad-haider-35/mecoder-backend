using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Infrastructure.Models
{
    public class QuestionOption
    {
        [SetsRequiredMembers]
        public QuestionOption(int id, int questionId, string text, int score)
        {
            Id = id;
            QuestionId = questionId;
            Text = text;
            Score = score;
        }

        public required int Id { get; set; }
        public required int QuestionId { get; set; }
        public required string Text { get; set; }
        public required int Score { get; set; }

        public Question Question { get; set; }
    }
}
