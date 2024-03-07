using System;

class Program
{
    static void Main(string[] args)
    {
        // Ler o número informado pelo usuário
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        // Inicializar as variáveis da sequência de Fibonacci
        int a = 0; // Primeiro termo
        int b = 1; // Segundo termo
        int c = 0; // Terceiro termo

        // Criar uma lista para armazenar os termos da sequência
        var lista = new System.Collections.Generic.List<int>();

        // Adicionar os dois primeiros termos à lista
        lista.Add(a);
        lista.Add(b);

        // Calcular a sequência de Fibonacci até o número informado ou até o próximo número maior que ele
        while (c <= num)
        {
            c = a + b; // Somar os dois termos anteriores
            a = b; // Atualizar o primeiro termo
            b = c; // Atualizar o segundo termo
            lista.Add(c); // Adicionar o terceiro termo à lista
        }

        // Verificar se o número informado pertence à sequência de Fibonacci
        if (lista.Contains(num))
        {
            // Se pertence, imprimir uma mensagem positiva
            Console.WriteLine("O número {0} pertence à sequência de Fibonacci.", num);
        }
        else
        {
            // Se não pertence, imprimir uma mensagem negativa
            Console.WriteLine("O número {0} não pertence à sequência de Fibonacci.", num);
        }

        // Imprimir a sequência de Fibonacci calculada
        Console.WriteLine("A sequência de Fibonacci até {0} é:", num);
        foreach (int termo in lista)
        {
            Console.Write(termo + " ");
        }
        Console.WriteLine();
    }
}

