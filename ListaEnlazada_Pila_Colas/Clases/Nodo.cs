using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazada_Pila_Colas.Clases
{
    public class Nodo
    {
        public string Nombre { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string nombre, Nodo siguiente) 
        {
            Nombre = nombre;
            Siguiente = null;
        }
    }
}
