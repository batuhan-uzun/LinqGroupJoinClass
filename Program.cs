// Create the Classes table
using LinqGroupJoinClass.Models;

var classes = new List<Class>
            {
                new Class { ClassId = 1, ClassName = "Matematik" },
                new Class { ClassId = 2, ClassName = "Türkçe" },
                new Class { ClassId = 3, ClassName = "Kimya" }
            };

// Create the Students table
var students = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
                new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
                new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
                new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
                new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 2 }
            };

// LINQ Group Join query
var groupJoinQuery = from cls in classes
                     join stu in students
                     on cls.ClassId equals stu.ClassId into studentGroup
                     select new
                     {
                         ClassName = cls.ClassName,
                         Students = studentGroup
                     };

// Print the results
Console.WriteLine("Classes and their Students:");
foreach (var group in groupJoinQuery)
{
    Console.WriteLine($"Class: {group.ClassName}");
    foreach (var student in group.Students)
    {
        Console.WriteLine($"  Student: {student.StudentName}");
    }
}

Console.ReadLine(); // Keep the console window open