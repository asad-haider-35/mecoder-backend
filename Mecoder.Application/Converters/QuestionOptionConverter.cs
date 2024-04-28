using Mecoder.Application.DTOs;
using Mecoder.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Application.Converters
{
    public static class QuestionOptionConverter
    {
        public static QuestionOptionDTO ConvertToDto(this QuestionOption entity)
        {
            return new QuestionOptionDTO
            {
                Id = entity.Id,
                QuestionId = entity.QuestionId,
                Text = entity.Text,
                Score = entity.Score
            };
        }
    }
}
