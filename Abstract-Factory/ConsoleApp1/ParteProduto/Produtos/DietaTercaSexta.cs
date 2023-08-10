using ConsoleApp1.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ParteProduto.Produtos
{
    public class DietaTercaSexta : IDieta
    {
        public DietaTercaSexta()
        {
            this.ObterAlimentacao();
        }
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de Terca Sexta feira ...");
        }
    }
}
