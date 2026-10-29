using DalApi;
using DO;

namespace Dal
{
    internal class QuestionImplementation : IQuestion
    {
        public int Create(Question item)
        {
            int id = DataSource.Config.NextQuestionId;
            Question newQuestion = item with { Id = id };

            DataSource.Questions.Add(newQuestion);
            return newQuestion.Id;
        }

        public Question? Read(int id)
        {
            return DataSource.Questions.FirstOrDefault(q => q?.Id == id);
        }

        public List<Question> ReadAll()
        {
            return new List<Question>(DataSource.Questions);
        }

        public void Update(Question item)
        {
            for (int i = 0; i < DataSource.Questions.Count; i++)
            {
                if (DataSource.Questions[i]?.Id == item.Id)
                {
                    DataSource.Questions[i] = item;
                    return;
                }
            }
            throw new IdNotFoundException("Question with this ID does not exist");
        }

        public void Delete(int id)
        {
            for (int i = 0; i < DataSource.Questions.Count; i++)
            {
                if (DataSource.Questions[i]?.Id == id)
                {
                    DataSource.Questions.RemoveAt(i);
                    return;
                }
            }
            throw new IdNotFoundException("Question with this ID does not exist");
        }
    }
}