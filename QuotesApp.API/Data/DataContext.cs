using Microsoft.EntityFrameworkCore;
using QuotesApp.API.Models;

namespace QuotesApp.API.Data
{
        public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Quote> Quotes { get; set; }
        //public DbSet<DesignPartner> DesignPartners { get; set; }
    }
}