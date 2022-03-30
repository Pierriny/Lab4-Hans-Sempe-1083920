using System;
using System.Collections.Generic;
using System.Text;
using HEAP.ADT;

namespace HEAP.TreeStructure
{
    public class HEAPTree<P, V> : IHEAP<P, V>
    {
        private HEAPNode<P, V> Raiz { get; set; }

        private ComparadorPrioridadDelegate<P> compPrioridad;

        private CalcularNivelPrioridadDelegatez<P, V> calcPrioridad;

        private int count;
        
        // declara el arbol HEAP
        public HEAPTree(ComparadorPrioridadDelegate<P> comparar, CalcularNivelPrioridadDelegatez<P, V> calcular)
        {
            this.Raiz = null;
            compPrioridad = comparar;
            calcPrioridad = calcular;
        }

        // calcula la altura del arbol
        private int calcularAlturaT(HEAPNode<P, V> raiz)
        {
            if(raiz == null) { return 0; }
            else
            {
                int alturaIzq = calcularAlturaT(raiz.IZQ);
                int alturaDer = calcularAlturaT(raiz.DER);
                if (alturaIzq < alturaDer) { return (alturaDer + 1); }
                else { return (alturaIzq + 1); }
            }
        }

        // gurada el nivel del arbol
        private void Nivel(HEAPNode<P, V> raiz, int nivel, List<HEAPNode<P, V>> listaNodo)
        {
            if (raiz == null) { return; }
            if (nivel == 1) { listaNodo.Add(raiz); }
            else
            {
                Nivel(raiz.DER, nivel - 1, listaNodo);
                Nivel(raiz.IZQ, nivel - 1, listaNodo);       
            }
        }

        // define la lista de nodos del arbol
        public List<HEAPNode<P, V>> treeToList()
        {
            int altura = calcularAlturaT(this.Raiz);
            List<HEAPNode<P, V>> ListaNodos = new List<HEAPNode<P, V>>();
            for(int i = 0; i < altura; i++){
                Nivel(this.Raiz, i, ListaNodos);
            }
            return ListaNodos;
        }

        // realiza el intercambio de posicion entre el nodo padre e hijo 
        public void SWAP (ref HEAPNode<P, V> padre, ref HEAPNode<P, V> hijo)
        {
            P padrePrio = padre.Prioridad;
            V padreValor = padre.Valor;

            padre.Prioridad = hijo.Prioridad;
            padre.Valor = hijo.Valor;

            hijo.Prioridad = padrePrio;
            hijo.Valor = padreValor;
        }

        // declara el nivel de prioridad de cada nodo del arbol HEAP
        public void priorizarHEAP(HEAPNode<P, V> raiz)
        {
            if (raiz.IZQ == null)
            {
                this.Raiz = raiz;
                return;
            }
            else
            {
                if (raiz.DER == null)
                {
                    raiz = CheckSwapDelete(raiz, raiz.IZQ);
                    priorizarHEAP(raiz.DER);
                }
                else
                {
                    if (compPrioridad(raiz.IZQ.Prioridad, raiz.DER.Prioridad) > 0)
                    {
                        raiz = CheckSwapDelete(raiz, raiz.IZQ);
                        priorizarHEAP(raiz.IZQ);
                    }
                    else
                    {
                        raiz = CheckSwapDelete(raiz, raiz.DER);
                        priorizarHEAP(raiz.DER);
                    }
                }
            }
        }

        // metodo de eliminacion
        public void Eliminar()
        {
            HEAPNode<P, V> raiz = this.Raiz;
            bool izq = true;
            String binaryCount = Convert.ToString(count + 1, 2);

            for (int i = 1; i < binaryCount.Length; i++)
            {
                if (binaryCount[i] == '0') { raiz = raiz.IZQ; }
                else
                {
                    raiz = raiz.DER;
                    izq = false;
                }
            }
            this.Raiz.Prioridad = raiz.Prioridad;
            this.Raiz.Valor = raiz.Valor;
            if (izq) { raiz.PADRE.IZQ = null; }
            else { raiz.PADRE.PADRE.DER = null; }
            priorizarHEAP(this.Raiz);
        }

        // inserta el nivel de prioridad
        public HEAPNode<P, V> InsertarPrioridad(HEAPNode<P, V> raiz, V item)
        {
            if (raiz == null)
            {
                raiz = new HEAPNode<P, V>(calcPrioridad(item), item);
                count++;
            }
            else
            {
                String binaryCount = Convert.ToString(count + 1, 2);
                bool izq = true;
                for (int i = 1; i < binaryCount.Length; i++)
                {
                    if (binaryCount[i] == '0')
                    {
                        if (raiz.IZQ == null)
                        {
                            raiz.IZQ = InsertarPrioridad(raiz.IZQ, item);
                            raiz.IZQ.PADRE = raiz;
                        }
                        raiz = raiz.IZQ;
                    }
                    else
                    {
                        if (raiz.DER == null)
                        {
                            raiz.DER = InsertarPrioridad(raiz.DER, item);
                            raiz.DER.PADRE = raiz;
                        }
                        raiz = raiz.DER;
                    }
                }
                if (izq) { raiz = CheckSwapDelete(raiz, raiz.IZQ); }
                else { raiz = CheckSwapDelete(raiz, raiz.DER); }
                count++;
            }

            return raiz;
        }

        // inserta un valor al arbol
        public void Insertar(V item) { this.Raiz = InsertarPrioridad(this.Raiz, item); }

        // chequea si es posible hacer una eliminacion en el swap
        public HEAPNode<P, V> CheckSwapDelete(HEAPNode<P, V> padre, HEAPNode<P, V> hijo)
        {
            if (compPrioridad(padre.Prioridad, hijo.Prioridad) < 0) { SWAP(ref padre, ref hijo); }
            return padre;
        }

        // chequea si es posible hacer una insercion en el swap
        public HEAPNode<P, V> CheckSwapInsert(HEAPNode<P, V> padre, HEAPNode<P, V> hijo)
        {
            if(padre.PADRE != null)
            {
                if (compPrioridad(padre.Prioridad, hijo.Prioridad) < 0)
                {
                    SWAP(ref padre, ref hijo);
                    CheckSwapInsert(padre.PADRE, padre);
                }
            }
            return padre;
        }
    }
}
