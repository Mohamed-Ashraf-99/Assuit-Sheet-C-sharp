namespace R_Age_in_Days;

class Program
{
    static void Main(string[] args)
    {
        int numberOfDaysInput = int.Parse(Console.ReadLine());

        int numberOfYears , numberOfMonth , numberOfDays;
        numberOfYears = numberOfDaysInput / 365;
        numberOfMonth = (numberOfDaysInput - (365 * numberOfYears))/30;
        numberOfDays = (numberOfDaysInput - (365 * numberOfYears) - (30 * numberOfMonth));
      
        Console.WriteLine($"{numberOfYears} years");
        Console.WriteLine($"{numberOfMonth} months");
        Console.WriteLine($"{numberOfDays} days");
    }
}