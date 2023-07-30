using Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories
{
    public interface ICityRepository
    {
        City GetCityById(int id);
        List<City> GetCitiesByRegion(string region);
        void AddCity(City city, string region);
        IList<City> GetAllCities();
    }
}
