namespace Lab1;

public class IntegrationAccuracyAnalyzer
{
    
    private double Function(double x) => 0.5 * x;

    
    private const double ExactValue = 1.0; 

    
    private double RectangleMethod(double a, double b, int n)
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

   
    public List<(int n, double result, double error)> AnalyzeAccuracy(double a, double b, int[] nValues)
    {
        List<(int n, double result, double error)> results = new List<(int, double, double)>();

        foreach (int n in nValues)
        {
            try
            {
                double integralValue = RectangleMethod(a, b, n);
                double absoluteError = Math.Abs(integralValue - ExactValue);
                results.Add((n, integralValue, absoluteError));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd dla n={n}: {ex.Message}");
            }
        }

        return results;
    }
}