using System.Reflection;
using DalApi;
using DO;

namespace Dal
{
    internal class TestImplementation : ITest
    {
        public int Create(Test item)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
            
            int id = DataSource.Config.NextTestId;
            Test newTest = item with { Id = id };

            DataSource.Tests.Add(newTest);
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

            return newTest.Id;
        }
       

        public Test? Read(int id)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

            return DataSource.Tests.FirstOrDefault(t => t?.Id == id);
        }

        public List<Test> ReadAll()
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

            return new List<Test>(DataSource.Tests);
        }

        public void Update(Test item)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
          
            for (int i = 0; i < DataSource.Tests.Count; i++)
            {
                if (DataSource.Tests[i]?.Id == item.Id)
                {
                    DataSource.Tests[i] = item; 
                    Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

                    return;
                }
            }
            throw new IdNotFoundException("Test with this ID does not exist");
        }

        public void Delete(int id)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
           
            for (int i = 0; i < DataSource.Tests.Count; i++)
            {
                if (DataSource.Tests[i]?.Id == id)
                {
                    DataSource.Tests.RemoveAt(i);
                    Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

                    return;
                }
            }
            throw new IdNotFoundException("Test with this ID does not exist");
        }
    }
}
