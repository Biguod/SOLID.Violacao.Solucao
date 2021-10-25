using Solid._1___Single_Responsability;
using System;

namespace Solid
{
    class Program
    {
        private static int menuOpcao = -1;

        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("----- OPCOES -------");
                Console.WriteLine("1 - Single Responsability");
                Console.WriteLine("2 - Open Closed");
                Console.WriteLine("3 - Liskov Substitution");
                Console.WriteLine("4 - Interface Segregation");
                Console.WriteLine("5 - Dependency Inversion");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("-----------------");

                var aux = Console.ReadLine();
                if (int.TryParse(aux, out menuOpcao))
                {
                    switch (menuOpcao)
                    {
                        case 1:
                            new SingleResponsability();
                            break;
                    }
                }
            } while (menuOpcao != 0);
        }
    }
}
