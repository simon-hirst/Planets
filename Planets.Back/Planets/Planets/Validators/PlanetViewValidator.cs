using FluentValidation;
using Planets.Data.Models.Views;

namespace Planets.Validators
{
    public class PlanetViewValidator : AbstractValidator<PlanetView>
    {
        public PlanetViewValidator()
        {
            RuleFor(x => x.DistanceFromSun).NotEmpty().WithMessage("Please enter a value for distance from sun.");
            RuleFor(x => x.Mass).NotEmpty().WithMessage("Please enter a value for mass.");
            RuleFor(x => x.Diameter).NotEmpty().WithMessage("Please enter a value for diameter.");
        }
    }
}