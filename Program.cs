using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_4_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Primero número: ");
            int primero = int.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            int segundo = int.Parse(Console.ReadLine());
            int suma = primero + segundo;
            int resta = primero - segundo;
            int multi = primero * segundo;
            int division = primero / segundo;
            int residio = primero % segundo;

            Console.WriteLine("LA SUMA ES: " + suma);
            Console.WriteLine("LA RESTA ES: " + resta);
            Console.WriteLine("LA MULTIPLICACIóN ES: " + multi);
            Console.WriteLine("LA DIVISIóN ES: " + division);
            Console.WriteLine("LA RESIDUO ES: " + residio);

            Console.ReadKey();
        }
    }
}
