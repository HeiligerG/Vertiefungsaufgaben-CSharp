using System.Diagnostics;

namespace Vertiefungsaufgabe_07;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        Student personKarlotta = new Student("Karlotta", 4, true);
        Student personLudwig = new Student("Ludwig-Bernhard", 5, false);
        Student personHans = new Student("Hans", 6, false);
        Student personSergio = new Student("Sergio", 7, true);
        Student personJan = new Student("Jan", 8, false);
        Student personJeanPierre = new Student("Jean-Pierre", 9, true);
        Student personOxmal = new Student("Oxmal", 10, false);
        Teacher teacherLaempel = new Teacher("Lämpel", 2, 259.95);

        
        Module module1 = new Module(187, teacherLaempel);
        module1.AddStudents(personKarlotta);
        module1.AddStudents(personLudwig);
        module1.AddStudents(personHans);
        module1.AddStudents(personSergio);
        module1.AddStudents(personJan);
        module1.AddStudents(personJeanPierre);
        module1.AddStudents(personOxmal);
        
        module1.ClassInfo();
        
        SchoolClass schoolClass1 = new SchoolClass(teacherLaempel);

        schoolClass1.AddStudents(personKarlotta);
        schoolClass1.AddStudents(personLudwig);

        schoolClass1.ClassInfo();
       
        people.Add(personKarlotta);
        people.Add(personLudwig);
        people.Add(teacherLaempel);
        people.Add(personHans);
        people.Add(personSergio);
        people.Add(personJan);
        people.Add(personJeanPierre);
        people.Add(personOxmal);
        

        Console.WriteLine("Press any key to close the application.");
        Console.ReadLine();
    }
}



/*
        foreach (Person person in people)
        {
            Console.WriteLine(person.GetDetails());
        }
*/

/* SchoolClass schoolClass1 = new SchoolClass(teacherLaempel);

schoolClass1.AddStudents(personKarlotta);
schoolClass1.AddStudents(personLudwig);

schoolClass1.ClassInfo();
*/