using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuotesApp.API.Models;

namespace QuotesApp.API.Data
{
    public class QuotesRepository : IQuotesRepository
    {
        private readonly DataContext _context;

        public QuotesRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            // Include the quotes of this user with the given Id.
            var user = await _context.Users
            .Include(user => user.Quotes).ThenInclude( quote => quote.Materials)
            .Include(user => user.Quotes).ThenInclude(quote => quote.Customer)
            .FirstOrDefaultAsync(user => user.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            // Include Quotes from User, then include Materials and Customer from Quotes
            var users = await _context.Users
            .Include(user => user.Quotes).ThenInclude( quote => quote.Materials)
            .Include(user => user.Quotes).ThenInclude(quote => quote.Customer).ToListAsync();
            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}