using CritoProjectDG.Models;
using Microsoft.EntityFrameworkCore;

namespace CritoProjectDG.Contexts;

public class DataContext : DbContext
{
    protected DataContext()
    {

    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<ContactEntity> Contacts { get; set; }
    public DbSet<MessageEntity> Messages { get; set; }

}
