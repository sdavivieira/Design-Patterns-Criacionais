using DesignPatterns.GoF.Creationals.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public void ContruirStudio(StudioBuilder studioBuilder)
        {
            studioBuilder.EscolherPiso();
            studioBuilder.DefinirValorStudio();
            studioBuilder.EscolherFinaciamento();
        }

        internal void ConstruirStudio(StudioBuilder studioBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
