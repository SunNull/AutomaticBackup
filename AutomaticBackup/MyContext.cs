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
        /// <summary>
        /// 主键，没啥用
        /// </summary>
        public string? ID { get; set; }
        /// <summary>
        /// 待备份路径
        /// </summary>
        public string? URL { get; set; }
        /// <summary>
        /// 备份路径
        /// </summary>
        public string? NewUrl { get; set; }
    }
    /// <summary>
    /// 是否开启自动备份
    /// </summary>
    public class IsAuto
    {
        /// <summary>
        /// 习惯加上ID
        /// </summary>
        public string? ID { get; set; }
        /// <summary>
        /// 0不开启，1开启
        /// </summary>
        public int Auto { get; set; }
    }
}
