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

        public ListaCircular()
        {
            cabeza = null;
            cola = null;
        }

        // Método para añadir un nuevo nodo al final de la lista
        public void Añadir(int valor)
        {
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

        // Método para eliminar un nodo con un valor específico
        public void Eliminar(int valor)
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

                    Console.WriteLine($"Nodo con valor {valor} eliminado.");
                    return;
                }

                previo = actual;
                actual = actual.Siguiente;
            } while (actual != cabeza);

            Console.WriteLine($"Nodo con valor {valor} no encontrado.");
        }
    }

}
