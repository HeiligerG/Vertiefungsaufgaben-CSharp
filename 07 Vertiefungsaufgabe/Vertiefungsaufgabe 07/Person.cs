namespace Vertiefungsaufgabe_07;

public class Person
{
    public string Name { get; } 
    public int Id { get; }

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public virtual string GetDetails()
    {
        
        return "";
    }
}