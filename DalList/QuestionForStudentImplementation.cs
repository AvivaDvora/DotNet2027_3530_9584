using DalApi;
using DO;

namespace Dal
{
    internal class QuestionForStudentImplementation : IQuestionForStudent
    {
        public int Create(QuestionForStudent item)
        {
            if (DataSource.QuestionsForStudent.Any(q =>
                    q?.StudentId == item.StudentId &&
                    q?.TestId == item.TestId &&
                    q?.QuestionId == item.QuestionId))
                throw new IdExistException("QuestionForStudent with this key already exists");

            DataSource.QuestionsForStudent.Add(item);
            return 0;
        }

        public QuestionForStudent? Read(int id)
        {
            return DataSource.QuestionsForStudent.FirstOrDefault(q =>
                q?.StudentId == id || q?.TestId == id || q?.QuestionId == id);
        }

        public QuestionForStudent? Read(int studentId, int testId, int questionId) =>
            DataSource.QuestionsForStudent.FirstOrDefault(q =>
                q?.StudentId == studentId &&
                q?.TestId == testId &&
                q?.QuestionId == questionId);

        public List<QuestionForStudent> ReadAll() =>
            new List<QuestionForStudent>(DataSource.QuestionsForStudent);

        public void Update(QuestionForStudent item)
        {
            for (int i = 0; i < DataSource.QuestionsForStudent.Count; i++)
                if (DataSource.QuestionsForStudent[i]?.StudentId == item.StudentId &&
                    DataSource.QuestionsForStudent[i]?.TestId == item.TestId &&
                    DataSource.QuestionsForStudent[i]?.QuestionId == item.QuestionId)
                {
                    DataSource.QuestionsForStudent[i] = item;
                    return;
                }

            throw new IdNotFoundException("QuestionForStudent with this key does not exist");
        }

        public void Delete(int id)
        {
            for (int i = 0; i < DataSource.QuestionsForStudent.Count; i++)
                if (DataSource.QuestionsForStudent[i]?.StudentId == id ||
                    DataSource.QuestionsForStudent[i]?.TestId == id ||
                    DataSource.QuestionsForStudent[i]?.QuestionId == id)
                {
                    DataSource.QuestionsForStudent.RemoveAt(i);
                    return;
                }

            throw new IdNotFoundException("QuestionForStudent with this ID does not exist");
        }

        public void Delete(int studentId, int testId, int questionId)
        {
            for (int i = 0; i < DataSource.QuestionsForStudent.Count; i++)
                if (DataSource.QuestionsForStudent[i]?.StudentId == studentId &&
                    DataSource.QuestionsForStudent[i]?.TestId == testId &&
                    DataSource.QuestionsForStudent[i]?.QuestionId == questionId)
                {
                    DataSource.QuestionsForStudent.RemoveAt(i);
                    return;
                }

            throw new IdNotFoundException("QuestionForStudent with this key does not exist");
        }
    }
}