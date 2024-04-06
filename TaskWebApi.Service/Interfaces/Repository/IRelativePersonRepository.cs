using TaskWebApi.DTO;

namespace TaskWebApi.Service.Interfaces.Repository;

public interface IRelativePersonRepository : IRepositoryBase<RelativePerson>
{
    IEnumerable<RelativePerson> GetAllRelative(int personId);
    int GetAllRelativeCount(int personId);
}
