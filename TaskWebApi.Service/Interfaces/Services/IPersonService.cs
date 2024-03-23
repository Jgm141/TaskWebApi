using TaskWebApi.DTO;

namespace TaskWebApi.Service.Interfaces.Services;

public interface IPersonService
{
    void CreatePerson(Person person);
    void UpdatePerson(Person person);
    void DeletePerson(int personId);
}
