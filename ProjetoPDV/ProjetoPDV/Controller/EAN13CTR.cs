using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDV.Controller
{
    class EAN13CTR
    {

        public bool validarDigitoCodigoBarras(string codigoBarras)
        {
            //Inicialmente atribuímos "falso" à variável booleana DVvalido 
            bool DVvalido = false;

            char[] vetorCodigoBarras = codigoBarras.ToArray();
            char[] vetorOrganizado = new char[14];

            //Aplicamos os cálculos necessários para a validação do código de barras
            for (int indice = 0; indice < vetorCodigoBarras.Length; indice++)
            {
                int novoIndice = 13 - indice;
                vetorOrganizado[novoIndice] = vetorCodigoBarras[indice];
            }

            int somaPosicoesPares = 0;
            int somaPosicoesImpares = 0;

            for (int i = 2; i < vetorOrganizado.Length; i++)
            {
                int resto = 0;
                Math.DivRem(i, 2, out resto);
                if (resto == 0)
                {
                    somaPosicoesPares += int.Parse(vetorOrganizado[i].ToString());
                }
                else
                {
                    somaPosicoesImpares += int.Parse(vetorOrganizado[i].ToString());
                }
            }

            int multiplicacaoPares = somaPosicoesPares * 3;
            int somaImpares = multiplicacaoPares + somaPosicoesImpares;

            int multiploDeDez = 10;
            while (multiploDeDez < somaImpares)
            {
                multiploDeDez += 10;
            }

            int DV = multiploDeDez - somaImpares;

            //caso o dígito seja válido, atribui o valor true à variável DVvalido
            //caso contrário não é necessário fazer nada, visto que a variável já possui o valor falso
            if (DV == int.Parse(vetorOrganizado[1].ToString()))
                DVvalido = true;

            //retorna o valor da variável
            return DVvalido;
        }
    }
}
