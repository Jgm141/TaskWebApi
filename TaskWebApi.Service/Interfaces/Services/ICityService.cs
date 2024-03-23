using TaskWebApi.DTO;

namespace TaskWebApi.Service.Interfaces.Services;

public interface ICityService
{
    void CreateCity(City city);
    void UpdateCity(City city);
    void DeleteCity(int cityId);
}
