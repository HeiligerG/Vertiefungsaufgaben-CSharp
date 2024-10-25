using System;

class Zylinder
{
    private double durchmesser;
    private double hoehe;

    public Zylinder()
    {
        this.durchmesser = 0.0;
        this.hoehe = 0.0;
    }
    public Zylinder(double durchmesser, double hoehe)
    {
        this.durchmesser = durchmesser;
        this.hoehe = hoehe;
    }

    public void setDurchmesser(double durchmesser)
    {
        this.durchmesser = durchmesser;
    }

    public void setHoehe(double hoehe)
    {
        this.hoehe = hoehe;
    }

    public double getGrundflaeche()
    {
        double radius = durchmesser / 2.0;
        return Math.PI * radius * radius;
    }

    public double getMantelflaeche()
    {
        double radius = durchmesser / 2.0;
        return 2 * Math.PI * radius * hoehe;
    }

    public double getVolumen()
    {
        return getGrundflaeche() * hoehe;
    }

    public double getOberflaeche()
    {
        return 2 * getGrundflaeche() + getMantelflaeche();
    }
    
    public static double getOberflaeche(double durchmesser, double hoehe)
    {
        double radius = durchmesser / 2.0;
        double grundflaeche = Math.PI * radius * radius;
        double mantelflaeche = 2 * Math.PI * radius * hoehe;
        return 2 * grundflaeche + mantelflaeche;
    }
    
    public Cuboid CreateFittingCuboid()
    {
        double side = durchmesser / Math.Sqrt(2);
        return new Cuboid(side, side, hoehe);
    }

    public double GetHeightForFittingCuboid()
    {
        return hoehe;
    }

    public double GetSideForFittingCuboid()
    {
        return durchmesser / Math.Sqrt(2);
    }

    public bool DoesCuboidFit(Cuboid cuboid)
    {
        double diagonal = Math.Sqrt(cuboid.Length * cuboid.Length + cuboid.Width * cuboid.Width);
        return diagonal <= durchmesser && cuboid.Height <= hoehe;
    }
}

class A1
{
    static void Main()
    {
        Zylinder z1 = new Zylinder();
        z1.setDurchmesser(10.5);
        z1.setHoehe(20.5);
        double v1 = z1.getVolumen();
        double a1 = z1.getGrundflaeche();
        double m1 = z1.getMantelflaeche();
        double o1 = z1.getOberflaeche();
        Console.WriteLine("Zylinder 01: Volumen=" + v1.ToString() + " Oberflaeche=" + o1.ToString());

        //---------------------------------------------

        Zylinder z2 = new Zylinder(30.0, 15.5);   // Param1 = Durchmesser, Param2 = Höhe
        double v2 = z2.getVolumen();
        double o2 = z2.getOberflaeche();
        Console.WriteLine("Zylinder 02: Volumen=" + v2.ToString() + " Oberflaeche=" + o2.ToString());

        //---------------------------------------------

        double o3 = Zylinder.getOberflaeche(50.5, 20.0);   // Param1 = Durchmesser, Param2 = Höhe
        Console.WriteLine("Zylinder 03: Oberflaeche=" + o3.ToString());

        //---------------------------------------------
        
        Zylinder z3 = new Zylinder(40.0, 30.0);
        Cuboid c1 = z3.CreateFittingCuboid();
        Console.WriteLine($"Fitting Cuboid: Length={c1.Length}, Width={c1.Width}, Height={c1.Height}");

        double height = z3.GetHeightForFittingCuboid();
        double side = z3.GetSideForFittingCuboid();
        Console.WriteLine($"Dimensions for fitting cuboid: Height={height}, Side={side}");

        Cuboid c2 = new Cuboid(25, 25, 25);
        bool fits = z3.DoesCuboidFit(c2);
        Console.WriteLine($"Does cuboid fit? {fits}");

        if (!fits)
        {
            Cuboid fittingCuboid = z3.CreateFittingCuboid();
            Console.WriteLine($"New fitting cuboid: Length={fittingCuboid.Length}, Width={fittingCuboid.Width}, Height={fittingCuboid.Height}");
        }

        //---------------------------------------------
        
        Console.ReadLine();
    }
}
