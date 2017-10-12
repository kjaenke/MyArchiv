namespace Database.Repositories.IRepositories
{
    using System.Collections.Generic;
    using Infrastructure;
    using Models;
    using MyArchiv.Models;

    public interface IInterpretRepository : IGenericRepository<Interpret>
    {
        IEnumerable<Interpret> Get();
    }
}