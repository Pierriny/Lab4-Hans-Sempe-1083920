using System;
using System.Collections.Generic;
using System.Text;

namespace HEAP.TreeStructure
{
    public class HEAPNode<P, V>
    {
        public P Prioridad { get; set; }

        public V Valor { get; set; }

        public HEAPNode<P, V> IZQ { get; set; }

        public HEAPNode<P, V> DER { get; set; }

        public HEAPNode<P, V> PADRE { get; set; }

        public HEAPNode(P prioridad, V valor)
        {
            this.Prioridad = prioridad;
            this.Valor = valor;
            this.IZQ = null;
            this.DER = null;
            this.PADRE = null;
        }

    }
    
}
