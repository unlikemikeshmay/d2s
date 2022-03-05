using Microsoft.EntityFrameworkCore;
using bulkybook.Models;
namespace bulkybook.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }
    public DbSet<Category> Categories {get;set;}
}