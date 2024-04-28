using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Application.DTOs
{
    public class QuizResponseDTO
    {
        public required int Id { get; set; }
        public required int QuizId { get; set; }
        public string? User { get; set; }
        public int TotalAquiredScore { get; set; }
        public string? Result { get; set; }
    }
}
