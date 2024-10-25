namespace Vertiefungsaufgabe_07;

public class Student : Person
{
    public bool IsBmsStudent { get; }

    public Student(string name, int id, bool isBmsStudent) : base(name, id)
    {
        IsBmsStudent = isBmsStudent;
    }

    public override string GetDetails()
    {
        return $"The Student name is {Name} with person id {Id} and they are BMS Student: {IsBmsStudent} ";
    }
}