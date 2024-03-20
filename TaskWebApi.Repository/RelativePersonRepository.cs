using TaskWebApi.DTO;
using TaskWebApi.Service.Interfaces.Repository;

namespace TaskWebApi.Repository;

internal class RelativePersonRepository : RepositoryBase<RelativePerson>, IRelativePersonRepository
{
    public RelativePersonRepository(TaskWebApiDbContext context) : base(context)
    {

    }
}
