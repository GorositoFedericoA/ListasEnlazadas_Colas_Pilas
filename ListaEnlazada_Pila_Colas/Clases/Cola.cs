using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazada_Pila_Colas.Clases
{
    public class Cola
    {

       public Queue<Nodo> colaNodo = new Queue<Nodo>();


        //encolamiento de las nodos
        public void Encolar(Nodo unNodo) 
        {
            colaNodo.Enqueue(unNodo);
        }

        //desencolamiento de los nodos
        public void Desencolar() 
        {
            if (colaNodo.Count > 0)
            {
                colaNodo.Dequeue();
            }
            else 
            {
                return;
            }
            
        }


        public Nodo PrimerElemento() 
        {
            return colaNodo.Peek();
        }

        public int Cantidad() 
        {
           return colaNodo.Count;
        }
    }
}
