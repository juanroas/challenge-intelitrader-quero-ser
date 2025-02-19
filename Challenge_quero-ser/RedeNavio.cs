using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_quero_ser
{
    internal class RedeNavio
    {

        // https://github.com/intelitrader/quero-ser/blob/master/exercicios/criptografia_navio.md
        /*
         * Criptografia na rede do navio
         * 
         * 
         * Regas: a cada 8 bits, os dois últimos estão invertidos e a cada 4 bits, os 4 bits foram trocados com os próximos 4        * 
         * 
         * Mensagem criptografada:
           10010100 11100100 01000110 01010100 11000100 10010100 01000110 00100110 00010100 01000100 01010100 00100110 00000001 
           01000100 01010100 00110100 11110100 01000100 01010100 00110110 00000001 00110110 10010100 11100100 00010100 11000100
         * 
         * Frase - INTELITRADER DECODES SIGNAL
         */

        public static bool Criptografar()
        {
            string mensagem = "10010100 11100100 01000110 01010100 11000100 10010100 01000110 00100110 00010100 01000100 01010100 00100110 00000001 01000100 01010100 00110100 11110100 01000100 01010100 00110110 00000001 00110110 10010100 11100100 00010100 11000100";
            
            string[] mensagemArray = mensagem.Split(' ');
            string doisInvertidos = "", quatroTroca = "", quatroTrocaProximo = "", textoTrocar = "", textoTrocado = "";
            byte[] encryptedBytes = new byte[mensagemArray.Count()];
            for (int i = 0; i < mensagemArray.Length; i++)
            {
                // Dois Invertidos
                textoTrocar = mensagemArray[i];
                doisInvertidos = textoTrocar.Substring(textoTrocar.Length - 2, 2);
                textoTrocado = textoTrocar.Substring(0, textoTrocar.Length - 2) + doisInvertidos[1] + doisInvertidos[0];
                mensagemArray[i] = textoTrocado;

                // Quatro Troca
                textoTrocar = mensagemArray[i];
                quatroTroca = textoTrocar.Substring(0, 4);
                quatroTrocaProximo = textoTrocar.Substring(4, 4);
                textoTrocado = quatroTrocaProximo + quatroTroca;
                mensagemArray[i] = textoTrocado;

                //converte to byte
                encryptedBytes[i] = Convert.ToByte(mensagemArray[i], 2);
            }
            string mensagemDescriptografada = Encoding.ASCII.GetString(encryptedBytes);

            Console.WriteLine("\n frase decodificada:"+ mensagemDescriptografada+"  \n");
            
            return true;
        }
    }
}
