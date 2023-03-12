namespace _6._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsTrack = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsTrack.ContainsKey(studentName))
                {
                    studentsTrack[studentName] = new List<double>();
                }
                studentsTrack[studentName].Add(grade);
            }

            //"{name} –> {averageGrade}"
            foreach (var item in studentsTrack)
            {
                string name = item.Key;
                double averageGrade = item.Value.Average();
                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{name} -> {averageGrade:F2}");
                }
            }
        }
    }
}
