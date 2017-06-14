using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrbolBinario
{
    class Nodo
    {
        public int _data { get; private set; }
        public Nodo _izquierda { get; set; }
        public Nodo _derecha { get; set; }

        public Nodo(int data)
        {
            this._data = data;
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }
}
