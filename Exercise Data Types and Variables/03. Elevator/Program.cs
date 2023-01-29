int numberOfPeople = int.Parse(Console.ReadLine());
int capacityElevetor = int.Parse(Console.ReadLine());

int numberOfCourse = (int)Math.Ceiling(numberOfPeople/ (double)capacityElevetor);

Console.WriteLine(numberOfCourse);