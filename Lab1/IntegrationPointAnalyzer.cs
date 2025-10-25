namespace Lab1;

public enum RectanglePoint { Left, Right, Middle }

public class IntegrationPointAnalyzer
{
    
    private double Function(double x) => 0.5 * x;

    
    private const double ExactValue = 1.0; 

    
    private double RectangleMethod(double a, double b, int n, RectanglePoint point)
    {
        if (a >= b)
            throw new ArgumentException("Dolna granica musi być mniejsza od górnej.");
        if (n <= 0)
            throw new ArgumentException("Liczba prostokątów musi być większa od zera.");

        double h = (b - a) / n;
        double sum = 0.0;

        for (int i = 0; i < n; i++)
        {
            double x;
            switch (point)
            {
                case RectanglePoint.Left:
                    x = a + i * h; 
                    break;
                case RectanglePoint.Right:
                    x = a + (i + 1) * h; 
                    break;
                case RectanglePoint.Middle:
                    x = a + (i + 0.5) * h; 
                    break;
                default:
                    throw new ArgumentException("Nieznany typ punktu.");
            }
            sum += Function(x) * h;
        }

        return sum;
    }

    
    public List<(int n, RectanglePoint point, double result, double error)> AnalyzePointAccuracy(
        double a, double b, int[] nValues, RectanglePoint[] points)
    {
        List<(int n, RectanglePoint point, double result, double error)> results = 
            new List<(int, RectanglePoint, double, double)>();

        foreach (int n in nValues)
        {
            foreach (RectanglePoint point in points)
            {
                try
                {
                    double integralValue = RectangleMethod(a, b, n, point);
                    double absoluteError = Math.Abs(integralValue - ExactValue);
                    results.Add((n, point, integralValue, absoluteError));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Błąd dla n={n}, punkt={point}: {ex.Message}");
                }
            }
        }

        return results;
    }
}