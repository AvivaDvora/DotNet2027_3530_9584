using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface ICrud<T>
    {
        int Create(T item); // Creates new entity object in DAL
        T? Read(int id); // Reads entity object by its ID
        List<T> ReadAll(Func<T, bool>? filter = null); // Stage 1 only, reads all entity objects
        void Update(T item); // Updates entity object
        void Delete(int id); // Deletes an object by its ID
        T? Read(Func<T, bool> filter);
    }
}
