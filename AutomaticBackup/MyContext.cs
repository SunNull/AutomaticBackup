using Microsoft.EntityFrameworkCore;

namespace AutomaticBackup
{
    public class MyContext : DbContext
    {
        public DbSet<USB> USB { get; set; }
        public DbSet<IsAuto> IsAuto { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=HH.db");
        }
    }

    public class USB 
    {
        public string? ID { get; set; }
        public string? URL { get; set; }
        public string? NewUrl { get; set; }
    }
    public class IsAuto
    {
        public string? ID { get; set; }
        public int Auto { get; set; }
    }
}
