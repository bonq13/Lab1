namespace Lab1;

public class FibonacciCalculator2
{
    public void CalculateFibonacci()
    {
        Console.WriteLine("Ten program wygeneruje ciąg Fibonacciego.");
        Console.Write("Podaj pierwszą liczbę (początkowy element): ");
        if (!int.TryParse(Console.ReadLine(), out int start) || start < 0)
        {
            Console.WriteLine("Błąd: Wprowadź prawidłową liczbę naturalną.");
            return;
        }

        Console.Write("Podaj liczbę elementów do wygenerowania: ");
        if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
        {
            Console.WriteLine("Błąd: Liczba elementów musi być większa od 0.");
            return;
        }

        int[] fibonacci = GenerateFibonacciSequence(start, count);
        if (fibonacci == null)
        {
            Console.WriteLine("Nie udało się wygenerować ciągu dla podanych danych.");
            return;
        }

        Console.WriteLine("Wygenerowane elementy ciągu Fibonacciego:");
        for (int i = 0; i < fibonacci.Length; i++)
        {
            Console.Write(fibonacci[i] + " ");
        }
    }

    private int[] GenerateFibonacciSequence(int start, int count)
    {
        int[] sequence = new int[count];
        sequence[0] = start;

        if (count == 1) return sequence;

        
        int prev = 0;
        int current = 1;
        while (current < start)
        {
            int next = prev + current;
            prev = current;
            current = next;
            if (current == start) break;
            if (current > start) return null; 
        }

        sequence[1] = prev + start;
        for (int i = 2; i < count; i++)
        {
            sequence[i] = sequence[i - 1] + sequence[i - 2];
        }

        return sequence;
    }
}