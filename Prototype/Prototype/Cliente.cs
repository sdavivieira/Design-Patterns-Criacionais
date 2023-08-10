using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Cliente
    {
        public void Consumir()
        {
            GerenciadorVendasStudio gerenciador = new GerenciadorVendasStudio();

            gerenciador["24M"] = new Studio("24m^2", "FInalEmpreendimentos", 18000.00M);
            gerenciador["26M"] = new Studio("26m^2", "Financiamentos Imóveis Aurora", 19000.00M);
            gerenciador["28M"] = new Studio("28m^2", "Financiamentos Imóveis Tabajara", 20000.00M);

            StudioModel firstCLone01 = gerenciador["24m"].Clone();
            StudioModel firstCLone02 = gerenciador["24m"].Clone();
            StudioModel studio26 = gerenciador["26m"].Clone();
            StudioModel studio28 = gerenciador["28m"].Clone();
        }

    
    }
}
