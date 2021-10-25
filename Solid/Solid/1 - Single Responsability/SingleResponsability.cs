using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._1___Single_Responsability
{
    public class SingleResponsability
    {
        private int opcaoMenu;

        public SingleResponsability()
        {
            Menu();
        }

        private void Menu()
        {
            Console.Clear();
            Console.WriteLine("----- Responsabilidade unica -------");
            Console.WriteLine("1 - Violacao");
            Console.WriteLine("2 - Solução");
            Console.WriteLine("----------------------------------");

            var aux = Console.ReadLine();

            if(int.TryParse(aux, out opcaoMenu))
            {
                switch(opcaoMenu)
                {
                    case 1:
                        new Violation.Sample();
                        break;

                    case 2:
                        new Solution.Sample();
                        break;
                }
            }
        }
    }
}
