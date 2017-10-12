namespace Database.Repositories
{
    using Infrastructure;
    using IRepositories;
    using MyArchiv.Models;

    public class TrackRepository : GenericRepository<Track>, ITrackRepository
    {
        public TrackRepository(DatabaseContext context) : base(context)
        {
        }
    }
}