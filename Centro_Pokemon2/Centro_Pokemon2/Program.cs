using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace Centro_Pokemon2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 6)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(@"

██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║
██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║
██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝");
                Console.ResetColor();
                Console.WriteLine("\n 1 - Cadastro de Pokemon");
                Console.WriteLine("\n 2 - Cadastro de Pokebola:");
                Console.WriteLine("\n 3 - Cadastro de Treinador:");
                Console.WriteLine("\n 4 - Cadastro de Cidade:");
                Console.WriteLine("\n 5 - Cadastro de Ginásio:");
                Console.WriteLine("\n 6 - Sair:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\n Digite a opcao escolhida: ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        cadastroPokemon();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n Opcao Invalida!");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;




                }
            }
        }

        static void cadastroPokemon()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");
            Console.ResetColor();
            Console.WriteLine("\n o nome do Pokemon: ");
            string nome = Console.ReadLine();
            Console.WriteLine("\n status do Pokemon: ");
            string statusPokemon = Console.ReadLine();
            Console.WriteLine("\n qtd de Golpes do pokemon: ");
            int qtdGolpes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdGolpes; i++)
            {

                Console.WriteLine($"\n golpe do {i} pokemon: ");
                string golpePokemon = Console.ReadLine();
            }
            Console.WriteLine("\nQuantas evoluções: ");
            int qtdevoluções = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdevoluções; i++)

            {

                Console.WriteLine($"\nEvoluções {i} do Pokemon");
                string evolucaoPokemon = Console.ReadLine();

            }

            Console.WriteLine("\nQual elemento: ");
            string elementoPokemon = Console.ReadLine();
            Console.WriteLine("\n Quantas fraquezas");
            int qtdfraquezas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdfraquezas; i++)

            {

                Console.WriteLine($"\nFraquezas {i} do Pokemon?");
                string fraquezasPokemon = Console.ReadLine();

            }

            Console.WriteLine("\nRaridade do Pokemon");
            string raridadePokemon = Console.ReadLine();
            Console.WriteLine("\nPeso do Pokemon");
            double pesoPokemon = double.Parse(Console.ReadLine());
            Console.WriteLine("\nPokemon Adicionado com sucesso");
            Thread.Sleep(2000);


        }

    }

}


        







    
 

