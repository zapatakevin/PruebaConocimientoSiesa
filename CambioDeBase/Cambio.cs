
using System;

namespace CambioDeBase
{
    class Cambio
    {
            public static void Main(string[] args)
        {
            // pide al usuario que ingrese un número y lo guarda en la variable number
            Console.WriteLine("Ingrese un número:");
            string number = Console.ReadLine();

            // pide al usuario que ingrese la base del número y lo guarda en la variable numbase
            Console.WriteLine("Ingrese la base del número:");
            int numbase = int.Parse(Console.ReadLine());

            // pide al usuario que ingrese la base a la que desea convertir el número y lo guarda en la variable newBase
            Console.WriteLine("Ingrese la base a la que desea convertir el número:");
            int newBase = int.Parse(Console.ReadLine());

            // llama a la función ConvertNumber para convertir el número a la nueva base y guarda el resultado en la variable result
            string result = ConvertNumber(number, numbase, newBase);

            // imprime el resultado de la conversión en pantalla
            Console.WriteLine($"El número {number} en base {newBase} es {result}");
        }

         public static string ConvertNumber(string number, int numbase, int newBase)
        {
            // convierte el número a base 10
            int numberInBase = 0;
            for (int i = 0; i < number.Length; i++)
            {
                // utiliza el algoritmo de conversión de base del numero iingresado.
                numberInBase += int.Parse(number[i].ToString()) * (int)Math.Pow(numbase, number.Length - i - 1);
            }

            string result = "";

            // utiliza el algoritmo de división sucesiva para convertir el número a la nueva base.
            while (numberInBase > 0)
            {
                int remainder = numberInBase % newBase;
                result = remainder + result;
                numberInBase /= newBase;
            }
            //Retorna el resultado del numero convertido en base n.
            return result;
        }
    }
}
