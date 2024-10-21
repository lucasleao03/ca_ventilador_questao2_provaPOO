using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_ventilador_prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha pecas = new Pilha();
            pecas.push("Cúpula de Vidro");
            pecas.push("Lâmpada");
            pecas.push("Hélice Quebrada");
            pecas.push("Hélice");
            pecas.push("Suporte");

            pecas.imprime();
            Console.ReadLine();

            pecas.troca_peca("Hélice Quebrada", "Hélice Nova");
            pecas.imprime();
            Console.ReadLine();


        }
    }
}
