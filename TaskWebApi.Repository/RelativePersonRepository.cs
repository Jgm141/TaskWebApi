using TaskWebApi.DTO;
using TaskWebApi.Repository;
using TaskWebApi.Service.Interfaces.Repository;

namespace TaskWebApi.Repository;

internal class RelativePersonRepository : RepositoryBase<RelativePerson>, IRelativePersonRepository
{
    public RelativePersonRepository(TaskWebApiDbContext context) : base(context)
    {

    }

    public IEnumerable<RelativePerson> GetAllRelative(int Id)=>
       _dbSet.Where(a => a.PersonId == Id && a.RelativeToId != 0).ToList();    
}
