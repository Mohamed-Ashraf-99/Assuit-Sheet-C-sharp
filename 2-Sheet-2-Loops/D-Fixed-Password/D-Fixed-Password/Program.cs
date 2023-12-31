namespace D_Fixed_Password;

class Program
{
    static void Main(string[] args)
    {
        int password = 0;
        while (true)
        {
            password = int.Parse(Console.ReadLine());
            if (password == 1999) {
                Console.WriteLine("Correct"); 
                break;
            }
            else
                Console.WriteLine("Wrong"); 
        }
    }
}