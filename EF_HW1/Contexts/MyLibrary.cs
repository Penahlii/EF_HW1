using EF_HW1.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_HW1.Contexts;

public class MyLibrary : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string ConnectionString = "Data Source=DESKTOP-0MEGVK7\\SQLEXPRESS01;" +
            "Initial Catalog=MyLibrary;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;Encrypt=True;" +
            "Trust Server Certificate=True;" +
            "Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False";
        optionsBuilder.UseSqlServer(ConnectionString);
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookType> BookTypes { get; set; }
    public DbSet<Student> Students { get; set; }
}