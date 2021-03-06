using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> Options) : base (Options){} 

       public DbSet<Values> Values { get; set; }
    }
}