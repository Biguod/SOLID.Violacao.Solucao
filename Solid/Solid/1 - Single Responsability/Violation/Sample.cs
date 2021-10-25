using System;

namespace Solid._1___Single_Responsability.Violation
{
    public class Sample
    {
        public Sample()
        {
            Robot robot = new Robot
            {
                Chef = "Novo chefe",
                Gardener = "Novo Jardineiro",
                Painter = "Novo Pintor",
                Driver = "Novo Motorista",
                DriverDocument = "123.123.123",
            };

            Console.Clear();
            Console.WriteLine(robot);
            Console.ReadKey();
        }
    }
}
