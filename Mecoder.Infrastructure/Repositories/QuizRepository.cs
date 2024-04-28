using Mecoder.Infrastructure.Context;
using Mecoder.Infrastructure.IRepositories;
using Mecoder.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecoder.Infrastructure.Repositories
{
    public class QuizRepository: IQuizRepository
    {
        private readonly InMemoryDB _inMemoryDB;

        public QuizRepository(InMemoryDB inMemoryDB) 
        {
            _inMemoryDB = inMemoryDB;
        }

        public Quiz Get(int id) 
        {
            Quiz quiz = _inMemoryDB.Quizzes.FirstOrDefault(x => x.Id == id);

            if (quiz != null)
            {
                List<Question> questionList = _inMemoryDB.Questions.Where(x => x.QuizId == id).ToList();
                
                if(questionList.Count > 0)
                {
                    List<int> questionIds = questionList.Select(x => x.Id).ToList();
                    List<QuestionOption> questionOptions = _inMemoryDB.QuestionOptions.Where(x => questionIds.Contains(x.QuestionId)).ToList();

                    questionList.ForEach(x => x.Options = questionOptions.Where(o => o.QuestionId == x.Id).ToList());

                    quiz.Questions = questionList;
                }
            }
                
            return quiz;
        }
    }
}
