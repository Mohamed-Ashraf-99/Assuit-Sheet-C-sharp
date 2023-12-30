namespace I_Welcome_for_you_with_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int firstNumber = int.Parse(numbers[0]);
            int secondNumber = int.Parse(numbers[1]);

            if (firstNumber >= secondNumber)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            
        }
    }
}
