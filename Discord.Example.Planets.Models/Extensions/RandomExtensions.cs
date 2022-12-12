namespace Discord.Example.Planets.Models.Extensions;
public static class RandomExtensions
{
    public static double NextDouble(this Random rng, double minimum, double maximum)
    {
        return rng.NextDouble() * (maximum - minimum) + minimum;
    }
}
