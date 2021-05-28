using System;
using System.Collections.Generic;

namespace _8_PuzzleGame
{
    class Program
    {
        //Proyecto Unidad 1: 8-Puzzles
        /*
         * Integrantes:
         * Medina Salas Hanselts Alejandro  
         * Quevedo Castro Fernando
         * */
        static void Main(string[] args)
        {
            int[] estadoInicialFacil =
            {
                1, 2, 5,
                3, 4, 0,
                6, 7, 8
            };
            States nodofacil = new States(estadoInicialFacil);
            int[,] objetivo = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };
            States nodoobjetivo = new States(objetivo);

            int[,] medio = new int[3, 3] { { 1, 3, 2 }, { 4, 5, 3 }, { 7, 8, 0 } };
            States nodomedio = new States(medio);

            States initSatate = new States(estadoInicialFacil);
            busquedas bfs = new busquedas();

            List<States> solucion = bfs.busquedaprimeroAnchura(initSatate);

            Busquedas Anchura = new Busquedas();
            Console.WriteLine("->Busqueda De Anchura<-");
            Anchura.BusquedadeAnchura(nodofacil, nodoobjetivo);
            Console.WriteLine("\n");
            Console.WriteLine("->Busqueda De Profundidad<-");
            Anchura.BusquedadeProfundidad(nodofacil, nodoobjetivo);
            List<States> result = new List<States>();
            Console.WriteLine("\n");
            Console.WriteLine("->Busqueda A*<-");
            Anchura.BusquedaAEstrella(nodofacil, nodoobjetivo);
            Console.ReadKey();

            /*if (solucion.Count > 0)
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
            Console.Read();*/
        }

    }
}
