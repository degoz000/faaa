using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer3();
            Console.ReadKey(); //detenimiento de consola
        }

        static void ejer1()
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso " +
                $"de Fundamentos de Algoritmo de la carrera {carrera}");
        }

        static void ejer2()
        {
            Console.WriteLine("\"Diego\"");
        }

        static void ejer3()
        {
            Console.WriteLine("ingrese número 1: ");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el número 2");
            int num2=int.Parse(Console.ReadLine());

            double divi = (double)num1 / (double)num2;

            Console.WriteLine("Suma: "+(num1+num2));
            Console.WriteLine("Resta: "+(num1 -  num2));
            Console.WriteLine("multiplicación : " + (num1 * num2));
            Console.WriteLine("División :" + divi);
        }

        static void ejer4()
        {

        }

        static void ejer5()
        {

        }

        static void ejer6()
        {

        }
    }
}
