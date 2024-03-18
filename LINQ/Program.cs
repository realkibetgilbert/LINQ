using LINQ.Model;

class Program
{
    static void Main(string[] args)
    {
        //Initialize list of students
        List<Student> students = new List<Student>
        {
            new Student(1, "Alice", 90),
            new Student(2, "Bob", 85),
            new Student(3, "Charlie", 95),
            new Student(4, "David", 88),
            new Student(5, "Eve", 92)
        };

        // Use LINQ to find students with a grade higher than 90
        var highGrades = students.Where(s => s.Grade > 90);

        Console.WriteLine("Students with a grade higher than 90:");
        foreach (var student in highGrades)
        {
            Console.WriteLine(student);
        }

        // Use LINQ to order students by grade in descending order
        var orderedStudents = students.OrderByDescending(s => s.Grade);
        Console.WriteLine("\nStudents ordered by grade in descending order:");
        foreach (var student in orderedStudents)
        {
            Console.WriteLine(student);
        }
        // Use LINQ to find the average grade
        var averageGrade = students.Average(s => s.Grade);
        Console.WriteLine($"\nAverage grade: {averageGrade}");

        // Use LINQ to find the student with the highest grade
        var highestGradeStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
        Console.WriteLine($"Student with the highest grade: {highestGradeStudent}");

        Console.ReadLine(); // Wait for user input before closing the console
    }
}