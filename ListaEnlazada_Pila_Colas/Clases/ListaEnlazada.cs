using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazada_Pila_Colas.Clases
{
    public class ListaEnlazada
    {
        private Nodo Cabeza;

        public ListaEnlazada() 
        {
            Cabeza.Siguiente = null;
        }


        public void Agregar(string nombre) 
        {
            if (Cabeza.Nombre == null)
            {
                Cabeza.Nombre = nombre;
            }
            else 
            {
                
            }
        }
        

    }
}
