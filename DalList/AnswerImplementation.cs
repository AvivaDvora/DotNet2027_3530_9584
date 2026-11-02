using System.Reflection;
using DalApi;
using DO;
using Tools;

namespace Dal
{
    internal class AnswerImplementation : IAnswer
    {
        public void Add(Answer item)
        {
            DataSource.Answers.Add(item);
        }

        public int Create(Answer item)
        {

            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "starting");
            int id = DataSource.Config.NextAnswerId;
            Answer newAnswer = item with { Id = id };

            DataSource.Answers.Add(newAnswer);

            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

            return newAnswer.Id;
        }

        public Answer? Read(int id)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "starting");

            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

            return DataSource.Answers.FirstOrDefault(a => a?.Id == id);
        }

        public List<Answer> ReadAll()
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "starting");

            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");
            return new List<Answer>(DataSource.Answers);
        }

        public void Update(Answer item)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "starting");

            for (int i = 0; i < DataSource.Answers.Count; i++)
                if (DataSource.Answers[i]?.Id == item.Id)
                {
                    DataSource.Answers[i] = item;
                    Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");
                    return;
                }
            throw new IdNotFoundException("Answer with this ID does not exist");
        }

        public void Delete(int id)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "starting");

            for (int i = 0; i < DataSource.Answers.Count; i++)
                if (DataSource.Answers[i]?.Id == id)
                {
                    DataSource.Answers.RemoveAt(i);
                    Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");
                    return;
                }
            throw new IdNotFoundException("Answer with this ID does not exist");
        }
    }
}