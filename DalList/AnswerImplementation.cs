using DalApi;
using DO;

namespace Dal
{
    internal class AnswerImplementation : IAnswer
    {
        public void Add(Answer item)
        {
            if (DataSource.Answers.Any(a => a?.Id == item.Id))
                throw new DalAlreadyExistsException("Answer with this ID already exists");
            DataSource.Answers.Add(item);
        }

        public int Create(Answer item)
        {
            int id = DataSource.Config.NextAnswerId;
            Answer newAnswer = item with { Id = id };
            
            DataSource.Answers.Add(newAnswer);
            return newAnswer.Id;
        }

        public Answer? Read(int id) =>
            DataSource.Answers.FirstOrDefault(a => a?.Id == id);

        public List<Answer> ReadAll() => new List<Answer>(DataSource.Answers);

        public void Update(Answer item)
        {
            for (int i = 0; i < DataSource.Answers.Count; i++)
                if (DataSource.Answers[i]?.Id == item.Id)
                { DataSource.Answers[i] = item; return; }
            throw new DalDoesNotExistException("Answer with this ID does not exist");
        }

        public void Delete(int id)
        {
            for (int i = 0; i < DataSource.Answers.Count; i++)
                if (DataSource.Answers[i]?.Id == id)
                { DataSource.Answers.RemoveAt(i); return; }
            throw new DalDoesNotExistException("Answer with this ID does not exist");
        }
    }
}