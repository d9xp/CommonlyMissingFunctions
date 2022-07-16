using System;
using Microsoft.Xna.Framework.Graphics;

namespace CommonlyMissingFunctions;

public static class Texture2DExtensions
{
    public static Rectangle Rectangle(this Texture2D texture)
    {
        return new Rectangle(){X = 0, Y = 0, Length = (float)texture.Height, Width = (float)texture.Width};
    }
    public static float Area(this Texture2D texture)
    {
        return (float)texture.Width * (float)texture.Height;
    }
    public static float CircleInscribedRadius(this Texture2D texture)
    {
        return (float)(Math.Min(texture.Height,texture.Width) / 2.0f);
    }
    public static float CircleInscribedArea(this Texture2D texture)
    {
        return (float)Math.PI * (float)Math.Pow(texture.CircleInscribedRadius(),2.0f);
    }
    
    public static float OuterArea(this Texture2D texture)
    {
        return texture.Area() - texture.CircleInscribedArea();
    }
}
