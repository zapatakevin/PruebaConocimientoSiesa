using NUnit.Framework;
using System;

namespace PruebaUnitaria
{
    public class PruebaCambioBase
    {
        [TestCase("287", 10, 4, "10133")]
        [TestCase("1010", 2, 10, "10")]
        [TestCase("1111", 2, 16, "F")]
        [TestCase("10", 8, 2, "2")]

        [Test]
        public void Demostracion(string number, int numbase, int newBase, string expectedResult)
        {
            // convierte el número a base 10
            int numberInBase = 0;
            for (int i = 0; i < number.Length; i++)
            {
                // utiliza el algoritmo de conversión de base numé
                numberInBase += int.Parse(number[i].ToString()) * (int)Math.Pow(numbase, number.Length - i - 1);
            }

            string result = "";

            // utiliza el algoritmo de división sucesiva para convertir el número a la nueva base
            while (numberInBase > 0)
            {
                int remainder = numberInBase % newBase;
                result = remainder + result;
                numberInBase /= newBase;
            }
            Assert.AreEqual(expectedResult, result);
        }
    }
}
//En este código se define la clase de pruebas unitarias PruebaCambioBase,
//que incluye una prueba unitaria llamada Demostracion.
//Esta prueba unitaria incluye cuatro casos de prueba, cada uno con un número a convertir,
//la base del número y la base a la que se desea convertir, y el resultado esperado de la conversión.
//La prueba unitaria utiliza dos algoritmos diferentes para convertir el número a la base deseada:
//el algoritmo de conversión de base numérica y el algoritmo de división sucesiva.
//Primero, convierte el número a base 10 mediante el algoritmo de conversión de base numérica.
//Luego, utiliza el algoritmo de división sucesiva para convertir el número a la nueva base.
//Finalmente, utiliza la función Assert.
//AreEqual para comprobar que el resultado de la conversión es el esperado.