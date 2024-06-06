using System;

public class Country
{
    public string Name { get; set; }
    public int Population { get; set; }
    public double Area { get; set; }

    public Country(string name, int population, double area)
    {
        Name = name;
        Population = population;
        Area = area;
        Console.WriteLine("Country constructor with parameters");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Country: {Name}");
        Console.WriteLine($"Population: {Population}");
        Console.WriteLine($"Area: {Area}");
    }
}

public class Republic : Country
{
    public string President { get; set; }

    public Republic(string name, int population, double area, string president)
        : base(name, population, area)
    {
        President = president;
        Console.WriteLine("Republic constructor with parameters");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"President: {President}");
    }
}

public class Monarchy : Country
{
    public string Monarch { get; set; }

    public Monarchy(string name, int population, double area, string monarch)
        : base(name, population, area)
    {
        Monarch = monarch;
        Console.WriteLine("Monarchy constructor with parameters");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Monarch: {Monarch}");
    }
}

public class Kingdom : Monarchy
{
    public int NobilityCount { get; set; }

    public Kingdom(string name, int population, double area, string monarch, int nobilityCount)
        : base(name, population, area, monarch)
    {
        NobilityCount = nobilityCount;
        Console.WriteLine("Kingdom constructor with parameters");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Nobility Count: {NobilityCount}");
    }
}

public class State : Country
{
    public string GovernmentType { get; set; }
    public string Leader { get; set; }

    public State(string name, int population, double area, string governmentType, string leader)
        : base(name, population, area)
    {
        GovernmentType = governmentType;
        Leader = leader;
        Console.WriteLine("State constructor with parameters");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Government Type: {GovernmentType}");
        Console.WriteLine($"Leader: {Leader}");
    }
}
