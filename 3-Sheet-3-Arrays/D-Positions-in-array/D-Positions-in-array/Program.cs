namespace D_Positions_in_array;

class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        string[] numbersBeforeParse = Console.ReadLine().Split();

        int[] numbers = new int[size];
        for (int i = 0 ; i < size ; i++)
        {
            numbers[i] = int.Parse(numbersBeforeParse[i]);
        }

        for (int i = 0 ; i < size ; i++)
        {
            if(numbers[i] <= 10)
                Console.WriteLine($"A[{i}] = {numbers[i]}");
        }
    }
}