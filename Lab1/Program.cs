using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegrationRunner runner = new IntegrationRunner();

            while (true)
            {
                Console.WriteLine("\n=== Menu ===");
                Console.WriteLine("1. Zadanie 1 - FibonacciCalculator");
                Console.WriteLine("2. Zadanie 2 - FibonacciCalculator2");
                Console.WriteLine("3. Zadanie 3 - NumericalIntegration (y=1/2*x)");
                Console.WriteLine("4. Zadanie 4 - IntegrationAccuracyAnalyzer");
                Console.WriteLine("5. Zadanie 5 - IntegrationPointAnalyzer");
                Console.WriteLine("6. Zadanie 6 - IntegrationMethodAnalyzer");
                Console.WriteLine("7. Zadanie 7 - IntegralCalculator (sin(x))");
                Console.WriteLine("8. Zadanie 8 - QuadraticIntegralSolver");
                Console.WriteLine("0. Wyjście");
                Console.Write("Wybierz zadanie (0-8): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        runner.RunTask1();
                        break;
                    case "2":
                        runner.RunTask2();
                        break;
                    case "3":
                        runner.RunTask3();
                        break;
                    case "4":
                        runner.RunTask4();
                        break;
                    case "5":
                        runner.RunTask5();
                        break;
                    case "6":
                        runner.RunTask6();
                        break;
                    case "7":
                        runner.RunTask7();
                        break;
                    case "8":
                        runner.RunTask8();
                        break;
                    case "0":
                        Console.WriteLine("Zamykanie programu...");
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Wybierz numer od 0 do 8.");
                        break;
                }

                Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}