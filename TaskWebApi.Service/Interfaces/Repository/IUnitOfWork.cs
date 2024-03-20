namespace TaskWebApi.Service.Interfaces.Repository;

public interface IUnitOfWork :IDisposable
{
    IPersonRepository PersonRepository { get; }
    IPhoneNumberRepository phoneNumberRepository { get; }
    IRelativePersonRepository RelativePersonRepository { get; }
    ICityRepository CityRepository { get; }
    int SaveChanges();
    void BeginTransaction();
    void CommitTransaction();
    void RollBack();
}
