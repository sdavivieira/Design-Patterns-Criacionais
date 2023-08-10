using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Client
    {
        public void ConsumirDB()
        {
            var instancia = ContextDB.Instancia;
            instancia.ExecutaQuery("SELECT * FROM NOME_TABELA;");
            
            instancia = ContextDB.Instancia;
            instancia.ExecutaQuery("INSERT INTO NOME_TABELA(valor) VALUES (0001);");

            instancia = ContextDB.Instancia;
            instancia.ExecutaQuery("UPDATE NOME_TABELA valor = 0002 WHERE id= 01;");

            instancia = ContextDB.Instancia;
            instancia.ExecutaQuery("DELETE NOME_TABELA WHERE Id = 01");
        }
    }
}
