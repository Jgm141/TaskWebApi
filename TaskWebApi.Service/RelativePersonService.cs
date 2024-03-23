using TaskWebApi.DTO;
using TaskWebApi.Service.Interfaces.Repository;
using TaskWebApi.Service.Interfaces.Services;

namespace TaskWebApi.Service;

public class RelativePersonService : IRelativePersonService
{
    private readonly IUnitOfWork _unitOfWork;

    public RelativePersonService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void AddRelartive(RelativePerson relativePerson)
    {
        if (relativePerson == null) throw new ArgumentNullException(nameof(relativePerson));

        _unitOfWork.RelativePersonRepository.Insert(relativePerson);
        SaveChanges();
    }

    public void DeleteRelartive(int personId)
    {
        _unitOfWork.RelativePersonRepository.Delete(personId);
        SaveChanges();
    }

    public void UpdateRelative(RelativePerson relativePerson)
    {
        if (relativePerson == null) throw new ArgumentNullException(nameof(relativePerson));

        _unitOfWork.RelativePersonRepository.Update(relativePerson);
        SaveChanges();
    }
    public IEnumerable<RelativePerson> GetAllRelative(int personId)
    {
        throw new NotImplementedException();
    }
    public void SaveChanges()
    {
        _unitOfWork.SaveChanges();
    }
}
