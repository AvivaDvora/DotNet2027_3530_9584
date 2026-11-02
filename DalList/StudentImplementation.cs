


using System.Reflection;
using DalApi;
using DO;

namespace Dal
{
    internal class StudentImplementation : IStudent
    {
        public int Create(Student item)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");

            if (DataSource.Students.Any(s => s?.Id == item.Id))
                throw new IdExistException("Student with this ID already exists");

            DataSource.Students.Add(item);
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

            return item.Id;
        }

     
        public Student? Read(int id)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");

            var student = DataSource.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)throw new IdNotFoundException("Student with this ID dont exists");
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

            return student;
        }

        
        public List<Student> ReadAll()
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

            return new List<Student>(DataSource.Students);
        }

        public void Update(Student item)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
           
            for (int i = 0; i < DataSource.Students.Count; i++)
            {
                if (DataSource.Students[i]?.Id == item.Id)
                {
                    DataSource.Students[i] = item;
                    Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

                    return;
                }
            }
            throw new IdNotFoundException("Student with this ID does not exist");
        }

        public void Delete(int id)
        {
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "started");
           
            for (int i = 0; i < DataSource.Students.Count; i++)
            {
                if (DataSource.Students[i]?.Id == id)
                {
                    DataSource.Students.RemoveAt(i);
                    Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "finish");

                    return;
                }
            }
              throw new IdNotFoundException("Student with this ID does not exist");
        }
    }
}