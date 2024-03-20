using TaskWebApi.DTO;
using TaskWebApi.Service.Interfaces.Repository;

namespace TaskWebApi.Repository;

public sealed class PhoneNumberRepository : RepositoryBase<PhoneNumber>, IPhoneNumberRepository
{
    public PhoneNumberRepository(TaskWebApiDbContext context) : base(context)
    {

    }
}
