using System;
using System.Collections.Generic;
using System.Text;

namespace HEAP.TreeStructure
{
    public class HEAPNode<P, V>
    {
        public P Prioridad { get; set; }

        public V Valor { get; set; }

        public HEAPNode<P, V> Left { get; set; }

        public HEAPNode<P, V> Right { get; set; }

        public HEAPNode<P, V> Parent { get; set; }

        public HEAPNode(P prioridad, V valor)
        {
            this.Prioridad = prioridad;
            this.Valor = valor;
            this.Left = null;
            this.Right = null;
            this.Parent = null;
        }

    }
    
}
