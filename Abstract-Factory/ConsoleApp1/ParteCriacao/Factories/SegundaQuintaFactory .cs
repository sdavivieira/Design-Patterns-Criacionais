using ConsoleApp1.ParteCriacao.Interfaces;
using ConsoleApp1.ParteProduto.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ParteCriacao.Factories
{
    public class SegundaQuintaFactory : IFactory
    {
        public SegundaQuintaFactory()
        {
            this.ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Segunda e Quinta Criada");
            DietaSegundaQuinta dieta = new DietaSegundaQuinta();
            TreinoSegundaQuinta treino = new TreinoSegundaQuinta();

            dieta.ObterAlimentacao();
            treino.ObterTreino();

        }
    }
}
