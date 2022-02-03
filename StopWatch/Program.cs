using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("E = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            if (data == "e")
                System.Environment.Exit(0);

            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 = Incremento");
            Console.WriteLine("2 = Decremento");
            int opcao = int.Parse(Console.ReadLine());


            char type = char.Parse(data.Substring(data.Length-1, 1));
            int time = int.Parse(data.Substring(0, data.Length-1));

            switch (type) {

                case 's': PreStart(time, opcao); break;
                case 'm': PreStart(time * 60, opcao); break;
                default: Menu();  break;
            }
        }

        static void PreStart(int time, int opcao) 
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time, opcao);
        }

        static void Start(int time, int opcao) 
        {
            int currentTime = 0;

            if (opcao == 1)
            {
                while (currentTime != time)
                {
                    Console.Clear();
                    currentTime++;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);
                }
            }
            else if (opcao == 2)
            {
                while (currentTime != time)
                {
                    Console.Clear();
                    Console.WriteLine(time);
                    time--;
                    Thread.Sleep(1000);
                }
            }
            else
            {
                Menu();
            }



            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);

            Menu();
        }
    }
}
