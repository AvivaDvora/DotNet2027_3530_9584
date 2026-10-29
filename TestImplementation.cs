using DalApi;
using DO;

namespace Dal
{
    internal class TestImplementation : ITest
    {
        public int Create(Test item)
        {
            int id = DataSource.Config.NextTestId;
            Test newTest = item with { Id = id };

            DataSource.Tests.Add(newTest);
            return newTest.Id;
        }
       

        public Test? Read(int id)
        {
            return DataSource.Tests.FirstOrDefault(t => t?.Id == id);
        }

        public List<Test> ReadAll()
        {
            return new List<Test>(DataSource.Tests);
        }

        public void Update(Test item)
        {
            for (int i = 0; i < DataSource.Tests.Count; i++)
            {
                if (DataSource.Tests[i]?.Id == item.Id)
                {
                    DataSource.Tests[i] = item;
                    return;
                }
            }
            throw new IdNotFoundException("Test with this ID does not exist");
        }

        public void Delete(int id)
        {
            for (int i = 0; i < DataSource.Tests.Count; i++)
            {
                if (DataSource.Tests[i]?.Id == id)
                {
                    DataSource.Tests.RemoveAt(i);
                    return;
                }
            }
            throw new IdNotFoundException("Test with this ID does not exist");
        }
    }
}
