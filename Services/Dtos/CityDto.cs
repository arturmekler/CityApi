using FluentValidation;

namespace CityApi.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
    }

    public class CityDtoValidator : AbstractValidator<CityDto>
    {
        public CityDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Population).NotEmpty();
            RuleFor(x => x.Country).NotEmpty();
        }

    }
}
