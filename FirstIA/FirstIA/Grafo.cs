using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstIA
{
    class Grafo
    {
        Dictionary<Nodo, List<Nodo>> nodos;

        public Grafo(Dictionary<Nodo, List<Nodo>> nodos)
        {
            this.nodos = nodos;
        }

        public List<Nodo> obtenerNodosAdyacentes(Nodo llave)
        {
            return nodos[llave];
        }
    }
}
