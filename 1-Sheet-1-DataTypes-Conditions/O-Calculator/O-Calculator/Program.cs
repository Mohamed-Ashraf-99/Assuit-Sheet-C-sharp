namespace O_Calculator;

class Program
{
    static void Main(string[] args)
    {
        string exprissonInput = Console.ReadLine();
        string[] exprisson = exprissonInput.Split(' ');
        
        int firstNumber = int.Parse(exprisson[0]);
        char operatorSign = char.Parse(exprisson[1]);
        int secondNumber = int.Parse(exprisson[2]);

        switch (operatorSign)
        {
            case '+':
                Console.WriteLine(firstNumber + secondNumber);
                break;
            case '-':
                Console.WriteLine(firstNumber - secondNumber);
                break;
            case '*':
                Console.WriteLine(firstNumber * secondNumber);
                break;
            case '/':
                Console.WriteLine(firstNumber / secondNumber);
                break;
        }
    }
}