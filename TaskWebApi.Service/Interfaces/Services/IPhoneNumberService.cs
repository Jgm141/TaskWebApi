using TaskWebApi.DTO;

namespace TaskWebApi.Service.Interfaces.Services;

public interface IPhoneNumberService
{
    void CreatePhoneNumber(PhoneNumber phoneNumber);
    void UpdatePhoneNumber(PhoneNumber phoneNumber);
    void DeletePhoneNumber(int phoneNumberId);
}
