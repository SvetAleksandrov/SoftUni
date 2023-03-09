using System.Collections.Generic;
using System.Diagnostics;

namespace _04._Studentss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] commnad = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = commnad[0];
                string lastName = commnad[1];
                double grade = double.Parse(commnad[2]);

                Student newStudent = new Student(firstName, lastName, grade);
                students.Add(newStudent);

            }

            foreach (Student student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}

class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public double Grade { get; set; }

    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

}