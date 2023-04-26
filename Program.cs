using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicos07
{
    internal class Program
    {

        static void TesteFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}º vez que eu rio da voz do Everton");
            }
        }

        static void FaturamentoIngresso()
        {
            double total = 0;
            int[][] quantidadesIngressosVendidos = new int[3][];

            for (int valorIngresso = 100; valorIngresso <= 200; valorIngresso += 50)
            {
                Console.WriteLine($"Foram comprados ingressos do lote {(valorIngresso - 100) / 50 + 1}?");
                string resposta = Console.ReadLine().ToUpper();

                int i = (valorIngresso - 100) / 50;

                if (resposta == "N") continue;

                Console.WriteLine($"\n\nQuantos ingressos inteiros foram vendidos no lote {(valorIngresso - 100) / 50 + 1}?");
                int quantidadeIngressosInteiros = int.Parse(Console.ReadLine());

                Console.WriteLine(quantidadesIngressosVendidos[0]);

                //if (quantidadeIngressosInteiros > 0) quantidadesIngressosVendidos[i].Append(quantidadeIngressosInteiros);

                Console.WriteLine($"Quantos ingressos meios foram vendidos no lote {(valorIngresso-100)/50 + 1}?");
                int quantidadeIngressosMeios = int.Parse(Console.ReadLine());

                //if (quantidadeIngressosMeios > 0) quantidadesIngressosVendidos[i].Append(quantidadeIngressosMeios); 

                total += quantidadeIngressosInteiros * valorIngresso + quantidadeIngressosMeios * (valorIngresso / 2);
            }
            Console.WriteLine($"Faturamento Total: {total.ToString("C")}. \n\tForam vendidos {quantidadesIngressosVendidos[0][0]} ingressos inteiros no lote 1.\n\tForam vendidos {quantidadesIngressosVendidos[0][1]} ingressos meios no lote 1.\n\tForam vendidos {quantidadesIngressosVendidos[1][0]} ingressos inteiros no lote 2.\n\tForam vendidos {quantidadesIngressosVendidos[1][1]} ingressos meios no lote 2.\n\tForam vendidos {quantidadesIngressosVendidos[2][0]} ingressos inteiros no lote 3.\n\tForam vendidos {quantidadesIngressosVendidos[2][1]} ingressos meios no lote 3.");
        }

        static void ForTexto()
        {
            int[] numeros = { };

            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                numeros = numeros.Append(i).ToArray();
            }

            for (int k = 1; k <= qtd; k++)
            {
                Console.Write($"{k} ");
                for (int j = 1; j <= qtd; j++)
                {
                    if (numeros[j - 1] != k) Console.Write($"{numeros[j-1]} ");
                }

                Console.Write("\n");
            }
        }


        static void Main(string[] args)
        {
            //TesteFor();
            //FaturamentoIngresso();
            ForTexto();
            Console.ReadKey();
        }
    }
}
