using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestProgra3.Utility
{
    public class ListaCircular
    {
        private Nodo cabeza;
        private Nodo cola;
        private int capacidadMaxima;
        private int contador;

        public ListaCircular(int capacidad)
        {
            cabeza = null;
            cola = null;
            capacidadMaxima = capacidad;
            contador = 0;
        }

        // Método para añadir un nuevo nodo al final de la lista
        public void Añadir(string valor)
        {
            if (contador >= capacidadMaxima)
            {
                Console.WriteLine("La lista ha alcanzado su capacidad máxima. No se puede añadir el nuevo nodo.");
                return;
            }

            Nodo nuevoNodo = new Nodo(valor);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
                nuevoNodo.Siguiente = cabeza; // Apunta a sí mismo para formar la circularidad
            }
            else
            {
                cola.Siguiente = nuevoNodo;
                cola = nuevoNodo;
                cola.Siguiente = cabeza; // Mantener la circularidad
            }

            contador++;
        }

        // Método para imprimir los valores de la lista circular
        public void Imprimir()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo actual = cabeza;
            do
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Siguiente;
            } while (actual != cabeza);
            Console.WriteLine();
        }

        public bool HayEspacioDisponible()
        {
            return contador < capacidadMaxima;
        }


        public int retornarContador()
        {
            return contador;
        }

        // Método para eliminar un nodo con un valor específico
        public void Eliminar(string valor)
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo actual = cabeza;
            Nodo previo = null;

            do
            {
                if (actual.Valor == valor)
                {
                    if (previo != null)
                    {
                        previo.Siguiente = actual.Siguiente;

                        if (actual == cola)
                        {
                            cola = previo;
                        }
                    }
                    else
                    {
                        if (cabeza == cola)
                        {
                            cabeza = null;
                            cola = null;
                        }
                        else
                        {
                            cabeza = cabeza.Siguiente;
                            cola.Siguiente = cabeza;
                        }
                    }

                    contador--;
                    Console.WriteLine($"Nodo con valor {valor} eliminado.");
                    return;
                }

                previo = actual;
                actual = actual.Siguiente;
            } while (actual != cabeza);

            Console.WriteLine($"Nodo con valor {valor} no encontrado.");
        }

        // Método para imprimir un nodo específico
        public string ImprimirNodo(string valor)
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return "";
            }

            Nodo actual = cabeza;
            do
            {
                if (actual.Valor == valor)
                {
                    return actual.Valor;
                }
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return "";
        }


    }

}
