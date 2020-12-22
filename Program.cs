using System;

namespace tic_tack_toe_
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fieldStates = new string[9];
            Console.Write(" first field ");
            fieldStates[0] = Console.ReadLine();
            Console.Write("the second field ");
            fieldStates[1] = Console.ReadLine();
            Console.Write("the third field ");
            fieldStates[2] = Console.ReadLine();
            Console.Write("the fourth field ");
            fieldStates[3] = Console.ReadLine();
            Console.Write("the fifth field ");
            fieldStates[4] = Console.ReadLine();
            Console.Write("the sixth field ");
            fieldStates[5] = Console.ReadLine();
            Console.Write("the seventh field ");
            fieldStates[6] = Console.ReadLine();
            Console.Write("the eight field ");
            fieldStates[7] = Console.ReadLine();
            Console.Write("the nine field ");
            fieldStates[8] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($" {fieldStates[0]} | {fieldStates[1]} | {fieldStates[2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {fieldStates[3]} | {fieldStates[4]} | {fieldStates[5]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($"{fieldStates[6]} | {fieldStates[7]} | {fieldStates[8]}");
         
            Console.ReadLine();

        }
    }
}
