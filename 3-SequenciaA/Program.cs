using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaA
{
    class Program
    {
        // Função para calcular o próximo elemento da sequência a
        static int SequenciaA(int n)
        {
            // O próximo elemento é obtido somando 2 ao elemento anterior
            return n + 2;
        }

        // Função para calcular o próximo elemento da sequência b
        static int SequenciaB(int n)
        {
            // O próximo elemento é obtido multiplicando o elemento anterior por 2
            return n * 2;
        }

        // Função para calcular o próximo elemento da sequência c
        static int SequenciaC(int n)
        {
            // O próximo elemento é obtido elevando ao quadrado o número natural correspondente à posição do elemento na sequência
            // Para isso, precisamos encontrar a raiz quadrada do elemento anterior e somar 1
            int raiz = (int)Math.Sqrt(n);
            return (raiz + 1) * (raiz + 1);
        }

        // Função para calcular o próximo elemento da sequência d
        static int SequenciaD(int n)
        {
            // O próximo elemento é obtido elevando ao quadrado um número par que começa em 2 e aumenta de 2 em 2
            // Para isso, precisamos encontrar a raiz quadrada do elemento anterior, dividir por 2, somar 1 e multiplicar por 2
            int raiz = (int)Math.Sqrt(n);
            return (raiz / 2 + 1) * (raiz / 2 + 1) * 4;
        }

        // Função para calcular o próximo elemento da sequência e
        static int SequenciaE(int n, int m)
        {
            // O próximo elemento é obtido somando os dois elementos anteriores
            // Para isso, precisamos receber os dois elementos anteriores como parâmetros
            return n + m;
        }

        // Função para calcular o próximo elemento da sequência f
        static int SequenciaF(int n)
        {
            // O próximo elemento é obtido seguindo um padrão alternado
            // Para isso, precisamos verificar o resto da divisão do elemento anterior por 10 e aplicar a regra correspondente
            int resto = n % 10;
            if (resto == 2)
            {
                // Se o resto for 2, somar 8
                return n + 8;
            }
            else if (resto == 6)
            {
                // Se o resto for 6, subtrair 4
                return n - 4;
            }
            else
            {
                // Se o resto for outro valor, somar 1
                return n + 1;
            }
        }

        static void Main(string[] args)
        {
            // Ler o último elemento de cada sequência informado pelo usuário
            Console.WriteLine("Digite o último elemento de cada sequência:");
            Console.Write("a) ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b) ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c) ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d) ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("e) ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("f) ");
            int f = int.Parse(Console.ReadLine());

            // Calcular o próximo elemento de cada sequência usando as funções definidas
            int a1 = SequenciaA(a);
            int b1 = SequenciaB(b);
            int c1 = SequenciaC(c);
            int d1 = SequenciaD(d);
            int e1 = SequenciaE(e, 8); // O segundo elemento anterior da sequência e é 8
            int f1 = SequenciaF(f);

            // Imprimir o próximo elemento de cada sequência
            Console.WriteLine("O próximo elemento de cada sequência é:");
            Console.WriteLine("a) {0}", a1);
            Console.WriteLine("b) {0}", b1);
            Console.WriteLine("c) {0}", c1);
            Console.WriteLine("d) {0}", d1);
            Console.WriteLine("e) {0}", e1);
            Console.WriteLine("f) {0}", f1);

            Console.ReadLine();
        }
    }
}
/*
 assim ficaria o resultado 


Digite o último elemento de cada sequência:
a) 7
b) 64
c) 36
d) 64
e) 8
f) 19
O próximo elemento de cada sequência é:
a) 9
b) 128
c) 49
d) 100
e) 16
f) 20
*/