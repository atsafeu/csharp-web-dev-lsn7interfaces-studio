using System;
namespace SpinningDiscs
{

    public class DVD : BaseDisc, IOpticalDisc
   
        {
            // TODO: Implement your custom interface.
            public DVD(string name, int totalCapacity, string CDtype, int UsedCapacity) : base(name, totalCapacity, CDtype, UsedCapacity)
            {
            }
            public void ReadData()
            {
                Console.WriteLine("Which DVD is worst ?");
            }

            public void SpinDisc()
            {
                Console.WriteLine(" A DVD spins fast.");
            }
            // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
            //  need to be declared separately. 
        
        }
}
