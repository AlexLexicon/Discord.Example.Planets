namespace Discord.Example.Planets.Models;
public struct Color
{
    public static readonly Color Red = new Color(255, 0, 0);
    public static readonly Color Green = new Color(0, 255, 0);
    public static readonly Color Blue = new Color(0, 0, 255);
    public static readonly Color Yellow = new Color(255, 255, 0);

    public Color(int r, int g, int b) : this(r, g, b, 255)
    {
    }
    public Color(int r, int g, int b, int a)
    {
        R = r;
        G = g;
        B = b;
        A = a;
    }

    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }
    public int A { get; set; }
}
