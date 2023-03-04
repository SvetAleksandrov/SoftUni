namespace _05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            List<Student> students = new List<Student>();


            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArguments = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = commandArguments[0];
                string lastName = commandArguments[1];
                int age = int.Parse(commandArguments[2]);
                string town = commandArguments[3];

                bool ifStudentExist = false;

                foreach (var student in students)
                {
                    if (student.FirstName == firstName && student.LastName == lastName)
                    {
                        student.Age = age;
                        student.Town = town;
                        ifStudentExist = true;
                        break;
                    }
                }

                if (!ifStudentExist)
                {
                    Student newStudent = new Student();

                    newStudent.FirstName = firstName;
                    newStudent.LastName = lastName;
                    newStudent.Age = age;
                    newStudent.Town = town;

                    students.Add(newStudent);
                }


            }

            string filterCity = Console.ReadLine();

            List<Student> filterStudents = students
                .Where(x => x.Town == filterCity)
                .ToList();

            foreach (Student student in filterStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Town { get; set; }

}