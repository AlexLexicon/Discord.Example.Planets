using Discord.Example.Planets.Models;

namespace Discord.Example.Planets.ViewModels.ViewModels;
public class PlanetViewModel
{
    public PlanetViewModel(Planet planet)
    {
        Planet = planet;
    }

    public Planet Planet { get; }
}
