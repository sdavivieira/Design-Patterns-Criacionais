using CursoDesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.FactoryMethod.Servicos
{
    public class CoberturaServico : IServico
    {
            public CoberturaServico ()
            {
            Console.WriteLine("Produto Cobertura, criado com sucesso!");
            }

        public void ExecuteCobrancaServico()
        {
            //Logica de cobrança de serviço para a cobertura
        }
    }
}
