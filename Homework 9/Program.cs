using hm9;
using System;
using System.Linq;
using System.Reflection.Metadata;

class Program
{
    private static void Main(string[] args)
    {
        
    }
    
    public static void TaskA()
    {
        List<Shape> shapes = new List<Shape>()
        {
            new Circle("Circle", 1),
            new Square("Square", 1),
            new Cube("Cube", 1),
            new Rectangle("Rectangle", 12, 21),
            new Triangle("Triangle", 21, 14, 39),
            new Circle("Circle", 5)

        };

        int minRange = 10;
        int maxRange = 100;
        
        string path = "C:\\Users\\Olega\\Desktop\\C# Fundamentals\\file.txt";

        var rangeResult = shapes.Where(range => range.Area() >= minRange && range.Area() <= maxRange).ToList();

        try
        {
            using (StreamWriter sw = new StreamWriter(path,true))
            {
                foreach (var result in rangeResult)
                {                       
                    sw.WriteLine($"Name: {result.Name}, Area: {result.Area()}");
                   
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing to file: " + ex.Message);
        }
        
        var resultContainA = shapes.Where(contain => contain.Name.Contains("a")).ToList();
        
        try
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (var resultA in resultContainA)
                {
                    sw.WriteLine($"Shapes which contain 'a': {resultA.Name}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing to file: " + ex.Message);
        }

        shapes.RemoveAll(shape => shape.Perimeter() < 5);
        
        Console.WriteLine("Shapes with perimeter >= 5:");
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape);
        }

        Console.ReadLine();
    }
    
    public static void TaskB()
    {
        string path = "C:\\Users\\Olega\\Desktop\\C# Fundamentals\\LotOfText.txt";

        string[] userText = File.ReadAllLines(path);

        var countResult = userText.Select((line, index) => 
            $"Line {index + 1}: Symbols in line: {line.Length}");

        foreach (var result in countResult)
        {
            Console.WriteLine(result);
        }

        var shortestLine = userText.OrderBy(line => line.Length).FirstOrDefault();
        Console.WriteLine("Shortest line: " + shortestLine);

        var longestLine = userText.OrderByDescending(line => line.Length).FirstOrDefault();
        Console.WriteLine("Longest line: " + longestLine);

        var linesContainVar = userText.Where(line => line.Contains("var"));

        Console.WriteLine("Lines that contain 'var':");

        foreach (var lineResult in linesContainVar)
        {
            Console.WriteLine(lineResult);
        }
    }
}