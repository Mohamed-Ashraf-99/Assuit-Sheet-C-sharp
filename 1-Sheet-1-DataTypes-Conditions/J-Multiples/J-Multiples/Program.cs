namespace J_Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
           string[] numbers = input.Split(' ');

           long firstNumber = long.Parse(numbers[0]);
           long secondNumber = long.Parse(numbers[1]);

           long multipleResult = firstNumber % secondNumber;
           long multipleResult2 = secondNumber % firstNumber;


            if (multipleResult == 0 || multipleResult2 == 0)
                Console.WriteLine("Multiples");
            else
                Console.WriteLine("No Multiples");
        }
    }
}
