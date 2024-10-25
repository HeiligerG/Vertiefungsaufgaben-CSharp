namespace Vertiefungsaufgabe_07;

public class Teacher : Person
{
    public double HourlySalary { get; }

    public Teacher(string name, int id, double hourlySalary) : base(name, id)
    {
        HourlySalary = hourlySalary;
    }
    
    public override string GetDetails()
    {
        return $"The Student name is {Name} with person id {Id} and their Hourly Salary is: {HourlySalary} ";
    }

}