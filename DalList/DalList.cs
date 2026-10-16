using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalList :IDal
    {
        public IQuestion Question => new QuestionImplementation();
        public IStudent Student => new StudentImplementation();
        public ITest Test => new TestImplementation();
        public IQuestionForStudent QuestionForStudent => new QuestionForStudentImplementation();
        public IAnswer Answer => new AnswerImplementation();
    }
}
