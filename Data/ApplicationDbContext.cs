using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
namespace LibrarySystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Memberships { get; set; }
        public DbSet<Loan>  Loans { get; set; }
    }
}
