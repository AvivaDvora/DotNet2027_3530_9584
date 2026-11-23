using DalApi;

namespace Dal
{
    public sealed class DalList : IDal
    {
        // Lazy + thread-safe, and the setter is private, so only "Instance" can be assigned.
        private static readonly Lazy<DalList> s_instance =
            new Lazy<DalList>(() => new DalList());

        public static DalList Instance => s_instance.Value;

        public IQuestion Question { get; }
        public IStudent Student { get; }
        public ITest Test { get; }
        public IQuestionForStudent QuestionForStudent { get; }
        public IAnswer Answer { get; }

        private DalList()
        {
            Question = new QuestionImplementation();
            Student = new StudentImplementation();
            Test = new TestImplementation();
            QuestionForStudent = new QuestionForStudentImplementation();
            Answer = new AnswerImplementation();
        }
    }
}
