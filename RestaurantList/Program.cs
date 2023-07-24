using System;
using System.Collections.Generic;

namespace RestaurantList
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Qual tipo de culinária você quer comer?\n - italiana \n - japonesa \n - brasileira \n Sua resposta: ");
                string culinaria = Console.ReadLine();
                var (bons, ruins) = BuscaRestaurantes(culinaria);

                if (bons.Count > 0 || ruins.Count > 0)
                {
                    Console.WriteLine("\nRestaurantes indicados:");
                    foreach (string restaurante in bons)
                    {
                        Console.WriteLine(restaurante);
                    }

                    Console.WriteLine("\nRestaurantes não indicados:");
                    foreach (string restaurante in ruins)
                    {
                        Console.WriteLine(restaurante);
                    }
                }
                else
                {
                    Console.WriteLine("Não foram encontrados restaurantes para essa culinária.\n");
                }

                Console.Write("\nDeseja ver outra culinária? (sim/não)");
                string resposta = Console.ReadLine().ToLower();
                while (resposta != "sim" && resposta != "Sim" && resposta != "SIM" && resposta != "não" && resposta != "nao" && resposta != "Não" && resposta != "Nao" && resposta != "NÃO" && resposta != "NAO")
                {
                    Console.WriteLine("Resposta inválida. Por favor, digite 'sim' ou 'não'.");
                    Console.Write("Deseja ver outra culinária? (sim/não) ");
                    resposta = Console.ReadLine().ToLower();
                }

                if (resposta == "não" || resposta == "nao" || resposta == "Não" || resposta == "Nao" || resposta == "NÃO" || resposta == "NAO")
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }
            }
        }

        static (List<string> bons, List<string> ruins) BuscaRestaurantes(string culinaria)
        {
            List<string> bons = new List<string>();
            List<string> ruins = new List<string>();

            // Exemplo de busca por restaurantes bons e ruins da culinária
            if (culinaria == "italiana")
            {
                bons = new List<string> { "Picchi Restaurante ", "Borgo Mooca", "Shihoma Pasta Fresca" };
                ruins = new List<string> { "Terraço Itália", "Tatini Restaurante" };
            }
            else if (culinaria == "japonesa")
            {
                bons = new List<string> { "Jojo Ramen", "Sushi Kenzo", "Izakaya Matsu" };
                ruins = new List<string> { "Oue Sushi", "Natory Sushi" };
            }
            else if (culinaria == "brasileira")
            {
                bons = new List<string> { "Casa Rios", "Bar do Luiz Fernandes", "Tordesilhas" };
                ruins = new List<string> { "Chico Restaurante", "São Judas Tadeu" };
            }
            else
            {
                Console.WriteLine("Culinária não encontrada.");
            }

            return (bons, ruins);
        }
    }
}
