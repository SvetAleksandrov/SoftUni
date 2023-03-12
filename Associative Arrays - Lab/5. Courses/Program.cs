namespace _5._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commnad;

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            int count = 0;

            while ((commnad = Console.ReadLine()) != "end")
            {
                string[] cmdArg = commnad
                    .Split(" : ");

                string courseType = cmdArg[0];
                string student = cmdArg[1];

                

                if (!courses.ContainsKey(courseType))
                {
                    courses.Add(courseType, new List<string>());
                }
                courses[courseType].Add(student);

            }
            foreach (var item in courses)
            {
                string courseType = item.Key;
                List<string> student = item.Value;
                int countTotal = courses.Count;

                Console.WriteLine($"{courseType}: {student.Count}");
                foreach (string studentName in student)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}