using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazada_Pila_Colas.Clases
{
    public class Pila
    {
        public Stack<Nodo> PilaNodo = new Stack<Nodo>();


        public void Push(Nodo unNodo) 
        {
            PilaNodo.Push(unNodo);
        }

        public void Pop() 
        {
            if (PilaNodo == null) 
            {
                return;
            }
            else 
            {
               PilaNodo.Pop();
            }
        }

        public Nodo Peek() 
        {
           return PilaNodo.Peek();
        }

        public int Cantidad() 
        {
            return PilaNodo.Count;
        }

    }
}
