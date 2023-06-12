
namespace hm6;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, please write two numbers that you want to use for your range:)");

        Console.Write("First number:\t");
        string inputFirstNumber = Console.ReadLine();

        if (!int.TryParse(inputFirstNumber, out int firstNumber))
        {
            Console.WriteLine("You can write only numbers!");
            return;
        }

        Console.Write("Second number:\t");
        string inputSecondNumber = Console.ReadLine();

        if (!int.TryParse(inputSecondNumber, out int secondNumber))
        {
            Console.WriteLine("You can write only numbers!");
            return;
        }

        if (firstNumber >= secondNumber)
        {
            Console.WriteLine("The first number cannot be greater than or equal to the second number!");
            return;
        }
        else if (firstNumber > secondNumber - 9)
        {
            Console.WriteLine("The first number must be at least 9 less than the second number!");
            return;
        }

        byte amountOfInputNumbers = 10; 

        int[] numbers = new int[amountOfInputNumbers];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                numbers[i] = ReadNumber(firstNumber, secondNumber);
            }
            else
            {
                int nextStart = numbers[i - 1] + 1;

                if (nextStart > secondNumber)
                {
                    Console.WriteLine("You have reached the upper limit!");
                    return;
                }

                numbers[i] = ReadNumber(nextStart, secondNumber);
            }
        }

        Console.WriteLine("Entered numbers:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }

    static int ReadNumber(int start, int end)
    {
    a1:
        try
        {
            Console.WriteLine($"Enter an integer number between {start} and {end}:");

            int number = int.Parse(Console.ReadLine());

            if (number >= start && number <= end)
            {
                return number;
            }

            throw new ArgumentException("Number out of range.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            goto a1;

        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input");
            goto a1;

        }
        finally 
        {
            Console.WriteLine("Congratulation!");
        }
    }
}


