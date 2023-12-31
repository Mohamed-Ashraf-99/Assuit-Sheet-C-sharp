namespace B_Even_Numbers;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if(number == 1)
            Console.WriteLine(-1);
        //for loop to print the even numbers between 1 to N
        for (int i = 1; i <= number; i++) 
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}