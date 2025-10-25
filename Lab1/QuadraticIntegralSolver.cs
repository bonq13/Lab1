namespace Lab1;

public class QuadraticIntegralSolver
{
    private double Function(double x, double a, double b, double c) => a * x * x + b * x + c;

    public double RectangleMethod(double aCoeff, double bCoeff, double cCoeff, double a, double b, int n)
    {
        if (a >= b)
            throw new ArgumentException("Dolna granica musi być mniejsza od górnej.");
        if (n <= 0)
            throw new ArgumentException("Liczba prostokątów musi być większa od zera.");

        double h = (b - a) / n;
        double sum = 0.0;

        
        for (int i = 0; i < n; i++)
        {
            double x = a + i * h;
            sum += Function(x, aCoeff, bCoeff, cCoeff) * h;
        }

        return sum;
    }

   
    public double ExactIntegral(double aCoeff, double bCoeff, double cCoeff, double a, double b)
    {
        
        return (aCoeff / 3.0 * (Math.Pow(b, 3) - Math.Pow(a, 3))) +
               (bCoeff / 2.0 * (Math.Pow(b, 2) - Math.Pow(a, 2))) +
               cCoeff * (b - a);
    }
}