using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Enter a formula to generate values for the array elements (e.g., n^2):");
        string formula = Console.ReadLine();

        for (int i = 0; i < numbers.Length; i++)
        {
            int n = i + 1;
            numbers[i] = EvaluateFormula(formula, n);
        }

        Console.WriteLine("Array elements:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int largest = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        Console.WriteLine("Largest element in the array: " + largest);
    }

    static int EvaluateFormula(string formula, int n)
    {
        string[] parts = formula.Split('^');

        if (parts.Length != 2 || !int.TryParse(parts[1], out int power))
        {
            throw new ArgumentException("Invalid formula format. Expected format: n^power");
        }
        return (int)Math.Pow(n, power);
    }
}
