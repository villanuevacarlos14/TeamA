using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AppKeep.Data
{
    public class AppKeepContext : DbContext
    {
        private readonly IConfiguration _config;
        public AppKeepContext(IConfiguration config){
            this._config = config;
        }

        public DbSet<UserEntity> Users { get; set; }

        public DbSet<MachineEntity> Machines { get; set; }

        public DbSet<MachinePartEntity> MachineParts { get; set; }

        public DbSet<UserMachineEntity> UserMachines { get; set; }

        public DbSet<UpkeepTemplateEntity> UpkeepTemplates { get; set; }

        public DbSet<UpkeepTemplateDetailEntity> UpkeepTemplateDetails { get; set; }

        public DbSet<UpkeepProfileEntity> UpkeepProfiles { get; set; }

        public DbSet<MyPlanEntity> MyPlans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = this._config.GetConnectionString("AppKeepContext");
            optionsBuilder.UseMySQL(connectionString);
        }
    }
}