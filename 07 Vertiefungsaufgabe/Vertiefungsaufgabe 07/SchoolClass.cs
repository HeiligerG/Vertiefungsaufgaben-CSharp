namespace Vertiefungsaufgabe_07;

public class SchoolClass 
{
    private readonly Teacher teacher;
    private List<Student> students;

    public SchoolClass(Teacher teacher)
    {
        this.teacher = teacher;
        this.students = new List<Student>();
    }

    public void AddStudents(Student student)
    {
        students.Add(student);
    }

    public virtual void ClassInfo()
    {
        Console.WriteLine($"This class teachers name is {teacher.Name} and has {students.Count} students");
    }
}
