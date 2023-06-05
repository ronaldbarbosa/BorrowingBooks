using BorrowingBooks.Models;
using Microsoft.EntityFrameworkCore;

namespace BorrowingBooks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BorrowModel> Borrowings { get; set; }
    }
}
