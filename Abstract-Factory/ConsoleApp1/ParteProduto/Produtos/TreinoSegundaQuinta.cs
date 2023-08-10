using ConsoleApp1.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ParteProduto.Produtos
{
    public class TreinoSegundaQuinta : Itreino
    {
        public TreinoSegundaQuinta()
        {
            this.ObterTreino();
        }
        public void ObterTreino()
        {
            Console.WriteLine("Treino de Segunda e Quinta feira");
        }
    }
}
