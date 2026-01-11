using Microsoft.EntityFrameworkCore;
using MVC_Task.Models;

namespace MVC_Task.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Server=MSI\\SQL2025;Database=MVCTask_Db;Trusted_Connection=True;TrustServerCertificate=True"

            );
        }
    }
}
