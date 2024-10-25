using System;
class Zylinder
{
    private list
    public double Durchmesser { get; }
    public Zylinder(double durchmesser, double hoehe)
    {
        this.Durchmesser = durchmesser;
    }
    
}

public class Program
{
    public static void Main(string[] args)
    {
        Zylinder myZylinder = new Zylinder(10.0, 1.0); 
        myZylinder.Durchmesser = 10; 
        
        Console.WriteLine("Mein Durchmesser: " + myZylinder.Durchmesser);
    }
}
