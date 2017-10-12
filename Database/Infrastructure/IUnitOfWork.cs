namespace Database.Infrastructure
{
    using System;
    using Repositories.IRepositories;

    public interface IUnitOfWork : IDisposable
    {
        ITrackRepository Track { get; }
        IAlbumRepository Album { get; }
        IInterpretRepository Interpret { get; }
        int SaveChanges();
        void Migrate();
        void DeleteDatabase();
    }
}