using Microsoft.EntityFrameworkCore;
using AlertMsg.Models;

namespace AlertMsg.Data
{
    public class AlertMessageContext:DbContext
    {
        public AlertMessageContext(DbContextOptions<AlertMessageContext> options) : base(options)
        {


        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<AlertModel> Alerts { get; set; }
        public DbSet<AlertSetting> AlertMsgs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().ToTable("User");
            modelBuilder.Entity<AlertModel>().ToTable("Alert");
            modelBuilder.Entity<AlertSetting>().ToTable("AlertMessage");
        }

    }
}


