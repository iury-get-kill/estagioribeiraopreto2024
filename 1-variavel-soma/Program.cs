using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_variavel_soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine("1 resultado do primeiro exercicio " + SOMA);

            Console.ReadLine();
        }
    }
}


/*
Para calcular o valor da variável SOMA ao final do processamento, você pode usar uma fórmula matemática que soma os números de 1 a n, onde n é o valor de INDICE. A fórmula é:
SOMA=2n(n+1)​
Substituindo o valor de n por 13, temos:
SOMA=213(13+1)​
SOMA=213(14)​
SOMA=2182​
SOMA=91
Portanto, o valor da variável SOMA é 91.
*/


