using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _VerificadorDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool permissao = true;
            while (permissao == true)
            {
                Console.WriteLine("Etanol ou Gasolina ? Qual é mais viável");
                Console.WriteLine("**************************************");
                Console.Write("Insira o preço do etanol: "); string precoEtanol = Console.ReadLine();
                Console.Write("Insira o preço da gasolina: "); string precoGasolina = Console.ReadLine();
                double media = (Convert.ToDouble(precoEtanol) / Convert.ToDouble(precoGasolina));
                if (media > 0.7)
                {
                    Console.WriteLine("\nVale a pena abastecer com gasolina!\n");
                }
                else if (media < 0.7)
                {
                    Console.WriteLine("Vale a pena abastecer com etanol!\n");
                }
                else
                {
                    Console.WriteLine("Tanto faz abasteçer com etanol ou gasolina!\n");
                }
                Console.Write("Deseja continuar? S para sim e N para não: ");
                string cont;
                cont = Console.ReadLine();
                Console.Clear();
                if (cont == "s")
                {
                    permissao = true;
                }
                else permissao = false;
            }
            Console.WriteLine("Obrigado por utilizar nosso sistema!");






            Console.ReadLine();
        }
    }
}
