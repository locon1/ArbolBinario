using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrbolBinario
{
    class Arbol
    {
        public Nodo Padre;

        public void add(Nodo nuevo)
        {
            if (Padre == null)
                Padre = nuevo;
            else
                add(nuevo, Padre);
        }

        private void add(Nodo nuevo, Nodo actual)
        {
            if (nuevo._data != actual._data) 
            {
                if (nuevo._data < actual._data)
                {
                    if (actual._izquierda == null)
                        actual._izquierda = nuevo;
                    else
                        add(nuevo, actual._izquierda);
                }
                else
                {
                    if (actual._derecha == null)
                        actual._derecha = nuevo;
                    else
                        add(nuevo, actual._derecha);
                }
            }
        }

        public Nodo buscar(int nuevo)
        {
            if (Padre == null)
                return Padre;
            else
                return busqueda(nuevo, Padre);
        }

        private Nodo busqueda(int nuevo, Nodo ultimo)
        {
            if (nuevo == ultimo._data)
                return ultimo;
            else if (nuevo < ultimo._data && ultimo._izquierda != null) 
                return busqueda(nuevo, ultimo._izquierda);
            else if (ultimo._derecha != null)
                return busqueda(nuevo, ultimo._derecha);

            return null;
        }

        public string preOrden()
        {
            if (Padre == null) {
                return "Árbol vacio.";
            }
            else {
                return preOrden(Padre);
            }
        }

        private string preOrden(Nodo actual)
        {
            String salida = "";

            salida += actual._data.ToString() + Environment.NewLine;

            if (actual._izquierda != null)
                salida += preOrden(actual._izquierda);

            if (actual._derecha != null)
                salida += preOrden(actual._derecha);

            return salida;
        }

        public string inOrden()
        {
            if (Padre == null)
                return "Árbol vacio.";
            else
                return inOrden(Padre);
        }

        private string inOrden(Nodo actual)
        {
            string salida = "";

            if(actual._izquierda != null)
                salida += inOrden(actual._izquierda);

            salida += actual._data.ToString() + Environment.NewLine;

            if(actual._derecha != null)
                salida += inOrden(actual._derecha);

            return salida;
        }

        public string postOrden()
        {
            if (Padre == null)
                return "Árbol vacio.";
            else
                return postOrden(Padre);
        }

        private string postOrden(Nodo actual)
        {
            string salida = "";

            if (actual._izquierda != null)
                salida += postOrden(actual._izquierda);

            if (actual._derecha != null)
                salida += postOrden(actual._derecha);

            salida += actual._data.ToString() + Environment.NewLine;

            return salida;
        }
    }
}
