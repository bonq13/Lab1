namespace Lab1;

public class IntegralCalculator
{
    private double Function(double x) => Math.Sin(x);
    
    public double RectangleMethod(double a, double b, int n)
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
            sum += Function(x) * h;
        }

        return sum;
    }
}