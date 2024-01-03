namespace M_Lucky_Numbers;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split();

        int firstNumber = int.Parse(numbers[0]);
        int secondNumber = int.Parse(numbers[1]);

        int minNumber = Math.Min(firstNumber, secondNumber);
        int maxNumber = Math.Max(firstNumber, secondNumber);

        int counter = 0;
        for (int i = minNumber; i <= maxNumber; i++)
        {
                bool flag = true;
                int number = i;
                while (number != 0)
                {
                    int temp = number % 10;
                    if (temp != 7 && temp != 4)
                    {
                        flag = false;
                    }
                    number /= 10;
                }
                if (flag)
                {
                    Console.Write($"{i} ");
                    counter++;
                }
        }
        if(counter == 0)
            Console.WriteLine("-1");
    }
}