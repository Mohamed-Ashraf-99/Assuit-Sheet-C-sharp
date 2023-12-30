namespace K_Max_and_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();
            string[] numbersAfterSplit = inputNumbers.Split(' ');

            long firstNumber = long.Parse(numbersAfterSplit[0]);
            long secondNumber = long.Parse(numbersAfterSplit[1]);
            long thirdNumber = long.Parse(numbersAfterSplit[2]);

            if (firstNumber >= thirdNumber && thirdNumber >= secondNumber)
                Console.WriteLine(thirdNumber + " " + firstNumber);
            else if (firstNumber >= thirdNumber && thirdNumber >= secondNumber)
                Console.WriteLine(secondNumber + " " +  firstNumber);
            else if (secondNumber >= firstNumber && firstNumber >= thirdNumber)
                Console.WriteLine(thirdNumber + " " +  secondNumber);
            else if (secondNumber >= thirdNumber && thirdNumber >= firstNumber)
                Console.WriteLine(firstNumber + " " +  secondNumber);
            else if (thirdNumber >= firstNumber && firstNumber >= secondNumber)
                Console.WriteLine(secondNumber + " " +  thirdNumber);
            else if (thirdNumber >= secondNumber && secondNumber >= firstNumber)
                Console.WriteLine(firstNumber + " " +  thirdNumber);
        }
    }
}