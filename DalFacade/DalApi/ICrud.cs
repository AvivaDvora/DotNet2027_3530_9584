using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface ICrud <T>
    {
        interface int Create(T item); //Creates new entity object in DAL
        interface T? Read(int id); //Reads entity object by its ID 
        interface List<T> ReadAll(Func<T, bool>? filter = null); //stage 1 only, Reads all entity objects
        interface void Update(T item); //Updates entity object
        interface void Delete(int id); //Deletes an object by its Id
        interface T? Read(Func<T, bool> filter);

    }
}
