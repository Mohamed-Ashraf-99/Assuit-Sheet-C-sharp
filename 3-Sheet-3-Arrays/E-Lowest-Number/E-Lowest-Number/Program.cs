namespace E_Lowest_Number;

class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        string[] numbersBeforeParse = Console.ReadLine().Split();
        int[] numbers = new int[size];
 
        for (int i = 0 ; i < size; i++)
        {
            numbers[i] = int.Parse(numbersBeforeParse[i]);
        }
        
        int minNumber = numbers[0];
        int position = 0;
        for (int i = 0 ; i < size ; i++)
        {
            if (minNumber > numbers[i])
            {
                minNumber = numbers[i];
                position = i;
            }
        }
        
        position += 1;
        Console.Write($"{minNumber} {position}");
    }
}
