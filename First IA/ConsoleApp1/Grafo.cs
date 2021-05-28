using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Grafo
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
