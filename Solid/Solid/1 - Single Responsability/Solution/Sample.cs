using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._1___Single_Responsability.Solution
{
    public class Sample
    {
        public Sample()
        {
            GenerateRobot();
            Console.ReadKey();
        }

        private void GenerateRobot()
        {
            Console.WriteLine("1 - Chefe");
            Console.WriteLine("2 - Jaredineiro");
            Console.WriteLine("3 - Pintor");
            Console.WriteLine("4 - Motorista");
            var menu = Console.ReadLine();
            int menuOption = 0;
            if(int.TryParse(menu, out menuOption))
            {
                Console.Clear();

                switch(menuOption)
                {
                    case 1:
                        Console.WriteLine(new Chef { Name = "Novo Chef" });
                        break;

                    case 2:
                        Console.WriteLine(new Gardener { Name = "Novo Jardineiro" });
                        break;

                    case 3:
                        Console.WriteLine(new Painter { Name = "Novo Pintor" });
                        break;

                    case 4:
                        Console.WriteLine(new Driver { Name = "Novo Motorista", Document = "123.123.123" });
                        break;
                }
            }
        }
    }
}
