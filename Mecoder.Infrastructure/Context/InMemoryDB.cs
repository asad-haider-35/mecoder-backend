using Mecoder.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Infrastructure.Context
{
    public class InMemoryDB
    {
        public InMemoryDB()
        {
            Quizzes = new List<Quiz>
            {
                new(1, "Personality Test"),
            };

            Questions = new List<Question>
            {
                new(1, 1, "You’re really busy at work and a colleague is telling you their life story and personal woes. You: "),
                new(2, 1, "Being around people makes you feel: "),
                new(3, 1, "During parties or social gatherings, You tend to: "),
                new(4, 1, "When you're dealing with a personal problem, you prefer to: "),
                new(5, 1, "On the topic of public speaking. You: ")
            };

            QuestionOptions = new List<QuestionOption>
            {
                new(1, 1, "Don't dare to interrupt them", 1),
                new(2, 1, "Think its more important to give them some of your time; work can wait", 2),
                new(3, 1, "Interrupt and explain that you are really busy at the moment", 3),

                new(4, 2, "Energized for a while, but there are times when I'd rather be at alone", 2),
                new(5, 2, "A bit exhausted. Being around others can be draining", 1),
                new(6, 2, "Like, I'm alive!", 3),

                new(7, 3, "Spend time with a few people that you know. It's about quality not quantity", 2),
                new(8, 3, "Talk to as many people as you can. You've been called a social butterfly", 3),
                new(9, 3, "Keep to yourself. You can be find planted on the wall or by the punch bowl", 1),

                new(10, 4, "Talk about it with others and enlist their help", 3),
                new(11, 4, "Call your closest friend and discuss it on the phone", 2),
                new(12, 4, "Solve it on your own. You keep your private life private", 1),

                new(13, 5, "Get super nervous. You'd rather write 5 research papers", 1),
                new(14, 5, "Will do it if you have to, but it's not your strongest suit", 2),
                new(15, 5, "Love it, All eyes on you!", 3),
            };
        }

        public List<Quiz> Quizzes { get; set; }
        public List<Question> Questions { get; set; }
        public List<QuestionOption> QuestionOptions { get; set; }
    }
}
