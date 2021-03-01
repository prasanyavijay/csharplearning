using Microsoft.EntityFrameworkCore;
using AlertMsg.Models;

namespace AlertMsg.Data
{
    public class AlertContext: DbContext
    {
        public AlertContext(DbContextOptions<AlertContext> options) : base(options)
        {
        }      
        public DbSet<AlertModel> Alerts{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlertModel>().ToTable("Alert");
        }

    }
}
