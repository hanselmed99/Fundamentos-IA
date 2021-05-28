using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol_binarioBusqueda
{
    class Nodo
    {
        public Nodo hijoIzq;
        public Nodo hijoDer;
        public int valor;

        public Nodo()
        {
            hijoIzq = null;
            hijoDer = null;
            valor = 0;
        }
    }
}
