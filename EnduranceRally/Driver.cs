

namespace EnduranceRally
{
    public class Driver
    {
        public string Name { get; set; }
        public double Fuel()
        {
            var fuel = (int)Name[0];
            return fuel;
        }
    }
}
