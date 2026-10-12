using DalApi;
using DO;

namespace Dal
{
    internal class QuestionImplementation : IQuestion
    {
        public int Create(Question item)
        {
            if (DataSource.Questions.Any(q => q?.Id == item.Id))
                throw new DalAlreadyExistsException("Question with this ID already exists");

            DataSource.Questions.Add(item);
            return item.Id;
        }

        public Question? Read(int id)
        {
            return DataSource.Questions.FirstOrDefault(q => q?.Id == id);
        }

        public List<Question> ReadAll()
        {
            return new List<Question>();
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
            throw new DalDoesNotExistException("Question with this ID does not exist");
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
            throw new DalDoesNotExistException("Question with this ID does not exist");
        }
    }
}