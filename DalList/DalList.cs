using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalList : IDal
    {
        private readonly DalList instance = new DalList();

        public IQuestion Question { get; }
        public IStudent Student { get; }
        public ITest Test { get; }
        public IQuestionForStudent QuestionForStudent { get; }
        public IAnswer Answer { get; }

        private DalList Instance
        {
            get { return Instance; }
        }



        private DalList()
        {
            instance = this;
            Question = new QuestionImplementation();
            Student = new StudentImplementation();
            Test = new TestImplementation();
            QuestionForStudent = new QuestionForStudentImplementation();
            Answer = new AnswerImplementation();
        }
    }
}