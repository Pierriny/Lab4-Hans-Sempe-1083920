using System;
using System.Collections.Generic;
using System.Text;

namespace HEAP.ADT
{
    // P para sinbolizar Prioridad
    // V para simbolizar Valor
    public delegate int ComparadorPrioridadDelegate<P>(P p1, P p2);
    public delegate P CalcularNivelPrioridadDelegatez<P, V>(V value);

    // Interfaz del arbol HEAP
    interface IHEAP<P, V>
    {
        void Insertar(V item);

        void Eliminar();
    }
}
