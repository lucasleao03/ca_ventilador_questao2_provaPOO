using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_ventilador_prova
{
    internal class Pilha
    {
        //atributos
        private NoPilha topo;

        //getter e setter
        internal NoPilha Topo { get => topo; set => topo = value; }

        //contrutor
        public Pilha()
        {
            topo = null;
        }

        //métodos
        public bool IsEmpty()
        {
            if (topo == null) return true;
            else return false;
        }

        public void push(string peca)
        {
            NoPilha novo_no = new NoPilha(peca);
            if(IsEmpty())
            {
                topo = novo_no;
            }

            else
            {
                novo_no.Next = topo;
                topo = novo_no;
            }
        }

        public string pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("A pilha está vazia!");
                return null;
            }

            else
            {
                string temp = topo.Info;
                topo = topo.Next;
                return temp;
            }
        }

        public void imprime()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Pilha vazia!");
            }

            else
            {
                NoPilha temp = topo;
                while(temp != null)
                {
                    Console.WriteLine(temp.Info);
                    temp = temp.Next;
                }
            }
        }

        public void troca_peca(string peca_velha, string peca_nova)
        {
            Pilha aux = new Pilha();
            NoPilha temp1 = this.topo;
            while(temp1 != null)
            {
                if(temp1.Info == peca_velha)
                {
                    this.pop();
                    this.push(peca_nova);
                    break;
                }

                else
                {
                    aux.push(temp1.Info);
                    this.pop();
                }

                temp1 = temp1.Next;
            }

            NoPilha temp2 = aux.topo;
            while(temp2 != null)
            {
                this.push(temp2.Info);
                aux.pop();
                temp2 = temp2.Next;
            }
        }
    }
}
