using System;
using System.Collections.Generic;
using System.Text;

namespace _8_PuzzleGame
{
    class busquedaPrimeroAnchura
    {
        public List<States> busquedaprimeroAnchura(States root)
        {
            List<States> solucion = new List<States>();
            List<States> listaAbierta = new List<States>();
            List<States> listaCerrada = new List<States>();

            listaAbierta.Add(root);
            bool metaEncontrada = false;

            while(listaAbierta.Count > 0 && !metaEncontrada)
            {
                States estadoActual = listaAbierta[0];
                listaCerrada.Add(estadoActual);
                listaAbierta.RemoveAt(0);

                estadoActual.expandirMoves();

                for(int i = 0; i < estadoActual.hijos.Count; i++)
                {
                    States hijoActual = estadoActual.hijos[i];
                    if (hijoActual.metaAlcanzada())
                    {
                        Console.WriteLine("Meta Alcanzada");
                        metaEncontrada = true;
                        ruta(solucion, hijoActual);
                    }

                    if(!contiene(listaAbierta, hijoActual) && !contiene(listaCerrada, hijoActual))
                    {
                        listaAbierta.Add(hijoActual);
                    }
                }
            }

            return solucion;
        }

        public void ruta(List<States> ruta, States e)
        {
            Console.WriteLine("Ruta....");
            States actual = e;
            ruta.Add(actual);

            while(actual.parent != null)
            {
                actual = actual.parent;
                ruta.Add(actual);
            }
        }

        public bool contiene(List<States> lista, States e)
        {
            bool contiene = false;

            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i].mismoPuzzle(e.estadoInicialFacil))
                {
                    contiene = true;
                }
            }
            return contiene;
        }
    }
}
