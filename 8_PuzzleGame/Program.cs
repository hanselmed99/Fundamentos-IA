using System;
using System.Collections.Generic;

namespace _8_PuzzleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] estadoInicialFacil = 
            { 
                1, 2, 5, 
                3, 4, 0, 
                6, 7, 8
            };

            States initSatate = new States(estadoInicialFacil);
            busquedaPrimeroAnchura bfs = new busquedaPrimeroAnchura();

            List<States> solucion = bfs.busquedaprimeroAnchura(initSatate);

            if(solucion.Count > 0)
            {
                solucion.Reverse();
                for(int i = 0; i <solucion.Count; i++)
                {
                    solucion[i].imprimirPuzzle();
                }
            }
            else
            {
                Console.WriteLine("No se encontro la solucion");
            }
            Console.Read();
        }

    }
}
