namespace A_Summation;

class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        
        string[] numbers = Console.ReadLine().Split();
        
        long sum = 0;
        for (int i = 0; i < size; i++)
        {
            long number = long.Parse(numbers[i]);
            sum += number;
        }
        
        long absSum = Math.Abs(sum);
        Console.WriteLine(absSum);
    }
}