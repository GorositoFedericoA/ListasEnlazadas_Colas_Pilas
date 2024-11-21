using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazada_Pila_Colas.Clases
{
    public class ListaEnlazada
    {
        public Nodo Inicio;

        public void AgregarAlFinal(Nodo unNodo)
        {
            if (Inicio != null) 
            {
                Nodo ultimoNodo = new Nodo();
                ultimoNodo = BuscarAlFinal(Inicio);
                ultimoNodo.Siguiente = unNodo;
            }
            else
            {
                AgregarAlPrincipio(unNodo);
            }

        }



        public void AgregarAlPrincipio(Nodo unNodo)
        {
            if (Inicio == null)
            {
                Inicio = unNodo;
            }
            else
            {
                Nodo auxiliar = Inicio;
                Inicio = unNodo;
                Inicio.Siguiente = auxiliar;
            }
        }




        public void EliminarAlprincipio()
        {
            if (Inicio != null) 
            {
                Inicio = Inicio.Siguiente;
            }
        }


        public void EliminarAlFinal() 
        {
            if (Inicio == null) return; //lista vacia
            if (Inicio.Siguiente == null) // unico elemento de la lista
            {
                Inicio = null;
                return;
            }
             

            
            Nodo anteUltimoNodo = new Nodo();
            anteUltimoNodo = BuscarAnteUltimoNodo(Inicio);
            anteUltimoNodo.Siguiente = null;
        }



        public Nodo BuscarAlFinal(Nodo unNodo)
        {
            if (unNodo.Siguiente != null)
            {
                return BuscarAlFinal(unNodo.Siguiente);
            }
            else
            {
                return unNodo;
            }
        }

        public Nodo BuscarAnteUltimoNodo(Nodo unNodo)
        {
            if (unNodo.Siguiente.Siguiente != null)
            {
                return BuscarAnteUltimoNodo(unNodo.Siguiente);
            }
            else
            {
                return unNodo;
            }
        }

    }
}
