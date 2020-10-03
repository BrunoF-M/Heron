using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Olá me chamo Heron Calc.");
            Console.WriteLine();

            Console.ResetColor();

double sideA;
            Console.Write("De um valor ao lado A: ");
            sideA = double.Parse(Console.ReadLine());

double sideB;
            Console.Write("Agora ao lado B: ");
            sideB = double.Parse(Console.ReadLine());

double sideC;
            Console.Write("lado C..: ");
            sideC = double.Parse(Console.ReadLine());
            Console.Write("");

double resP;
            resP = (sideA) /2 +(sideB) /2 +(sideC) /2;

double resA;
            resA = Math.Sqrt(resP*(resP-sideA)*(resP-sideB)*(resP-sideC));

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine();
            Console.WriteLine($"Semiperimetro = {resP}");
            Console.WriteLine($"Area = {resA}cm²");
            
            Console.WriteLine();

            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
    }
}
