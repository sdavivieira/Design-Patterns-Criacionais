﻿using ConsoleApp1.ParteCriacao.Factories;
using ConsoleApp1.ParteCriacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Client
    {
        public void ConsultarRotinaALuno()
        {
            var continuar = true;

            while (continuar) { 
            
                IFactory factory = null;


                Console.WriteLine("Selecione a rotina desejada: ");
                Console.WriteLine("1 - Segunda e Quinta: ");
                Console.WriteLine("2 - Terça  e Sexta: ");
                Console.WriteLine("3 - Quarta e Sábado: ");

                Console.Write("Seleciona a rotina desejada: ");
                string opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                        factory = new SegundaQuintaFactory();
                        break;
                        case "2":
                        factory = new TercaSextaFactory();
                        break;
                        case "3":
                        factory = new QuartaSabadoFactory();
                        break;  
                    default:
                        break;
                }
                Console.WriteLine("Deseja ver outra rotina? (1 - Sim ou 2 - Nâo ");
                var resp = Convert.ToInt32(Console.ReadLine());
                continuar = resp == 1;
     
            
            }

        }
    }
}
