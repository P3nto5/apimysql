using agilAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace agilAPI.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options){}

        public DbSet<Person> Persons{get; set;}
        public DbSet<User> Users{ get; set;}
    }
}