using Mecoder.Application.DTOs;
using Mecoder.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Application.Converters
{
    public static class QuizConverter
    {
        public static QuizDTO ConvertToDto(this Quiz entity)
        {
            return new QuizDTO
            {
                Id = entity.Id,
                Name = entity.Name,

                Questions = entity.Questions.Select(x => x.ConvertToDto()).ToList(),
            };
        }
    }
}
