namespace B_Searching;

class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        
        string[] numbersBeforParse = Console.ReadLine().Split();
        int[] numbers = new int[size];
        
        for (int i = 0; i < size; i++)
            numbers[i] = int.Parse(numbersBeforParse[i]);
        
        int target = int.Parse(Console.ReadLine());
        
        int position = Array.IndexOf(numbers, target);
        
        Console.WriteLine(position);
    }
}