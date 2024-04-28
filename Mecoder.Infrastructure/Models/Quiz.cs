using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Infrastructure.Models
{
    public class Quiz
    {
        [SetsRequiredMembers]
        public Quiz(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public required int Id { get; set; }
        public required string Name { get; set; }

        public IList<Question> Questions { get; set; }
    }
}
