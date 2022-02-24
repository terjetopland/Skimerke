using Skimerke.Models;

namespace Skimerke.Data;

using Microsoft.EntityFrameworkCore;

public class SkimerkeContext : DbContext
{
    public DbSet<Person> Persons { get; set; }

    public DbSet<Coach> Coaches { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("server=localhost;port=3306;database=Skimerke;user=root;password=xxx");
        
        
    }
}