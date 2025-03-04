namespace SRS1.Modules;

public class Division
{
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero.");
        }
        return a / b;
    }
}