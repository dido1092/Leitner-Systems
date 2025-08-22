using Leitner_Systems.LeitnerSystemsDataCommon;
using Leitner_Systems.LeitnerSystemsDataModels;
using Microsoft.EntityFrameworkCore;

namespace Leitner_Systems.LeitnerSystemsData
{
    public class LeitnerSystemsContex : DbContext
    {

        public LeitnerSystemsContex()
        {

        }

        public DbSet<EnBgWord> EnBgWords { get; set; }
        public DbSet<BoxOne> BoxOnes { get; set; }
        public DbSet<BoxTwo> BoxTwos { get; set; }
        public DbSet<BoxThree> BoxThrees { get; set; }
        public DbSet<BoxFour> BoxFours { get; set; }
        public DbSet<BoxFive> BoxFives { get; set; }
        public DbSet<Tmr> Timers { get; set; }
        public DbSet<WordMovement> WordMovements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
                optionsBuilder.EnableSensitiveDataLogging();
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}
