﻿namespace F_Multiplication_table;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1 ; i <= 12; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}