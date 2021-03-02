using System;
using System.Collections.Generic;
using System.Text;

namespace _8_PuzzleGame
{
    class States
    {
        /*public static void Main()
        {
            int [] estadoInicialFacil = new int [9] { { 1, 2, 5 }, { 3, 4, 0 }, { 6, 7, 8 } };
            var estadoInicialMedio = new int[3, 3] { { 3, 2, 5 }, { 8, 0, 6 }, { 1, 4, 7 } };
            var estadoInicialDificil = new int[3, 3] { { 8, 1, 3 }, { 4, 0, 2 }, { 7, 6, 5 } };
        }*/

        public List<States> hijos = new List<States>();
        public States parent;
        public int[] estadoInicialFacil = new int[9];
        int x = 0;
        int col = 3;

        public States(int[] puzzle)
        {
            setPuzzle(puzzle);
        }

        public void expandirMoves()
        {
            for(int i = 0; i < estadoInicialFacil.Length; i++)
            {
                if(estadoInicialFacil[i] == 0)
                {
                    x = i;
                }

                movetoRight(estadoInicialFacil, x);
                movetoLeft(estadoInicialFacil, x);
                movetoUp(estadoInicialFacil, x);
                movetoDown(estadoInicialFacil, x);
            }
        }
        public void movetoRight(int [] p, int i)
        {
            if(i % col < col - 1)
            {
                int[] puzzle = new int [9];
                copiaPuzzle(puzzle, p);

                int temp = puzzle[i + 1];
                puzzle[i + 1] = puzzle[i];
                puzzle[i] = temp;

                States hijo = new States(puzzle);
                hijos.Add(hijo);
                hijo.parent = this;
            }
        }

        public void movetoLeft(int[] p, int i)
        {
            if (i % col > 0)
            {
                int[] puzzle = new int[9];
                copiaPuzzle(puzzle, p);

                int temp = puzzle[i - 1];
                puzzle[i - 1] = puzzle[i];
                puzzle[i] = temp;

                States hijo = new States(puzzle);
                hijos.Add(hijo);
                hijo.parent = this;
            }
        }
        public void movetoUp(int[] p, int i)
        {
            if (i - col >= 0)
            {
                int[] puzzle = new int[9];
                copiaPuzzle(puzzle, p);

                int temp = puzzle[i - 3];
                puzzle[i - 3] = puzzle[i];
                puzzle[i] = temp;

                States hijo = new States(puzzle);
                hijos.Add(hijo);
                hijo.parent = this;
            }
        }
        public void movetoDown(int[] p, int i)
        {
            if (i + col < estadoInicialFacil.Length)
            {
                int[] puzzle = new int[9];
                copiaPuzzle(puzzle, p);

                int temp = puzzle[i + 3];
                puzzle[i + 3] = puzzle[i];
                puzzle[i] = temp;

                States hijo = new States(puzzle);
                hijos.Add(hijo);
                hijo.parent = this;
            }
        }

        public void imprimirPuzzle()
        {
            Console.WriteLine();
            int meta = 0;
            for(int i = 0; i < col; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write(estadoInicialFacil[meta] + " ");
                    meta++;
                }
            }
        }

        public bool mismoPuzzle(int[] p)
        {
            bool mismoPuzzle = true;
            for(int i = 0; i < p.Length; i++)
            {
                if(estadoInicialFacil[i] != p[i])
                {
                    mismoPuzzle = false;
                }
            }
            return mismoPuzzle;
        }

        public void copiaPuzzle(int[] a, int[] b)
        {
            for(int i = 0; i < b.Length; i++)
            {
                a[i] = b[i];
            }
        }

        public void setPuzzle(int[] puzzle)
        {
            for(int i=0; i<estadoInicialFacil.Length; i++)
            {
                this.estadoInicialFacil[i] = puzzle[i];
            }
        }

        public bool metaAlcanzada()
        {
            bool esMeta = true;
            int meta = estadoInicialFacil[0];

            for(int i=0; i<estadoInicialFacil.Length; i++)
            {
                if(meta > estadoInicialFacil[i])
                {
                    esMeta = false;
                }
                meta = estadoInicialFacil[i];
            }
            return esMeta;
        }
    }
}
