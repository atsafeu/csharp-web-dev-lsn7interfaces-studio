using System;
namespace SpinningDiscs
{
    public class CD: BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.
        public CD(string name, int totalCapacity, string CDtype, int UsedCapacity) : base(name, totalCapacity, CDtype, UsedCapacity)
        {
        }
        public void ReadData()
        {
            Console.WriteLine("Which CD is better ?");
        }

        public void SpinDisc()
        {
            Console.WriteLine(" A CD spins at hig rate.");
        }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}
