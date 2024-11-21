using ListaEnlazada_Pila_Colas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEnlazada_Pila_Colas
{
    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
        }

        #region LISTA

        ListaEnlazada lista = new ListaEnlazada();

        //MOSTRAR EN PANTALLA
        public void AgregarListaEnlazada(Nodo unNodo)
        {
            if (unNodo != null)
            {
                lstBoxListaEnlazada.Items.Add(unNodo.Nombre);
                AgregarListaEnlazada(unNodo.Siguiente);
            }
        }


        public void MostrarLista()
        {
            lstBoxListaEnlazada.Items.Clear();
            AgregarListaEnlazada(lista.Inicio);
        }


        //EVENTOS


        //AGREGAR NODOS
        private void btnAgregarListaEnalazada_Click(object sender, EventArgs e)
        {
            if (txtBoxListaEnlazada.Text.Length > 0)
            {
                Nodo nuevoNodo = new Nodo();
                nuevoNodo.Nombre = txtBoxListaEnlazada.Text;
                lista.AgregarAlPrincipio(nuevoNodo);
                MostrarLista();
                txtBoxListaEnlazada.Clear();
                txtBoxListaEnlazada.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxListaEnlazada.Focus();
            }


        }

        private void btnAgregarAlFinal_Click(object sender, EventArgs e)
        {
            if (txtBoxListaEnlazada.Text.Length > 0)
            {
                Nodo nuevoNodo = new Nodo();
                nuevoNodo.Nombre = txtBoxListaEnlazada.Text;
                lista.AgregarAlFinal(nuevoNodo);
                MostrarLista();
                txtBoxListaEnlazada.Clear();
                txtBoxListaEnlazada.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxListaEnlazada.Focus();
            }
        }

        //ELIMINAR NODOS
        private void btnEliminarListaEnlazada_Click(object sender, EventArgs e)
        {
            if (lstBoxListaEnlazada.Items.Count == 0)
            {
                MessageBox.Show("No hay datos para eliminar", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxListaEnlazada.Focus();
            }
            else
            {
                lista.EliminarAlprincipio();
                MostrarLista();
                txtBoxListaEnlazada.Clear();
                txtBoxListaEnlazada.Focus();
            }

        }
        private void btnEliminarAlFinal_Click(object sender, EventArgs e)
        {
            if (lstBoxListaEnlazada.Items.Count == 0)
            {
                MessageBox.Show("No hay datos para eliminar", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxListaEnlazada.Focus();
            }
            else
            {
                lista.EliminarAlFinal();
                MostrarLista();
                txtBoxListaEnlazada.Clear();
                txtBoxListaEnlazada.Focus();
            }
        }

        #endregion

        #region PILA

        private Pila _Pila = new Pila();

        public void MostrarPila() 
        {
            if (_Pila != null) 
            {
                lstBoxPila.Items.Clear();
                foreach (Nodo nodo in _Pila.PilaNodo)
                {
                    lstBoxPila.Items.Add(nodo.Nombre);
                }
            }
        }


        private void btnAgregarPila_Click(object sender, EventArgs e)
        {
            if (txtBoxPila.Text.Length > 0) 
            {
                Nodo unNodo = new Nodo();
                unNodo.Nombre = txtBoxPila.Text;
                _Pila.Push(unNodo);
                MostrarPila();
                txtBoxPila.Clear();
                txtBoxPila.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPila.Focus();
            }



        }

        private void btnEliminarPila_Click(object sender, EventArgs e)
        {
            if (_Pila.Cantidad() > 0)
            {
                _Pila.Pop();
                MostrarPila();
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPila.Focus();
            }
        }
        #endregion

        #region COLA
        Cola Cola = new Cola();
        public void MostrarCola()
        {
            if (Cola != null)
            {
                lstBoxCola.Items.Clear();
                foreach (Nodo nodo in Cola.colaNodo)
                {
                    lstBoxCola.Items.Add(nodo.Nombre);
                }
            }
        }

        private void btnAgregarCola_Click(object sender, EventArgs e)
        {

            if (txtBoxCola.Text.Length > 0)
            {
                Nodo nuevoNodo = new Nodo();
                nuevoNodo.Nombre = txtBoxCola.Text;
                Cola.Encolar(nuevoNodo);
                MostrarCola();
                txtBoxCola.Clear();
                txtBoxCola.Focus();

            }
            else
            {
                MessageBox.Show("Ingrese un nombre", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxCola.Focus();
            }

        }

        private void btnEliminarCola_Click(object sender, EventArgs e)
        {
            if (Cola.Cantidad() > 0)
            {
                Cola.Desencolar();
                MostrarCola();
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxCola.Focus();
            }

        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
