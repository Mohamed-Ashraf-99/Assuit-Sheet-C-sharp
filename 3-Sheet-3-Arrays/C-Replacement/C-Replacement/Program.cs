namespace C_Replacement;

class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        string[] numbersBeforeParse = Console.ReadLine().Split();

        int[] numbers = new int[size];
        
        for (int i = 0; i < size ; i++)
        {
            numbers[i] = int.Parse(numbersBeforeParse[i]);
        }

        for (int i = 0; i < size; i++)
        {
            if (numbers[i] > 0)
                numbers[i] = 1;
            else if (numbers[i] < 0)
                numbers[i] = 2;
        }

        foreach (var number in numbers)
        {
            Console.Write($"{number} ");
        }
    }
}