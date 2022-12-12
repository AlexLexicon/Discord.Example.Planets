using Discord.Example.Planets.Models;

namespace Discord.Example.Planets.ViewModels.ViewModels;
public class ConnectionViewModel
{
    public ConnectionViewModel(Planet source, Planet target)
    {
        Source = source;
        Target = target;
    }

    public Planet Source { get; }
    public Planet Target { get; }
}
