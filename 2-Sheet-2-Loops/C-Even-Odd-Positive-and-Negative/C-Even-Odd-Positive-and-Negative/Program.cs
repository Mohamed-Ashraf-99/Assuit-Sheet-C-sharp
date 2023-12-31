namespace C_Even_Odd_Positive_and_Negative;

class Program
{
    static void Main(string[] args)
    {
        int counter = int.Parse(Console.ReadLine());
        
        int evenCounter = 0;
        int oddCounter = 0;
        int positiveCounter = 0;
        int negativeCounter = 0;

        string numbersInput = Console.ReadLine();
        string[] numbers = numbersInput.Split(' ');
        
        for (int i = 0; i < counter ; i++)
        {
            int number = int.Parse(numbers[i]);
            if (number % 2 == 0)
                evenCounter++;
            else 
                oddCounter++;
            if (number > 0)
                positiveCounter++;
            else if (number < 0)
                negativeCounter++;
        }
        Console.WriteLine($"Even: {evenCounter}");
        Console.WriteLine($"Odd: {oddCounter}");
        Console.WriteLine($"Positive: {positiveCounter}");
        Console.WriteLine($"Negative: {negativeCounter}");
    }
}