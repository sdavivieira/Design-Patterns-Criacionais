﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Creationals.Builder.Studios
{
    public class Studio26m : Studio
    {
        public override void DefinirValorStudio(decimal valor)
        {
            ValorStudio = valor;
        }

        public override void EscolherFinaciamento(string financiamento)
        {
            TipoFinaciamento = financiamento;
        }

        public override void EscolherPiso(string piso)
        {
            TipoPiso = piso;
        }
    }
}
