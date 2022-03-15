using System;

namespace Stopwatcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("M- Minutos\nS- Segundos\n0- Sair\n   Ex.: 2m");
            string? answer = Console.ReadLine().ToLower();
            if (answer == "0")
                System.Environment.Exit(0);
            int number = int.Parse(answer.Substring(0, answer.Length - 1));
            char type = char.Parse(answer.Substring(answer.Length - 1, 1));

            if (type == 'm')
                number *= 60;
            Regressor(number);
        }

        static void Regressor(int time)
        {
            int counter = time;
            while (counter != 0)
            {
                Console.Clear();
                Console.WriteLine(counter);
                Thread.Sleep(1000);
                counter--;
            }
            Menu();
        }

    }
}