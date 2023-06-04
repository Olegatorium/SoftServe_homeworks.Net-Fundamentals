using hm5;

class Program
{
    private static void Main(string[] args)
    {
        
    }

    public static void Task1() 
    {
        List<IDeveloper> developers = new List<IDeveloper>();

        developers.Add(new Programmer(8, "C#", "Rider"));
        developers.Add(new Programmer(3, "Java", "Laptop")); 
        developers.Add(new Programmer(6, "C++", "Computer"));
        developers.Add(new Programmer(2, "Pyton", "Visual Studio"));

        developers.Add(new Builder(5, "hammer", "scrap"));
        developers.Add(new Builder(1, "screwdriver", "Crane"));
        developers.Add(new Builder(4, "scissors", "hammer"));
        developers.Add(new Builder(7, "Crane", "bomb"));

        developers.Sort();

        foreach (IDeveloper developer in developers)
        {
            developer.Create();
            developer.Destroy();
            Console.WriteLine();
        }

        Console.ReadKey();
    }

    public static void Task2() 
    {
        Dictionary<uint, string> person = new Dictionary<uint, string>();

        byte amountOfPerson = 7;

        for (int i = 0; i < amountOfPerson; i++)
        {
            Console.Write($"Enter ID of Person {i + 1} :\t");
            string inputPersonId = Console.ReadLine();

            if (!uint.TryParse(inputPersonId, out uint personId))
            {
                Console.WriteLine("Please enter only number in ID field");
                return;
            }
            else if (person.ContainsKey(personId))
            {
                Console.WriteLine("This ID is already defined. Please write only unique ID for each person!");
                return;
            }

            Console.Write($"Enter Name of Person {i + 1} :\t");
            string personName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(personName))
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }
            else if (!personName.All(char.IsLetter))
            {
                Console.WriteLine("Name can only contain letters!");
                return;
            }

            person.Add(personId, personName);

            Console.WriteLine();
        }

        Console.Write("Enter ID for finding a person:\t");

        string inputFindPerson = Console.ReadLine();

        if (!uint.TryParse(inputFindPerson, out uint findPerson) || !(person.ContainsKey(findPerson)))
        {
            Console.WriteLine("Sorry, we don`t have person with this ID");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nName of this person is " + person[findPerson]);           
        }
    }
}