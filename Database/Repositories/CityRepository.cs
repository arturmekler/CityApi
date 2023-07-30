using Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories
{
    public class CityRepository : ICityRepository
    {
        private List<Region> _regions;

        public CityRepository()
        {

            _regions = new List<Region>
            {
                new Region
                {
                    Country = "Poland",
                    Cities = new List<City>
                    {
                        new City { Id = 1, Name = "Warsaw", Population = 1790658, Country = "Poland" },
                        new City { Id = 4, Name = "Krakow", Population = 779115, Country = "Poland" },
                    }
                },
                new Region
                {
                    Country = "Germany",
                    Cities = new List<City>
                    {
                        new City { Id = 2, Name = "Berlin", Population = 3769495, Country = "Germany" },
                        new City { Id = 5, Name = "Munich", Population = 1471508, Country = "Germany" },
                    }
                },
            };
        }

        public IList<City> GetAllCities()
        {
            return _regions.SelectMany(el=>el.Cities).ToList();
        }

        public City GetCityById(int id)
        {
            return _regions.SelectMany(el => el.Cities).FirstOrDefault(c => c.Id == id);
        }

        public List<City> GetCitiesByRegion(string region)
        {
            return _regions.SelectMany(el => el.Cities).Where(c => c.Country == region).ToList();
        }

        public void AddCity(City city, string region)
        {
            _regions.FirstOrDefault(el => el.Country == region).Cities.Add(city);
        }
    }
}
