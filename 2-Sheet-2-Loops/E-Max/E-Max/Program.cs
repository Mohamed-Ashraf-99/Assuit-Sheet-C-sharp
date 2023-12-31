namespace E_Max;

class Program
{
    static void Main(string[] args)
    {
        //Count of numbers
        long counter = long.Parse(Console.ReadLine());
        long maxNumber = 0;
        
        //Numbers which you should to find the max in it
        string numbersInput = Console.ReadLine();
        string[] numbers = numbersInput.Split(' ');

        long number;
        for (int i = 0; i < counter; i++)
        {
            number = long.Parse(numbers[i]);
            
            if (number > maxNumber)
                maxNumber = number;
        }
        Console.WriteLine(maxNumber);
    }
}