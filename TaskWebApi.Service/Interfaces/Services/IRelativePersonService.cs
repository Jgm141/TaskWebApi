using TaskWebApi.DTO;

namespace TaskWebApi.Service.Interfaces.Services;

public interface IRelativePersonService
{
    void AddRelartive(RelativePerson relativePerson);
    void UpdateRelative(RelativePerson relativePerson);
    void DeleteRelartive(int personId);
    IEnumerable<RelativePerson> GetAllRelative(int personId);
}
