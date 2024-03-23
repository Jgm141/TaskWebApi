using TaskWebApi.DTO;
using TaskWebApi.Service.Interfaces.Repository;
using TaskWebApi.Service.Interfaces.Services;


namespace TaskWebApi.Service;

public sealed class CityService : ICityService
{
    private readonly IUnitOfWork _unitOfWork;

    public CityService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void CreateCity(City city)
    {
        if (city == null) throw new ArgumentNullException(nameof(city));
        
        _unitOfWork.CityRepository.Insert(city);
        SaveChanges();
    }

    public void UpdateCity(City city)
    {
        if (city == null) throw new ArgumentNullException(nameof(city));

        _unitOfWork.CityRepository.Update(city);
        SaveChanges();
    }

    public void DeleteCity(int cityId)
    {
        _unitOfWork.CityRepository.Delete(cityId);
        SaveChanges();
    }    

    public void SaveChanges()
    {
        _unitOfWork.SaveChanges();
    }
}