namespace Lab1;

public enum ApproximationMethod { Rectangle, Trapezoid }

public class IntegrationMethodAnalyzer
{
    private double Function(double x) => 0.5 * x;
    
    private const double ExactValue = 1.0;
    
    private double CalculateIntegral(double a, double b, int n, ApproximationMethod method)
    {
        if (a >= b)
            throw new ArgumentException("Dolna granica musi być mniejsza od górnej.");
        if (n <= 0)
            throw new ArgumentException("Liczba podziałów musi być większa od zera.");

        double h = (b - a) / n;
        double sum = 0.0;

        for (int i = 0; i < n; i++)
        {
            double x0 = a + i * h;
            double x1 = a + (i + 1) * h;

            if (method == ApproximationMethod.Rectangle)
            {
                sum += Function(x0) * h;
            }
            else if (method == ApproximationMethod.Trapezoid)
            {
                sum += (Function(x0) + Function(x1)) * h / 2;
            }
        }

        return sum;
    }
    
    public List<(int n, ApproximationMethod method, double result, double error)> AnalyzeMethodAccuracy(
        double a, double b, int[] nValues)
    {
        List<(int n, ApproximationMethod method, double result, double error)> results =
            new List<(int, ApproximationMethod, double, double)>();

        foreach (int n in nValues)
        {
            foreach (var method in Enum.GetValues(typeof(ApproximationMethod)))
            {
                try
                {
                    double integralValue = CalculateIntegral(a, b, n, (ApproximationMethod)method);
                    double absoluteError = Math.Abs(integralValue - ExactValue);
                    results.Add((n, (ApproximationMethod)method, integralValue, absoluteError));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Błąd dla n={n}, metoda={(ApproximationMethod)method}: {ex.Message}");
                }
            }
        }

        return results;
    }
}