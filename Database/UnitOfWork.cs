namespace Database
{
    using System;
    using System.IO;
    using Infrastructure;
    using Microsoft.EntityFrameworkCore;
    using Repositories;
    using Repositories.IRepositories;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        public UnitOfWork()
        {
            var directory = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyArchiv", "Archiv"));

            if (!directory.Exists)
            {
                directory.Create();
            }

            var file = new FileInfo(Path.Combine(directory.FullName, "myarchiv.db"));

            _context = new DatabaseContext(file);
        }

        public ITrackRepository Track => new TrackRepository(_context);
        public IAlbumRepository Album => new AlbumRepository(_context);
        public IInterpretRepository Interpret => new InterpretRepository(_context);
        public int SaveChanges() => _context.SaveChanges();
        public void Migrate() => _context.Database.Migrate();
        public void Dispose() => _context?.Dispose();
        public void DeleteDatabase() => _context.Database.EnsureCreated();

    }
}