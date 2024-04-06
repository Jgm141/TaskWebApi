using TaskWebApi.DTO;
using TaskWebApi.Repository;
using TaskWebApi.Service.Interfaces.Repository;

namespace TaskWebApi.Repository;

internal class RelativePersonRepository : RepositoryBase<RelativePerson>, IRelativePersonRepository
{
    public RelativePersonRepository(TaskWebApiDbContext context) : base(context)
    {

    }
    public IEnumerable<RelativePerson> GetAllRelative(int personId) =>
           _dbSet.Where(a => a.PersonId == personId && a.RelativeToId != 0).ToList();
    public int GetAllRelativeCount(int personId) => GetAllRelative(personId).Count();
}
