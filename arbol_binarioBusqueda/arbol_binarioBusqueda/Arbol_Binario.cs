using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol_binarioBusqueda
{
    class Arbol_Binario
    {
        public Nodo raiz;

        public Arbol_Binario()
        {
            raiz = null;
        }

        public void insertar(int valor)
        {
            if(raiz == null)
            {
                raiz = new Nodo();
                raiz.valor = valor;
            }
            else
            {
                Nodo nuevo = new Nodo();
                nuevo.valor = valor;
                nuevo.hijoDer = null;
                nuevo.hijoIzq = null;

                Nodo anterior = null, recorrer;
                recorrer = raiz;
                while(recorrer != null)
                {
                    anterior = recorrer;
                    if (valor < recorrer.valor)
                    {
                        recorrer = recorrer.hijoDer;
                    }
                    else
                    {
                        recorrer = recorrer.hijoIzq;
                    }
                }
                if(valor < anterior.valor)
                {
                    anterior.hijoDer = nuevo;
                }
                else
                {
                    anterior.hijoIzq = nuevo;
                }
            }
        }

        public void preOrden(Nodo raiz)
        {
            Console.WriteLine(raiz.valor);
            if(raiz.hijoIzq != null)
            {
                preOrden(raiz.hijoIzq);
            }
            if(raiz.hijoDer != null)
            {
                preOrden(raiz.hijoDer);
            }
        }

        public void enOrden(Nodo raiz)
        {
            if(raiz.hijoIzq != null)
            {
                enOrden(raiz.hijoIzq);
            }
            Console.WriteLine(raiz.valor);
            if(raiz.hijoDer != null)
            {
                enOrden(raiz.hijoDer);
            }
        }

        public void postOrden(Nodo raiz)
        {
            if(raiz.hijoIzq != null)
            {
                postOrden(raiz.hijoIzq);
            }
            if(raiz.hijoDer != null)
            {
                postOrden(raiz.hijoDer);
            }
            Console.WriteLine(raiz.valor);
        }
    }
}
