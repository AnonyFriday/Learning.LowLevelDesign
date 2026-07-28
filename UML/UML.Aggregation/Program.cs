/*
    Aggregation
    - Weak relationship
    - If the container object destroyed, the child class will not be destroyed
*/

internal record Professor(string Name);
internal record Department(string Name, ICollection<Professor> Professors)
{
    public void ListOfProfessors()
    {
        foreach (var pro in Professors)
        {
            Console.WriteLine(pro.Name);
        }
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        // 1. Professors exist independently first
        var prof1 = new Professor("John Doe");
        var prof2 = new Professor("Jane Smith");

        // 2. Aggregated into the Department
        Department department = new Department("Computer Science", new[] { prof1, prof2 });

        department.ListOfProfessors();

        // Even if 'department' goes out of scope, prof1 and prof2 still exist!
    }
}