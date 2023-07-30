using CityApi.Models;

namespace Services
{
    public interface ICityService
    {
        CityDto GetCityById(int id);
        void AddCity(CityDto city);
        CityDto GetRandomCity();
        List<CityDto> GetCitiesByRegion(string region);
    }
}