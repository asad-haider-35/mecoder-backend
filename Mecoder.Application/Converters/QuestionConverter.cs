using Mecoder.Application.DTOs;
using Mecoder.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Application.Converters
{
    public static class QuestionConverter
    {
        public static QuestionDTO ConvertToDto(this Question entity)
        {
            return new QuestionDTO
            {
                Id = entity.Id,
                QuizId = entity.QuizId,
                Text = entity.Text,

                QuestionOptions = entity.Options.Select(x => x.ConvertToDto()).ToList(),
            };
        }
    }
}
