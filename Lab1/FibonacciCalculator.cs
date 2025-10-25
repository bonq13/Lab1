namespace Lab1;

public class FibonacciCalculator
{
    public void Calculate()
    {
        Console.Write("Podaj ilość elementów ciągu Fibonacciego: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Liczba elementów musi być większa od 0.");
            return;
        }

        int[] fibonacci = new int[n];
        fibonacci[0] = 0;
        if (n > 1) fibonacci[1] = 1;

        for (int i = 2; i < n; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        Console.WriteLine("Elementy ciągu Fibonacciego:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(fibonacci[i] + " ");
        }
    }
}