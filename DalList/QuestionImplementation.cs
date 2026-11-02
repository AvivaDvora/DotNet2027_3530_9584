using System.Reflection;
using DalApi;
using DO;

namespace Dal
{
    internal class QuestionImplementation : IQuestion
    {
        public int Create(Question item)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
            int id = DataSource.Config.NextQuestionId;
            Question newQuestion = item with { Id = id };

            DataSource.Questions.Add(newQuestion);
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");
            return newQuestion.Id;
        }

        public Question? Read(int id)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");
            return DataSource.Questions.FirstOrDefault(q => q?.Id == id);
        }

        public List<Question> ReadAll()
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");
            return new List<Question>(DataSource.Questions);
        }

        public void Update(Question item)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
            for (int i = 0; i < DataSource.Questions.Count; i++)
            {
                if (DataSource.Questions[i]?.Id == item.Id)
                {
                    DataSource.Questions[i] = item;
                    Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

                    return;
                }
            }
            throw new IdNotFoundException("Question with this ID does not exist");
        }

        public void Delete(int id)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
           
            for (int i = 0; i < DataSource.Questions.Count; i++)
            {
                if (DataSource.Questions[i]?.Id == id)
                {
                    DataSource.Questions.RemoveAt(i);
                    Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

                    return;
                }
            }
            throw new IdNotFoundException("Question with this ID does not exist");
        }
    }
}