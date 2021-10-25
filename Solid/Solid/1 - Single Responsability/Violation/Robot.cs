namespace Solid._1___Single_Responsability.Violation
{
    public class Robot
    {
        public string Chef { get; set; }
        public string Gardener { get; set; }
        public string Painter { get; set; }
        public string Driver { get; set; }
        public string DriverDocument { get; set; }


        public override string ToString()
        {
            return @$"--- Robo ---
                Chef {Chef}
                Gardener {Gardener}
                Painter {Painter}
                Driver {Driver}
                DriverDocument {DriverDocument}
            ";
        }
    }
}
