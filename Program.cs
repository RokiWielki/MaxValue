//Napisz program pobierający od użytkownika 3 liczby. Program ma wyświetlić wartość
//największej z nich.
using System;

namespace MaxValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Największa wartość: ");
            Max(a, b, c);
            
        }
        static void Max(int a,int b,int c)
        {
            if (a >= b && a >= c) Console.Write(a);
            else if (b >= a && b >= c) Console.Write(b);
            else Console.Write(c);
        }
    }
}
