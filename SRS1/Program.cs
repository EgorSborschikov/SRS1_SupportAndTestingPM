using SRS1.Modules;

namespace SRS1;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        if (!double.TryParse(Console.ReadLine(), out double number1))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.WriteLine("Enter the second number:");
        if (!double.TryParse(Console.ReadLine(), out double number2))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.WriteLine("Choose an operation: +, -, *, /");
        string operation = Console.ReadLine();

        try
        {
            double result = Calculate(number1, number2, operation);
            Equality.DisplayResult(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static double Calculate(double number1, double number2, string operation)
    {
        return operation switch
        {
            "+" => new Addition().Add(number1, number2),
            "-" => new Substraction().Subtract(number1, number2),
            "*" => new Multiplication().Multiply(number1, number2),
            "/" => new Division().Divide(number1, number2),
            _ => throw new InvalidOperationException("Invalid operation selected.")
        };
    }

}