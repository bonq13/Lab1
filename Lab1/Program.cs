namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        //-----zadadnie 1----
        // FibonacciCalculator calc = new FibonacciCalculator();
        // calc.Calculate();
        
        
        //-----zadadnie 2----
        // FibonacciCalculator2 calc2 = new FibonacciCalculator2();
        // calc2.CalculateFibonacci();
        
        
        //-----zadadnie 3----
        // NumericalIntegration integrator = new NumericalIntegration();
        //
        // double a = 0; 
        // double b = 2;
        // int n = 1000; 
        //
        // try
        // {
        //     double result = integrator.RectangleMethod(a, b, n);
        //     Console.WriteLine($"Wartość całki funkcji y=1/2*x na przedziale [{a}, {b}] " +
        //                       $"metodą prostokątów (n={n}): {result:F6}");
        //     
        //     
        //     Console.WriteLine($"Wartość dokładna: 1.0");
        // }
        // catch (ArgumentException ex)
        // {
        //     Console.WriteLine($"Błąd: {ex.Message}");
        // }
        
        
        
        //-----zadadnie 4----
        // IntegrationAccuracyAnalyzer analyzer = new IntegrationAccuracyAnalyzer();
        //
        // double a = 0; 
        // double b = 2; 
        // int[] nValues = { 10, 50, 100, 500, 1000, 5000, 10000 }; 
        //
        // var results = analyzer.AnalyzeAccuracy(a, b, nValues);
        //
        // Console.WriteLine("Analiza dokładności całkowania numerycznego dla y=1/2*x na [0,2]:");
        // Console.WriteLine("n\t\tWynik całki\t\tBłąd bezwzględny");
        // Console.WriteLine(new string('-', 50));
        //
        // foreach (var result in results)
        // {
        //     Console.WriteLine($"{result.n}\t\t{result.result:F8}\t\t{result.error:F8}");
        // }
        
        
        
        //-----zadadnie 5----
        // IntegrationPointAnalyzer analyzer = new IntegrationPointAnalyzer();
        //
        // double a = 0; 
        // double b = 2; 
        // int[] nValues = { 10, 50, 100, 500, 1000 }; 
        // RectanglePoint[] points = { RectanglePoint.Left, RectanglePoint.Right, RectanglePoint.Middle };
        //
        // var results = analyzer.AnalyzePointAccuracy(a, b, nValues, points);
        //
        // Console.WriteLine("Analiza wpływu punktu wyliczania na dokładność całki y=1/2*x na [0,2]:");
        // Console.WriteLine("n\t\tPunkt\t\tWynik całki\t\tBłąd bezwzględny");
        // Console.WriteLine(new string('-', 60));
        //
        // foreach (var result in results)
        // {
        //     Console.WriteLine($"{result.n}\t\t{result.point}\t\t{result.result:F8}\t\t{result.error:F8}");
        // }
        
        
        
        //-----zadadnie 6----
        // IntegrationMethodAnalyzer analyzer = new IntegrationMethodAnalyzer();
        //
        // double a = 0; 
        // double b = 2;
        // int[] nValues = { 10, 50, 100, 500, 1000 };
        //
        // var results = analyzer.AnalyzeMethodAccuracy(a, b, nValues);
        //
        // Console.WriteLine("Analiza wpływu metody aproksymacji na dokładność całki y=1/2*x na [0,2]:");
        // Console.WriteLine("n\t\tMetoda\t\tWynik całki\t\tBłąd bezwzględny");
        // Console.WriteLine(new string('-', 60));
        //
        // foreach (var result in results)
        // {
        //     Console.WriteLine($"{result.n}\t\t{result.method}\t\t{result.result:F8}\t\t{result.error:F8}");
        // }
        
        
        
        //-----zadadnie 7----
        // IntegralCalculator calculator = new IntegralCalculator();
        //
        // double a = 0;
        // double b = 2 * Math.PI;
        // int n = 1000;
        //
        // try
        // {
        //     double result = calculator.RectangleMethod(a, b, n);
        //     Console.WriteLine($"Wartość przybliżona całki sin(x) na [{a:F2}, {b:F2}] " +
        //                       $"metodą prostokątów (n={n}): {result:F6}");
        //     
        //     Console.WriteLine($"Wartość dokładna: 0.0");
        // }
        // catch (ArgumentException ex)
        // {
        //     Console.WriteLine($"Błąd: {ex.Message}");
        // }
        
        
        
        //-----zadadnie 8----
        // QuadraticIntegralSolver calculator = new QuadraticIntegralSolver();
        //
        // try
        // {
        //    
        //     Console.Write("Podaj parametr a: ");
        //     double aCoeff = Convert.ToDouble(Console.ReadLine());
        //
        //     Console.Write("Podaj parametr b: ");
        //     double bCoeff = Convert.ToDouble(Console.ReadLine());
        //
        //     Console.Write("Podaj parametr c: ");
        //     double cCoeff = Convert.ToDouble(Console.ReadLine());
        //
        //     Console.Write("Podaj dolną granicę przedziału: ");
        //     double a = Convert.ToDouble(Console.ReadLine());
        //
        //     Console.Write("Podaj górną granicę przedziału: ");
        //     double b = Convert.ToDouble(Console.ReadLine());
        //
        //     Console.Write("Podaj liczbę prostokątów: ");
        //     int n = Convert.ToInt32(Console.ReadLine());
        //
        //     
        //     double approximateResult = calculator.RectangleMethod(aCoeff, bCoeff, cCoeff, a, b, n);
        //     double exactResult = calculator.ExactIntegral(aCoeff, bCoeff, cCoeff, a, b);
        //
        //     
        //     Console.WriteLine($"\nFunkcja: y = {aCoeff}x^2 + {bCoeff}x + {cCoeff}");
        //     Console.WriteLine($"Przybliżona wartość całki na [{a}, {b}] metodą prostokątów (n={n}): {approximateResult:F6}");
        //     Console.WriteLine($"Dokładna wartość całki: {exactResult:F6}");
        //     Console.WriteLine($"Błąd bezwzględny: {Math.Abs(approximateResult - exactResult):F6}");
        // }
        // catch (FormatException)
        // {
        //     Console.WriteLine("Błąd: Wprowadź poprawne wartości liczbowe.");
        // }
        // catch (ArgumentException ex)
        // {
        //     Console.WriteLine($"Błąd: {ex.Message}");
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine($"Wystąpił błąd: {ex.Message}");
        // }
    }
}