using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÁrbolBinario
{
    public partial class Form1 : Form
    {
        Arbol arbol = new Arbol();
        Nodo nuevo;
        Nodo encontrado;
        int buscado;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            txtLista.Clear();
            try
            {
                buscado = Convert.ToInt32(txtSearch.Text);
                encontrado = arbol.buscar(buscado);

                if (encontrado == null || encontrado._data != buscado)
                    txtLista.Text = "El nodo que busca no existe.";
                else
                    txtLista.Text = "Encontrado: " + encontrado.ToString();
            }
            catch
            {
                txtLista.Text = "Ingrese un valor por favor.";
            }

            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            txtLista.Clear();
            try 
            {
                nuevo = new Nodo(Convert.ToInt32(txtNum.Text));
                arbol.add(nuevo);
            }
            catch
            {
                txtLista.Text = "Ingrese un valor por favor.";
            }

            txtNum.Clear();
            txtNum.Focus();
        }

        private void cmdPre_Click(object sender, EventArgs e)
        {
            txtLista.Clear();
            txtLista.Text = arbol.preOrden();
        }

        private void cmdIn_Click(object sender, EventArgs e)
        {
            txtLista.Clear();
            txtLista.Text = arbol.inOrden();
        }

        private void cmdPost_Click(object sender, EventArgs e)
        {
            txtLista.Clear();
            txtLista.Text = arbol.postOrden();
        }
    }
}
