using AutoMapper;
using CityApi.Models;
using Database.Model;
using Database.Repositories;
using static Services.CityService;

namespace Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public CityService(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        public CityDto GetCityById(int cityDto)
        {
            var cities = _cityRepository.GetAllCities();
            if (cities == null)
                return null;

            var city = cities.Where(el => el.Id == cityDto).FirstOrDefault();

            return this._mapper.Map<CityDto>(city);
        }

        public void AddCity(CityDto city)
        {
            _cityRepository.AddCity(new City
            {
                Id = city.Id,
                Country = city.Country,
                Name = city.Name,
                Population = city.Population
            }, city.Region);
        }

        public List<CityDto> GetCitiesByRegion(string region)
        {
            var citiesInRegion = _cityRepository.GetCitiesByRegion(region);
            if (citiesInRegion == null || !citiesInRegion.Any())
                return null;

            return citiesInRegion.Select(el=>this._mapper.Map<CityDto>(el)).ToList();
        }

        public CityDto GetRandomCity()
        {
            var cities = _cityRepository.GetAllCities();
            var random = new Random();
            var randomIndex = random.Next(0, cities.Count);
            var randomCity = cities[randomIndex];

            return this._mapper.Map<CityDto>(randomCity);
        }
    }

}
