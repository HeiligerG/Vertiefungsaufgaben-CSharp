using System;

public class Cuboid
{
    public double Length { get; }
    public double Width { get; }
    public double Height { get; }

    public Cuboid(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double GetVolume()
    {
        return Length * Width * Height;
    }

    public double GetSurfaceArea()
    {
        return 2 * (Length * Width + Length * Height + Width * Height);
    }

    public double GetBaseArea()
    {
        return Length * Width;
    }

    public double GetDiagonal()
    {
        return Math.Sqrt(Length * Length + Width * Width + Height * Height);
    }
}