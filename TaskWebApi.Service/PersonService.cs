using TaskWebApi.DTO;
using TaskWebApi.Service.Interfaces.Repository;
using TaskWebApi.Service.Interfaces.Services;

namespace TaskWebApi.Service;

public class PersonService : IPersonService
{
    private readonly IUnitOfWork _unitOfWork;

    public PersonService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void CreatePerson(Person person)
    {
        if (person == null) throw new ArgumentNullException(nameof(person));

        _unitOfWork.PersonRepository.Insert(person);
        SaveChanges();
    }

    public void DeletePerson(int personId)
    {
        _unitOfWork.PersonRepository.Delete(personId);
        SaveChanges();
    }

    public void UpdatePerson(Person person)
    {
        if (person == null) throw new ArgumentNullException(nameof(person));

        _unitOfWork.PersonRepository.Update(person);
        SaveChanges();
    }
    public void SaveChanges()
    {
        _unitOfWork.SaveChanges();
    }
}
