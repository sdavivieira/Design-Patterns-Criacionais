using ConsoleApp1.ParteCriacao.Interfaces;
using ConsoleApp1.ParteProduto.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ParteCriacao.Factories
{
    public class QuartaSabadoFactory : IFactory
    {
        public QuartaSabadoFactory()
        {
            this.ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factoy Quarta e Sábado");
            DietaQuartaSabado dieta= new DietaQuartaSabado();
            TreinoQuartaSabado treino = new TreinoQuartaSabado();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}
