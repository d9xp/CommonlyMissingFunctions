using System;

namespace CommonlyMissingFunctions;

public struct Rectangle
{
    public float X;
    public float Y;
    public float Length;
    public float Width;
    public float Area()
    {
        return (float)(Length * Width);	
    }
    public float CircleInscribedRadius()
    {
        return (float)(Math.Min(Length,Width) / 2);
    }
    public float CircleInscribedArea()
    {
        return (float)Math.PI * (float)Math.Pow(CircleInscribedRadius(),2);
    }
    public float OuterArea()
    {
        return Area() - CircleInscribedArea();
    }
}
