


using DalApi;
using DO;

namespace Dal
{
    internal class StudentImplementation : IStudent
    {
        public int Create(Student item)
        {
          
            if (DataSource.Students.Any(s => s?.Id == item.Id))
                throw new IdExistException("Student with this ID already exists");

            DataSource.Students.Add(item);
            return item.Id;
        }

     
        public Student? Read(int id)
        {
            var student = DataSource.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)throw new IdNotFoundException("Student with this ID dont exists");
            return student;
        }

        
        public List<Student> ReadAll()
        {
            return new List<Student>(DataSource.Students);
        }

        public void Update(Student item)
        {
            for (int i = 0; i < DataSource.Students.Count; i++)
            {
                if (DataSource.Students[i]?.Id == item.Id)
                {
                    DataSource.Students[i] = item;
                    return;
                }
            }
            throw new IdNotFoundException("Student with this ID does not exist");
        }

        public void Delete(int id)
        {
            for (int i = 0; i < DataSource.Students.Count; i++)
            {
                if (DataSource.Students[i]?.Id == id)
                {
                    DataSource.Students.RemoveAt(i);
                    return;
                }
            }
              throw new IdNotFoundException("Student with this ID does not exist");
        }
    }
}