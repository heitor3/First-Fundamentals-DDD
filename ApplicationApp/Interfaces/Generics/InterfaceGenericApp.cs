using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces.Generics
{
    public interface InterfaceGenericApp<T> where T : class
    {
        Task Add(T entity);

        Task Update(T entity);

        Task Delete(T entity);

        Task<T> GetEntityById(int id);

        Task<List<T>> List();

    }
}
