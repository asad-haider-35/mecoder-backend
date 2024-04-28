using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Infrastructure.Models
{
    public class Question
    {
        [SetsRequiredMembers]
        public Question(int id, int quizId, string text)
        {
            Id = id;
            QuizId = quizId;
            Text = text;
        }

        public required int Id { get; set; }
        public required int QuizId { get; set; }
        public required string Text { get; set; }

        public Quiz Quiz { get; set; }

        public IList<QuestionOption> Options { get; set; }
    }
}
