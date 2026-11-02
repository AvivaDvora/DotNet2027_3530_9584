using System.Reflection;
using DalApi;
using DO;

namespace Dal
{
    internal class QuestionForStudentImplementation : IQuestionForStudent
    {
        public int Create(QuestionForStudent item)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");

            if (DataSource.QuestionsForStudent.Any(q =>
                    q?.StudentId == item.StudentId &&
                    q?.TestId == item.TestId &&
                    q?.QuestionId == item.QuestionId))
                throw new IdExistException("QuestionForStudent with this key already exists");

            DataSource.QuestionsForStudent.Add(item);
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");
            return 0;
        }

        public QuestionForStudent? Read(int id)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");
            return DataSource.QuestionsForStudent.FirstOrDefault(q =>
                q?.StudentId == id || q?.TestId == id || q?.QuestionId == id);
        }

        public QuestionForStudent? Read(int studentId, int testId, int questionId)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");
            return  DataSource.QuestionsForStudent.FirstOrDefault(q =>
                    q?.StudentId == studentId &&
                    q?.TestId == testId &&
                    q?.QuestionId == questionId);
        }
        public List<QuestionForStudent> ReadAll()
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");
            return new List<QuestionForStudent>(DataSource.QuestionsForStudent);
        }
        public void Update(QuestionForStudent item)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");

            for (int i = 0; i < DataSource.QuestionsForStudent.Count; i++)
                if (DataSource.QuestionsForStudent[i]?.StudentId == item.StudentId &&
                    DataSource.QuestionsForStudent[i]?.TestId == item.TestId &&
                    DataSource.QuestionsForStudent[i]?.QuestionId == item.QuestionId)
                {
                    DataSource.QuestionsForStudent[i] = item;
                    Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");
                    return;
                }

            throw new IdNotFoundException("QuestionForStudent with this key does not exist");
        }

        public void Delete(int id)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");

            for (int i = 0; i < DataSource.QuestionsForStudent.Count; i++)
                if (DataSource.QuestionsForStudent[i]?.StudentId == id ||
                    DataSource.QuestionsForStudent[i]?.TestId == id ||
                    DataSource.QuestionsForStudent[i]?.QuestionId == id)
                {
                    DataSource.QuestionsForStudent.RemoveAt(i);
                    return;
                }
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

            throw new IdNotFoundException("QuestionForStudent with this ID does not exist");
        }

        public void Delete(int studentId, int testId, int questionId)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");

            for (int i = 0; i < DataSource.QuestionsForStudent.Count; i++)
                if (DataSource.QuestionsForStudent[i]?.StudentId == studentId &&
                    DataSource.QuestionsForStudent[i]?.TestId == testId &&
                    DataSource.QuestionsForStudent[i]?.QuestionId == questionId)
                {
                    DataSource.QuestionsForStudent.RemoveAt(i);
                    Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");
                    return;
                }

            throw new IdNotFoundException("QuestionForStudent with this key does not exist");
        }
    }
}