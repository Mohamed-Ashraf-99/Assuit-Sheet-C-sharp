namespace D_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

           string[] numbers = input.Split(' ');
           long firstNumber = long.Parse(numbers[0]);
           long secondNumber = long.Parse(numbers[1]);
           long thirdNumber = long.Parse(numbers[2]);
           long fourthNumber = long.Parse(numbers[3]);
           long difference = (firstNumber * secondNumber) - (thirdNumber * fourthNumber);
           
           Console.WriteLine($"Difference = {difference}");
           
        }
    }
}
