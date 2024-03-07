using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_InterruptoresELampadas
{
    class Program
    {
        // Define uma classe para representar uma lâmpada
        class Lampada
        {
            // Define as propriedades da lâmpada: estado (ligada ou desligada) e temperatura (em graus Celsius)
            public bool Estado { get; set; }
            public int Temperatura { get; set; }

            // Define um construtor que inicializa a lâmpada como desligada e fria
            public Lampada()
            {
                Estado = false;
                Temperatura = 20;
            }

            // Define um método para ligar a lâmpada, que aumenta a temperatura em 10 graus
            public void Ligar()
            {
                Estado = true;
                Temperatura += 10;
            }

            // Define um método para desligar a lâmpada, que diminui a temperatura em 5 graus
            public void Desligar()
            {
                Estado = false;
                Temperatura -= 5;
            }
        }

        static void Main(string[] args)
        {
            // Cria três lâmpadas e três interruptores
            Lampada lampada1 = new Lampada();
            Lampada lampada2 = new Lampada();
            Lampada lampada3 = new Lampada();
            bool interruptor1 = false;
            bool interruptor2 = false;
            bool interruptor3 = false;

            // Ligar o primeiro interruptor e esperar alguns minutos
            interruptor1 = true;
            lampada1.Ligar();
            Console.WriteLine("Ligou o primeiro interruptor e esperou alguns minutos.");

            // Desligar o primeiro interruptor e ligar o segundo interruptor
            interruptor1 = false;
            lampada1.Desligar();
            interruptor2 = true;
            lampada2.Ligar();
            Console.WriteLine("Desligou o primeiro interruptor e ligou o segundo interruptor.");

            // Ir até a sala das lâmpadas e observar qual delas está acesa, qual está apagada e quente, e qual está apagada e fria
            Console.WriteLine("Foi até a sala das lâmpadas e observou:");
            if (lampada1.Estado)
            {
                Console.WriteLine("A primeira lâmpada está acesa.");
            }
            else
            {
                Console.WriteLine("A primeira lâmpada está apagada e tem {0} graus.", lampada1.Temperatura);
            }
            if (lampada2.Estado)
            {
                Console.WriteLine("A segunda lâmpada está acesa.");
            }
            else
            {
                Console.WriteLine("A segunda lâmpada está apagada e tem {0} graus.", lampada2.Temperatura);
            }
            if (lampada3.Estado)
            {
                Console.WriteLine("A terceira lâmpada está acesa.");
            }
            else
            {
                Console.WriteLine("A terceira lâmpada está apagada e tem {0} graus.", lampada3.Temperatura);
            }

            // Concluir que a lâmpada acesa é controlada pelo segundo interruptor, a lâmpada apagada e quente é controlada pelo primeiro interruptor, e a lâmpada apagada e fria é controlada pelo terceiro interruptor
            Console.WriteLine("Concluiu que:");
            Console.WriteLine("A lâmpada acesa é controlada pelo segundo interruptor.");
            Console.WriteLine("A lâmpada apagada e quente é controlada pelo primeiro interruptor.");
            Console.WriteLine("A lâmpada apagada e fria é controlada pelo terceiro interruptor.");

            Console.ReadLine();
        }
    }
}

/*
Meu objetivo é descobrir qual interruptor controla qual lâmpada. assim ficou


Ligou o primeiro interruptor e esperou alguns minutos.
Desligou o primeiro interruptor e ligou o segundo interruptor.
Foi até a sala das lâmpadas e observou:
A primeira lâmpada está apagada e tem 25 graus.
A segunda lâmpada está acesa.
A terceira lâmpada está apagada e tem 20 graus.
Concluiu que:
A lâmpada acesa é controlada pelo segundo interruptor.
A lâmpada apagada e quente é controlada pelo primeiro interruptor.
A lâmpada apagada e fria é controlada pelo terceiro interruptor.
*/