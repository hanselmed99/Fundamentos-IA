using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Busqueda
    {
        public Nodo busquedaPrimeroAnchura(Grafo g, Nodo root, string objetivo)
        {
            Queue<Nodo> cola = new Queue<Nodo>();
            List<Nodo> nodosVisitados = new List<Nodo>();
            nodosVisitados.Add(root);
            cola.Enqueue(root);
            while(cola.Count > 0)
            {
                Nodo v = cola.Dequeue();
                if(v.nombre.Equals(objetivo))
                {
                    return v;
                }
                foreach(var w in g.obtenerNodosAdyacentes(v))
                {
                    if (!nodosVisitados.Contains(w))
                    {
                        nodosVisitados.Add(w);
                        cola.Enqueue(w);
                    }
                }
            }

            return null;
        }

        public Nodo busquedaProfundidad(Grafo g, Nodo root, string objetivo)
        {
            Stack<Nodo> cola = new Stack<Nodo>();
            List<Nodo> nodosVisitados = new List<Nodo>();
            nodosVisitados.Add(root);
            cola.Push(root);
            while (cola.Count > 0)
            {
                Nodo v = cola.Pop();
                if (v.nombre.Equals(objetivo))
                {
                    return v;
                }
                foreach (var w in g.obtenerNodosAdyacentes(v))
                {
                    if (!nodosVisitados.Contains(w))
                    {
                        nodosVisitados.Add(w);
                        cola.Push(w);
                    }
                }
            }

            return null;
        }
    }
}
