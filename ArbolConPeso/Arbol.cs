using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolConPeso
{
    
    public class Arbol
    {
        // Propiedad que representa el peso del nodo actual
        public int Peso { get; set; }
        // Propiedad que representa el subárbol izquierdo del nodo actual
        public Arbol Izquierdo { get; set; }
        // Propiedad que representa el subárbol derecho del nodo actual
        public Arbol Derecho { get; set; }

        // Constructor que asigna el peso al nodo cuando se crea
        public Arbol(int Peso)
        {
            this.Peso = Peso;
        }
        public static void Main(string[] args)
        {
            // Cree una instancia de la clase Arbol y asigne un valor a la raíz según el dato ingresado por el usuario
            Console.WriteLine("Ingrese el peso de la raíz del árbol: ");
            int rootWeight = int.Parse(Console.ReadLine());
            Arbol tree = new Arbol(rootWeight);
            // Utilice ciclos y condicionales para pedir al usuario que ingrese los pesos de los nodos del árbol y agregue los nodos al árbol
            bool continueInput = true;
            while (continueInput)
            {
                Console.WriteLine("¿Hay más hijos por la izquierda? (s/n)");
                string leftInput = Console.ReadLine();
                if (leftInput == "s")
                {
                    Console.WriteLine("Ingrese el peso del nodo hijo izquierdo: ");
                    int leftWeight = int.Parse(Console.ReadLine());
                    tree.Izquierdo = new Arbol(leftWeight);
                }

                Console.WriteLine("¿Hay más hijos por la derecha? (s/n)");
                string rightInput = Console.ReadLine();
                if (rightInput == "s")
                {
                    Console.WriteLine("Ingrese el peso del nodo hijo derecho: ");
                    int rightWeight = int.Parse(Console.ReadLine());
                    tree.Derecho = new Arbol(rightWeight);
                }

                Console.WriteLine("¿Hay más hijos por agregar? (s/n)");
                string moreInput = Console.ReadLine();
                if (moreInput == "n")
                {
                    continueInput = false;
                }
            }


            // Obtiene el peso total del árbol
            int PesoTotal = tree.ObtenerPesoTotal();
            Console.WriteLine("Peso total del árbol: " + PesoTotal);

            // Obtiene el peso promedio del árbol
            double PesoPromedio = tree.ObtenerPesoPromedio();
            Console.WriteLine("Peso promedio del árbol: " + PesoPromedio);

            // Obtiene la cantidad de nodos en el árbol
            int CuentaNodos = tree.ObtenerCuentaNodos();
            Console.WriteLine("Cantidad de nodos en el árbol: " + CuentaNodos);

            // Obtiene la altura del árbol
            int Altura = tree.ObtenerAltura();
            Console.WriteLine("Altura del árbol: " + Altura);


        }
        // Método que devuelve el peso total del árbol
        public int ObtenerPesoTotal()
        {
            // Inicializa la variable de peso total con el peso del nodo actual
            int PesoTotal = Peso;
            // Si el subárbol izquierdo no es nulo, agrega el peso total del subárbol izquierdo
            if (Izquierdo != null)
            {
                PesoTotal += Izquierdo.ObtenerPesoTotal();
            }
            // Si el subárbol derecho no es nulo, agrega el peso total del subárbol derecho
            if (Derecho != null)
            {
                PesoTotal += Derecho.ObtenerPesoTotal();
            }
            // Devuelve el peso total
            return PesoTotal;
        }

        // Método que devuelve el peso promedio del árbol
        public double ObtenerPesoPromedio()
        {
            // Obtiene el peso total y la cantidad de nodos en el árbol
            int PesoTotal = ObtenerPesoTotal();
            int NumeroNodo = ObtenerCuentaNodos();
            // Devuelve el peso promedio dividiendo el peso total entre la cantidad de nodos
            return (double)PesoTotal / NumeroNodo;
        }
        // Método que devuelve la cantidad de nodos en el árbol
        public int ObtenerCuentaNodos()
        {
            // Inicializa la variable de conteo de nodos en 1 (para contar el nodo actual)
            int NumeroNodos = 1;
            // Si el subárbol izquierdo no es nulo, agrega la cantidad de nodos en el subárbol izquierdo
            if (Izquierdo != null)
            {
                NumeroNodos += Izquierdo.ObtenerCuentaNodos();
            }
            // Si el subárbol derecho no es nulo, agrega la cantidad de nodos en el subárbol derecho
            if (Derecho != null)
            {
                NumeroNodos += Derecho.ObtenerCuentaNodos();
            }
            // Devuelve la cantidad de nodos
            return NumeroNodos;
        }
        // Método que devuelve la altura del árbol
        public int ObtenerAltura()
        {
            // Inicializa las variables de altura del subárbol izquierdo y derecho en 0
            int AlturaIzquierda = 0;
            int AlturaDerecha = 0;
            // Si el subárbol izquierdo no es nulo, obtiene la altura del subárbol izquierdo
            if (Izquierdo != null)
            {
                AlturaIzquierda = Izquierdo.ObtenerAltura();
            }
            // Si el subárbol derecho no es nulo, obtiene la altura del subárbol derecho
            if (Derecho != null)
            {
                AlturaDerecha = Derecho.ObtenerAltura();
            }
            // Devuelve la altura máxima de los subárboles más 1 (para contar la raíz)
            return Math.Max(AlturaIzquierda, AlturaDerecha) + 1;
        }
    }

}

