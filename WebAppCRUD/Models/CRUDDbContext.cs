using Microsoft.EntityFrameworkCore;
using WebAppCRUD.Models.Entities;

namespace WebAppCRUD.Models
{
    public class CRUDDbContext(DbContextOptions<CRUDDbContext> options) : DbContext(options)
    {
        public required DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
