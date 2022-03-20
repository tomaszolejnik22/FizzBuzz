using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Proszę podaj liczbę całkowitą.");
            while (true)
            {
                var number = GetInput();
                var result = new FizzBuzz();
                Console.WriteLine(result.Result(number));
                Console.WriteLine("\nPodaj następną liczbę.\nJeżeli chcesz wyjść wpisz Q");
            }
        }

        private static int GetInput()
        {
            while (true)
            {
                var value = Console.ReadLine();
                if (value.ToUpper() == "Q")
                    Environment.Exit(0);

                if (!int.TryParse(value, out int number ))
                {
                    Console.WriteLine("\nPodałeś nieprawidłowe dane. Spróbuj ponownie.\nWyjście wciśnij Q");
                    continue;
                }
                return number;
            }
        }
    }
}
