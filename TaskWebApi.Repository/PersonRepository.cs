using TaskWebApi.DTO;
using TaskWebApi.Service.Interfaces.Repository;

namespace TaskWebApi.Repository;

public sealed class PersonRepository : RepositoryBase<Person>, IPersonRepository
{
    public PersonRepository(TaskWebApiDbContext context ) : base(context)
    {

    }
}
