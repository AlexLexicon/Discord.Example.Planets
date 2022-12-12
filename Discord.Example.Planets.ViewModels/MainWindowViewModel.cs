using Discord.Example.Planets.Models;

namespace Discord.Example.Planets.ViewModels.ViewModels;
public class MainWindowViewModel
{
    public MainWindowViewModel()
    {
        Game = new Game();
        EntityViewModels = new List<object>();

        var planetViewModels = new List<PlanetViewModel>();
        var connectionViewModels = new List<ConnectionViewModel>();

        foreach (var planet in Game.Planets)
        {
            var planetViewModel = new PlanetViewModel(planet);

            foreach (var neighbour in planet.Neighbours)
            {
                var connectionViewModel = new ConnectionViewModel(planet, neighbour);

                connectionViewModels.Add(connectionViewModel);
            }

            planetViewModels.Add(planetViewModel);
        }

        //i want all the connections to be under the planets when rendered
        //so we add them first so their z index is less than all the planets.
        EntityViewModels.AddRange(connectionViewModels);
        EntityViewModels.AddRange(planetViewModels);
    }

    public Game Game { get; }

    public List<object> EntityViewModels { get; }
}
