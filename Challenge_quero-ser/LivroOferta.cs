using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_quero_ser
{
    internal class LivroOferta
    {

        /*Regras de Negócio para o Livro de Oferta
         * 
         * dividido em 4 partes
         * POSIÇÃO, AÇÃO, VALOR, QUANTIDADE
         * 
         */
        public static bool CalcularLivroOferta()
        {

            //Console.WriteLine("Informe a o número de notificações de Livros de Oferta: ");
            int qtdLivroOferta = 12;

            //Comando de Input
            Array[] array = new Array[] {
                new object[] { 1, 0, 15.4, 50  },
                new object[] { 2, 0, 15.5, 50 },
                new object[] { 2, 2, 0, 0 },
                new object[] { 2, 0, 15.4, 10 },
                new object[] { 3, 0, 15.9, 30 },
                new object[] { 3, 1, 0, 20 },
                new object[] { 4, 0, 16.50, 200 },
                new object[] { 5, 0, 17.00, 100 },
                new object[] { 5, 0, 16.59, 20 },
                new object[] { 6, 2, 0, 0 },
                new object[] { 1, 2, 0, 0 },
                new object[] { 2, 1, 15.6, 0 } };


            int n = qtdLivroOferta;
            var orderBook = new SortedDictionary<int, (double valor, int quantidade)>();

            Console.WriteLine("\n-----------Sera executado " + qtdLivroOferta + " comando(s) de Input-----------\n");

            for (int i = 0; i < n; i++)
            {                
                var input = array[i];
               
                int posicao = Convert.ToInt32(input.GetValue(0));
                int acao = Convert.ToInt32(input.GetValue(1));
                double valores = Convert.ToDouble(input.GetValue(2));
                int quatidade = Convert.ToInt32(input.GetValue(3));

                Console.WriteLine("posicao:" + posicao + "| acao:" + acao + "| valor:" + valores + "| quatidade: "+ quatidade);

                if (acao == 0) // Inserir
                {
                    orderBook[posicao] = (valores, quatidade);
                }
                else if (acao == 1 && orderBook.ContainsKey(posicao)) // Modificar
                {
                    var existing = orderBook[posicao];
                    orderBook[posicao] = (valores == 0 ? existing.valor : valores, quatidade == 0 ? existing.quantidade : quatidade);
                }
                else if (acao == 2) // Deletar
                {
                    orderBook.Remove(posicao);
                }
            }

            Console.WriteLine("\n-----------Segue o Output-----------\n");

            foreach (var entry in orderBook)
            {
                Console.WriteLine($"{entry.Key},{entry.Value.valor},{entry.Value.quantidade}");
            }

            return true;
        }

    }
}
