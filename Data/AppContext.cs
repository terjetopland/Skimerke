using Skimerke.Models;

namespace Skimerke.Data;

using Microsoft.EntityFrameworkCore;

public class AppContext : DbContext
{
    public DbSet<Person> Persons { get; set; }

    public DbSet<Coach> Coaches { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.use
    }
}