namespace L_GCD;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split();

        int firstNumber = int.Parse(numbers[0]);
        int secondNumber = int.Parse(numbers[1]);

        int minNumber = Math.Min(firstNumber, secondNumber);
        int greatestCommonDivisor = 0;
        
        for (int i = 1; i <= minNumber ; i++)
        {
            if (firstNumber % i == 0 && secondNumber % i == 0)
            {
                int temp = i;
                if (temp > greatestCommonDivisor)
                {
                    greatestCommonDivisor = temp;
                }
            }
        }
        Console.WriteLine(greatestCommonDivisor);
    }
}