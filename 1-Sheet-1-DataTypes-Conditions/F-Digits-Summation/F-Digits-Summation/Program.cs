namespace F_Digits_Summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //To can take input from the user in one line seperated by ' '
           string userInput = Console.ReadLine();
           string[] numbers = userInput.Split(' ');
           
           long firstNumber = long.Parse(numbers[0]);
           long secondNumber = long.Parse(numbers[1]);

            firstNumber = firstNumber % 10;
            secondNumber = secondNumber % 10;

            long result = firstNumber + secondNumber;

            Console.WriteLine(result);
        }
    }
}
