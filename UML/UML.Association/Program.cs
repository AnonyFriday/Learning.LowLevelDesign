namespace UML.Association;

/*
    Association
    Hardlinking 1 object - 1 object
*/

internal class Teacher(string name)
{
    public void Teach(Student student)
    {
        Console.WriteLine($"Teacher {name} is teaching Student {student.ToString()}");

    }
}

internal class Student(string name)
{
    public override string ToString()
    {
        return $"{nameof(name)}: {name}";
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Teacher A");
        Student student = new Student("Student B");

        teacher.Teach(student);
    }
}