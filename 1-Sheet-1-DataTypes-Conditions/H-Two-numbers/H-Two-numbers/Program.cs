namespace H_Two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this step for allow user to input the number in one line
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            double firstNumber = double.Parse(numbers[0]);
            double secondNumber = double.Parse(numbers[1]);

            double floor = Math.Floor(firstNumber / secondNumber);
            Console.WriteLine($"floor {firstNumber} / {secondNumber} = {floor}");
            
            double ceil = Math.Ceiling(firstNumber / secondNumber);
            Console.WriteLine($"ceil {firstNumber} / {secondNumber} = {ceil}");

            double round = Math.Round(firstNumber / secondNumber);
            Console.WriteLine($"round {firstNumber} / {secondNumber} = {round}");
        }
    }
}
