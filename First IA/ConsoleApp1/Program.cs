using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Nodo, List<Nodo>> nodos = new Dictionary<Nodo, List<Nodo>>();
            // Dar de altas todos los nodos

            /*Nodo nA = new Nodo("a");
            Nodo nB = new Nodo("b");
            Nodo nC = new Nodo("c");
            Nodo nD = new Nodo("c");
            Nodo nE = new Nodo("e");
            Nodo nF = new Nodo("f");
            Nodo nG = new Nodo("g");
            Nodo nH = new Nodo("h");

            List<Nodo> lista = new List<Nodo>();
            nodos.Add(nA, new List<Nodo>() { nB, nC });
            nodos.Add(nB, new List<Nodo>() { nD, nE, nA });
            nodos.Add(nC, new List<Nodo>() { nF, nG, nA });
            nodos.Add(nD, new List<Nodo>() { nB });
            nodos.Add(nE, new List<Nodo>() { nH, nB });
            nodos.Add(nF, new List<Nodo>() { nC });
            nodos.Add(nG, new List<Nodo>() { nC });
            nodos.Add(nH, new List<Nodo>() { nE });*/

            Nodo nA = new Nodo("a");
            Nodo nB = new Nodo("b");
            Nodo nC = new Nodo("c");
            Nodo nD = new Nodo("c");
            Nodo nE = new Nodo("e");
            Nodo nF = new Nodo("f");
            Nodo nG = new Nodo("g");
            Nodo nH = new Nodo("h");
            Nodo nI = new Nodo("i");
            Nodo nJ = new Nodo("j");
            Nodo nK = new Nodo("k");
            Nodo nL = new Nodo("l");
            Nodo nM = new Nodo("m");
            Nodo nN = new Nodo("n");
            Nodo nO = new Nodo("o");

            List<Nodo> lista = new List<Nodo>();
            nodos.Add(nA, new List<Nodo>() { nB, nC });
            nodos.Add(nB, new List<Nodo>() { nD, nE, nA });
            nodos.Add(nC, new List<Nodo>() { nF, nG, nA });
            nodos.Add(nD, new List<Nodo>() { nH, nI, nB });
            nodos.Add(nE, new List<Nodo>() { nJ, nK, nB });
            nodos.Add(nF, new List<Nodo>() { nL, nM, nC });
            nodos.Add(nG, new List<Nodo>() { nN, nO, nC });
            nodos.Add(nH, new List<Nodo>() { nD });
            nodos.Add(nI, new List<Nodo>() { nD });
            nodos.Add(nJ, new List<Nodo>() { nE });
            nodos.Add(nK, new List<Nodo>() { nE });
            nodos.Add(nL, new List<Nodo>() { nF });
            nodos.Add(nM, new List<Nodo>() { nF });
            nodos.Add(nN, new List<Nodo>() { nG });
            nodos.Add(nO, new List<Nodo>() { nG });


            Grafo grafo = new Grafo(nodos);

            Busqueda busqueda = new Busqueda();
            Nodo nodo = busqueda.busquedaProfundidad(grafo, nA, "e");
            // Si es nulo ==> no lo encontro
            Console.WriteLine("Nodo: " + (nodo != null ? nodo.nombre: "No encontrado"));
            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}
