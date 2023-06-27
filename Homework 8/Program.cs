using hm8;
using System;
using System.Linq;
using System.Reflection.Metadata;

class Program
{
    private static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        var numberOfShapes = 10;

        for (int i = 0; i < numberOfShapes; i++)
        {
            Shape shape = CreateShape();

            if (shape == null)
            {
                return;
            }

            Console.Write($"Enter name of shape {i + 1}:\t");
            
            shape.Name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(shape.Name))
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }
            else if (!shape.Name.All(char.IsLetter))
            {
                Console.WriteLine("Name can only contain letters!");
                return;
            }
            else if (shapes.Any(s => s.Name == shape.Name))
            {
                Console.WriteLine("This name of shape is already defined. Please write only unique name for each shape!");
                return;
            }

            shapes.Add(shape);
        }
 
        Console.WriteLine("\nShapes information:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Name: {shape.Name}");
            Console.WriteLine($"Area: {shape.Area()}");
            Console.WriteLine($"Perimeter: {shape.Perimeter()}");

            if (shape is Cube cube)
            {
                Console.WriteLine($"Volume: {cube.Volume()}");
            }

            Console.WriteLine();
        }

        Shape LargestPerimeter = FindLargestPerimeter(shapes);
        Console.WriteLine($"Shape with the largest perimeter: {LargestPerimeter.Name}");

        PrintSortedShapesByArea(shapes);
    }

    static Shape CreateShape()
    {
        Console.WriteLine("Choose a shape:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Square");
        Console.WriteLine("3. Rectangle");
        Console.WriteLine("4. Cube");
        Console.WriteLine("5. Triangle");
        Console.Write("Enter the shape number: ");

        string inputChoice = Console.ReadLine();

        if (!int.TryParse(inputChoice, out int choice))
        {
            Console.WriteLine("Invalid data!(");
            return null;
        }
       
        switch (choice)
        {
            case 1:
                Console.Write("Enter radius: ");
                
                string inputRadius = Console.ReadLine();

                if (!double.TryParse(inputRadius, out double radius))
                {
                    Console.WriteLine("Invalid data!(");
                    return null;
                }

                return new Circle("Circle", radius);

            case 2:
                Console.Write("Enter side length: ");

                string inputSquareSide = Console.ReadLine();

                if (!double.TryParse(inputSquareSide, out double squareSide))
                {
                    Console.WriteLine("Invalid data!(");
                    return null;
                }

                return new Square("Square", squareSide);

             case 3:
                Console.Write("Enter length: ");

                string inputLength = Console.ReadLine();

                if (!double.TryParse(inputLength, out double length))
                {
                    Console.WriteLine("Invalid data!(");
                    return null;
                }

                Console.Write("Enter width: ");

                string inputWidth = Console.ReadLine();

                if (!double.TryParse(inputWidth, out double width))
                {
                    Console.WriteLine("Invalid data!(");
                    return null;
                }

                return new Rectangle("Rectangle", length, width);

            case 4:
                Console.Write("Enter side length: ");

                string inputCubeSide = Console.ReadLine();

                if (!double.TryParse(inputCubeSide, out double cubeSide))
                {
                    Console.WriteLine("Invalid data!(");
                    return null;
                }

                return new Cube("Cube", cubeSide);

            case 5:
                Console.WriteLine("Enter side 'A' length: ");

                string inputSideA = Console.ReadLine();

                if (!double.TryParse(inputSideA, out double sideA))
                {
                    Console.WriteLine("Invalid data!(");
                    return null;
                }

                Console.WriteLine("Enter side 'B' length: ");

                string inputSideB = Console.ReadLine();

                if (!double.TryParse(inputSideB, out double sideB))
                {
                    Console.WriteLine("Invalid data!(");
                    return null;
                }

                Console.WriteLine("Enter side 'C' length: ");

                string inputSideC = Console.ReadLine();

                if (!double.TryParse(inputSideC, out double sideC))
                {
                    Console.WriteLine("Invalid data!(");
                    return null;
                }

                return new Triangle("Triangle", sideA, sideB, sideC);

            default:
                throw new ArgumentException("Invalid shape choice.");
        }
    }

    static void PrintSortedShapesByArea(List<Shape> shapes)
    {
        shapes.Sort();

        Console.WriteLine("\nShapes sorted by area:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Name: {shape.Name}");
            Console.WriteLine($"Area: {shape.Area()}");
            Console.WriteLine($"Perimeter: {shape.Perimeter()}");

            if (shape is Cube cube)
            {
                Console.WriteLine($"Volume: {cube.Volume()}");
            }

            Console.WriteLine();
        }
    }

    static Shape FindLargestPerimeter(List<Shape> shapes)
    {
        Shape shapeWithLargestPerimeter = null;
        double largestPerimeter = 0;

        foreach (Shape shape in shapes)
        {
            if (shape.Perimeter() > largestPerimeter)
            {
                largestPerimeter = shape.Perimeter();
                shapeWithLargestPerimeter = shape;
            }
        }

        return shapeWithLargestPerimeter;
    }
}