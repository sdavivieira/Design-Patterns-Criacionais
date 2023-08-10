using ConsoleApp1.ParteCriacao.Interfaces;
using ConsoleApp1.ParteProduto.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ParteCriacao.Factories
{
    public class TercaSextaFactory : IFactory
    {
        public TercaSextaFactory()
        {
            this.ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory de Terça e Sexta");
            DietaTercaSexta dieta = new DietaTercaSexta();
            TreinoTercaSexta treino = new TreinoTercaSexta();
            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}
