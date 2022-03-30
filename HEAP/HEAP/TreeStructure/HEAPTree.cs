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
            if(raiz == null)
            {
                return 0;
            }
            else
            {
                int alturaIzq = calcularAlturaT(raiz.Left);
                int alturaDer = calcularAlturaT(raiz.Right);
                if (alturaIzq > alturaDer){ return (alturaIzq + 1); }
                else { return (alturaDer + 1); }
            }
        }

        // gurada el nivel del arbol
        private void Nivel(HEAPNode<P, V> raiz, int nivel, List<HEAPNode<P, V>> listaNodo)
        {
            if (raiz == null) { return; }
            if (nivel == 1) { listaNodo.Add(raiz); }
            else
            {
                Nivel(raiz.Left, nivel - 1, listaNodo);
                Nivel(raiz.Right, nivel - 1, listaNodo);
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

        public HEAPNode<P, V> CheckSwapDelete(HEAPNode<P, V> padre,HEAPNode<P, V> hijo)
        {
            if (compPrioridad(padre.Prioridad, hijo.Prioridad) < 0) { SWAP(ref padre, ref hijo); }
            return padre;
        }

        // declara el nivel de prioridad de cada nodo del arbol HEAP
        public void priorizarHEAP(HEAPNode<P, V> raiz)
        {
            if (raiz.Left == null)
            {
                this.Raiz = raiz;
                return;
            }
            else
            {
                if (raiz.Right == null)
                {
                    raiz = CheckSwapDelete(raiz, raiz.Left);
                    priorizarHEAP(raiz.Left);
                }
                else
                {
                    if (compPrioridad(raiz.Left.Prioridad, raiz.Right.Prioridad) > 0)
                    {
                        raiz = CheckSwapDelete(raiz, raiz.Left);
                        priorizarHEAP(raiz.Left);
                    }
                    else
                    {
                        raiz = CheckSwapDelete(raiz, raiz.Right);
                        priorizarHEAP(raiz.Right);
                    }
                }
            }
        }

        // metodo de eliminacion
        public void Eliminar()
        {
            HEAPNode<P, V> raiz = this.Raiz;
            bool Left = true;
            String binaryCount = Convert.ToString(count + 1, 2);

            for (int i = 1; i < binaryCount.Length; i++)
            {
                if (binaryCount[i] == '0') { raiz = raiz.Left; }
                else
                {
                    raiz = raiz.Right;
                    Left = false;
                }
            }
            this.Raiz.Prioridad = raiz.Prioridad;
            this.Raiz.Valor = raiz.Valor;
            if (Left) { raiz.Parent.Left = null; }
            else { raiz.Parent.Parent.Right = null; }
            priorizarHEAP(this.Raiz);
        }

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
                bool Left = true;
                for (int i = 1; i < binaryCount.Length; i++)
                {
                    if (binaryCount[i] == '0')
                    {
                        if (raiz.Left == null)
                        {
                            raiz.Left = InsertarPrioridad(raiz.Left, item);
                            raiz.Left.Parent = raiz;
                        }
                        raiz = raiz.Left;
                    }
                    else
                    {
                        if (raiz.Right == null)
                        {
                            raiz.Right = InsertarPrioridad(raiz.Right, item);
                            raiz.Right.Parent = raiz;
                        }
                        raiz = raiz.Right;
                    }
                }
                if (Left) { raiz = CheckSwapDelete(raiz, raiz.Left); }
                else { raiz = CheckSwapDelete(raiz, raiz.Right); }
                count++;
            }

            return raiz;
        }

        // inserta un valor al arbol
        public void Insertar(V item) { this.Raiz = InsertarPrioridad(this.Raiz, item); }

        public HEAPNode<P, V> CheckSwapInsert(HEAPNode<P, V> padre, HEAPNode<P, V> hijo)
        {
            if(padre.Parent != null)
            {
                if (compPrioridad(padre.Prioridad, hijo.Prioridad) < 0)
                {
                    SWAP(ref padre, ref hijo);
                    CheckSwapInsert(padre.Parent, padre);
                }
            }
            return padre;
        }
    }
}
