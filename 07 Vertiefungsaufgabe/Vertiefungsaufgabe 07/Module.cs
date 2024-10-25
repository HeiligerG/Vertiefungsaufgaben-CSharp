namespace Vertiefungsaufgabe_07;

public class Module : SchoolClass
{
    private readonly Teacher teacher;
    private List<Student> students;
    public int ModuleNumber { get; }
    
    public Module(int moduleNumber, Teacher teacher) : base(teacher)
    {
        ModuleNumber = moduleNumber;
        this.teacher = teacher;
        this.students = new List<Student>();
    }

    public override void ClassInfo()
    {
        Console.WriteLine($"This class teacher name is {teacher.Name} and has {students.Count} students. This Module has the number {ModuleNumber} and is about Cooking.");
    }
}
