using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Grafo
    {
        Dictionary<Nodo, List<Nodo>> nodos { get; }
        
        public List<Nodo> obtenerNodosAdyacentes(Nodo llave)
        {
            return nodos[llave];
        }

        public Grafo(Dictionary<Nodo, List<Nodo>> nodos)
        {
            this.nodos = nodos;
        }
    }
}
