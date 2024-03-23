using System;
using TaskWebApi.DTO;
using TaskWebApi.Service.Interfaces.Repository;
using TaskWebApi.Service.Interfaces.Services;

namespace TaskWebApi.Service;

public class PhoneNumberService : IPhoneNumberService
{
    private readonly IUnitOfWork _unitOfWork;

    public PhoneNumberService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void CreatePhoneNumber(PhoneNumber phoneNumber)
    {
        if (phoneNumber == null) throw new ArgumentNullException(nameof(phoneNumber));

        _unitOfWork.phoneNumberRepository.Insert(phoneNumber);
        SaveChanges();
    }

    public void DeletePhoneNumber(int phoneNumberId)
    {
        _unitOfWork.phoneNumberRepository.Delete(phoneNumberId);
        SaveChanges();
    }

    public void UpdatePhoneNumber(PhoneNumber phoneNumber)
    {
        if (phoneNumber == null) throw new ArgumentNullException(nameof(phoneNumber));

        _unitOfWork.phoneNumberRepository.Update(phoneNumber);
        SaveChanges();
    }
    public void SaveChanges()
    {
        _unitOfWork.SaveChanges();
    }
}
