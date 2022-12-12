using Discord.Example.Planets.Models.Extensions;

namespace Discord.Example.Planets.Models;
public class Planet
{
    public Planet(Game game)
    {
        Game = game;

        Diameter = Random.Shared.Next(50, 100);

        X = Random.Shared.NextDouble(0 + Diameter / 2, Game.Width - Diameter / 2);
        Y = Random.Shared.NextDouble(0 + Diameter / 2, Game.Height - Diameter / 2);

        Color = Random.Shared.Next(0, 4) switch
        {
            0 => Models.Color.Red,
            1 => Models.Color.Green,
            2 => Models.Color.Blue,
            _ => Models.Color.Yellow,
        };
    }

    private List<Planet>? _neighbours;
    public List<Planet> Neighbours => _neighbours ??= new List<Planet>();

    public Game Game { get; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Left => X - Diameter / 2;
    public double Top => Y - Diameter / 2;
    public int Diameter { get; set; }
    public Color? Color { get; set; }
}
