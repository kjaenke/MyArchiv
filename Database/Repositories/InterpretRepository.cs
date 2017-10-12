namespace Database.Repositories
{
    using Infrastructure;
    using IRepositories;
    using Models;
    using MyArchiv.Models;

    public class InterpretRepository : GenericRepository<Interpret>, IInterpretRepository
    {
        public InterpretRepository(DatabaseContext context) : base(context)
        {
        }
    }
}