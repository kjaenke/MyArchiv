using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Repositories
{
    using Infrastructure;
    using MyArchiv.Models;

    class AlbumRepository : GenericRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
