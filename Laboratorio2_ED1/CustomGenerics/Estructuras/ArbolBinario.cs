using System;
using System.Collections.Generic;
using System.Text;
using CustomGenerics.Interfaces;

namespace CustomGenerics.Estructuras
{
    class ArbolBinario<T> : NonLinearDataStructureBase<T> where T : IComparable<T>
    {
        private Nodo<T> Raiz = new Nodo<T>();
        private Nodo<T> temp = new Nodo<T>();
        private List<T> listaOrdenada = new List<T>();

        protected override Nodo<T> Insert(Nodo<T> nodo, T value)
        {
            throw new System.InvalidOperationException("Pa mientras");
        }
        protected override void Delete(Nodo<T> nodo)
        {

        }

        protected override Nodo<T> Get(Nodo<T> nodo, T value)
        {
            throw new System.InvalidOperationException("Pa mientras");
        }
    }
}
