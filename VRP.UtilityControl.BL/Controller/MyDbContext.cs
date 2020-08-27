using Microsoft.EntityFrameworkCore;
using VRP.UtilityControl.BL.Model;

namespace VRP.UtilityControl.BL.Controller
{
    public class MyDbContext : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Utility> Utilities { get; set; }

        public MyDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=VRP.UCdb;Trusted_Connection=True;");
        }
    }
}
