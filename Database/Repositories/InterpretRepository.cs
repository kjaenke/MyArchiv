namespace Database.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Infrastructure;
    using IRepositories;
    using Microsoft.EntityFrameworkCore;
    using Models;
   

    public class InterpretRepository : GenericRepository<Interpret>, IInterpretRepository
    {
        public InterpretRepository(DatabaseContext context) : base(context)
        {
        }

        public IEnumerable<Interpret> Get() => Context.Set<Interpret>()
            .Include(x => x.Items)
            .ThenInclude(x => x.Album)
            .ThenInclude(x => x.Items)
            .ThenInclude(x => x.Track)
            .ToList();
    }
}