using System.Collections.Generic;

namespace EntityFrameworkExample.Library.Data.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
