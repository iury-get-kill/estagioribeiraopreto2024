using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_InverterString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que informe uma string
            Console.WriteLine("Digite uma string para ser invertida:");
            string original = Console.ReadLine();

            // Cria uma variável para armazenar a string invertida
            string invertida = "";

            // Percorre a string original de trás para frente
            for (int i = original.Length - 1; i >= 0; i--)
            {
                // Adiciona cada caractere à string invertida
                invertida += original[i];
            }

            // Exibe a string invertida
            Console.WriteLine("A string invertida é: " + invertida);

            Console.ReadLine();
        }
    }
}
/*
assim ficou o resultado 

Digite uma string para ser invertida:
Estágio Ribeirão Preto - 2024
A string invertida é: 4202 - oterP oãriebiR oigátsE
*/