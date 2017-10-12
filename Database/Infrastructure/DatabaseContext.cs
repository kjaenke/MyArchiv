namespace Database.Infrastructure
{
    using System.IO;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using MyArchiv.Models;


    public class DatabaseContext : DbContext
    {
        private readonly string _databaseFile;

        public DatabaseContext()
        {
            if (string.IsNullOrEmpty(_databaseFile))
            {
                _databaseFile = "myyarchiv.db";
            }
        }

        public DatabaseContext(FileSystemInfo databaseFile) : this() => _databaseFile = databaseFile.FullName;
        public DbSet<Track> Tracks => Set<Track>();
        public DbSet<Album> Albums => Set<Album>();
        public DbSet<Interpret> Interprets => Set<Interpret>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databaseFile}");
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlbumItem>(x => { x.HasKey(item => new {item.AlbumId, item.TrackId}); });
            modelBuilder.Entity<InterpretItem>(x => { x.HasKey(item => new {item.AlbumId, item.InterpretId}); });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}