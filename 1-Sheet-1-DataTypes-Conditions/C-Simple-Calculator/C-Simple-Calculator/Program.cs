namespace C_Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');
            int firstNum = int.Parse(numbers[0]);
            int secondNum = int.Parse(numbers[1]);

            int sum = firstNum + secondNum;
            int multiplication = firstNum * secondNum;
            int subtraction = firstNum - secondNum;

            Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
            Console.WriteLine($"{firstNum} * {secondNum} = {multiplication}");
            Console.WriteLine($"{firstNum} - {secondNum} = {subtraction}");
        }
    }
}
