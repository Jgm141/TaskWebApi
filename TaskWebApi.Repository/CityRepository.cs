using TaskWebApi.DTO;
using TaskWebApi.Repository;
using TaskWebApi.Service.Interfaces.Repository;

namespace TaskWebApi.Repository;

internal class CityRepository : RepositoryBase<City>, ICityRepository 
{
    public CityRepository(TaskWebApiDbContext context) : base(context)
    {

    }
}
