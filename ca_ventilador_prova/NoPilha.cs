using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_ventilador_prova
{
    internal class NoPilha
    {
        //atributos
        private string info;
        private NoPilha next;

        //getters e setters
        public string Info { get => info; set => info = value; }
        internal NoPilha Next { get => next; set => next = value; }

        //Construtor
        public NoPilha(string _info)
        {
            info = _info;
            next = null;
        }

      
    }
}
