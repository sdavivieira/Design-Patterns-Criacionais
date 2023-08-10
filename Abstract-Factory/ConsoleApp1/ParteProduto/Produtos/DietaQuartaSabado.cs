using ConsoleApp1.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ParteProduto.Produtos
{
    public class DietaQuartaSabado : IDieta
    {
            public DietaQuartaSabado ()
            {
                this.ObterAlimentacao();
            }
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de Quarta e Sabado ...");
        }
    }
}
