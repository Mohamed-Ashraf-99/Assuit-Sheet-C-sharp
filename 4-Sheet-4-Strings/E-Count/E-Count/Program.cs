namespace E_Count;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int numbers = int.Parse(input);

        int sum = 0;
        for (int i = numbers; i > 0 ; i/=10)
        {
            int digit = i % 10;
            sum += digit;
        }
        Console.WriteLine(sum);
    }
}