using Microsoft.EntityFrameworkCore;
using TaskWebApi.Service.Interfaces.Repository;

namespace TaskWebApi.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly TaskWebApiDbContext _context;
    private readonly Lazy<IPersonRepository> _personRepository;
    private readonly Lazy<IPhoneNumberRepository> _phoneNumberRepository;
    private readonly Lazy<IRelativePersonRepository> _relativePersonRepository;
    private readonly Lazy<ICityRepository> _cityRepository;

    public UnitOfWork(TaskWebApiDbContext context)
    {
        _context= context ?? throw new ArgumentNullException(nameof(context));
        _personRepository = new Lazy<IPersonRepository>(() => new PersonRepository(context));
        _phoneNumberRepository= new Lazy<IPhoneNumberRepository>(() => new PhoneNumberRepository(context));
        _relativePersonRepository = new Lazy<IRelativePersonRepository>(()=> new RelativePersonRepository(context));
        _cityRepository =new Lazy<ICityRepository>(() => new CityRepository(context));
    }

    public IPersonRepository PersonRepository => _personRepository.Value;

    public IPhoneNumberRepository phoneNumberRepository => _phoneNumberRepository.Value;

    public IRelativePersonRepository RelativePersonRepository => _relativePersonRepository.Value;

    public ICityRepository CityRepository => _cityRepository.Value;

    public int SaveChanges() => _context.SaveChanges();

    public void BeginTransaction()
    {
        if (_context.Database.CurrentTransaction != null)
        {
            throw new InvalidOperationException("A Transaction is already in progress.");
        }

        _context.Database.BeginTransaction();
    }

    public void CommitTransaction()
    {
        try
        {
            _context.Database.CurrentTransaction?.Commit();
        }
        catch
        {
            _context.Database.CurrentTransaction?.Rollback();
            throw;
        }
        finally
        {
            _context.Database.CurrentTransaction?.Dispose();
        }
    }

    public void RollBack()
    {
        try
        {
            _context.Database.CurrentTransaction?.Rollback();
        }
        finally
        {
            _context.Database.CurrentTransaction?.Dispose();
        }
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}
