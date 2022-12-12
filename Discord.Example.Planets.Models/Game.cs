namespace Discord.Example.Planets.Models;
public class Game
{
    public Game()
    {
        Width = 1000;
        Height = 500;

        var planet1 = new Planet(this);
        var planet2 = new Planet(this);
        var planet3 = new Planet(this);
        var planet4 = new Planet(this);

        planet1.Neighbours.Add(planet2);
        planet2.Neighbours.Add(planet3);
        planet3.Neighbours.Add(planet1);
        planet3.Neighbours.Add(planet4);

        Planets = new List<Planet>
        {
            planet1,
            planet2,
            planet3,
            planet4
        };
    }

    public List<Planet> Planets { get; }

    public double Width { get; }
    public double Height { get; }
}
