using System.Collections.Generic;
using System.Threading.Tasks;
using QuotesApp.API.Models;

namespace QuotesApp.API.Data
{
    public interface IQuotesRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}