namespace Solid._1___Single_Responsability.Solution
{
    public class Driver
    {
        public string Name { get; set; }
        public string Document { get; set; }

        public override string ToString()
        {
            return $"Motorista : {Name} - doc : {Document}";
        }
    }
}
