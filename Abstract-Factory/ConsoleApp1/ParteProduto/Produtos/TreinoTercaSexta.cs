using ConsoleApp1.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ParteProduto.Produtos
{
    public class TreinoTercaSexta : Itreino
    {
        public TreinoTercaSexta()
        {
            this.ObterTreino();
        }
        public void ObterTreino()
        {
            Console.WriteLine("Treino de Terça e Sexta feita");
        }
    }
}
