namespace CityApi.Models
{
    public class RegionDto
    {
        public string Country { get; set; }
        public List<CityDto> Cities { get; set; }
    }
}
