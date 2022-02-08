using System;

namespace GrabageCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("The Generation are " + GC.GetTotalMemory(true));
            Console.WriteLine("The Generation are "+ GC.GetTotalMemory(false));
            Program p=new Program();
            Console.WriteLine("The Generation are " + GC.MaxGeneration);
            Console.WriteLine("The Generation are " + GC.GetGeneration(p));
            Console.WriteLine("The Generation are " + GC.GetTotalMemory(true));
            Console.WriteLine("The Generation are "+ GC.GetTotalMemory(false));
            
            

            GC.Collect();
            Console.WriteLine("GC in Generation {0}", GC.CollectionCount(0));
            //Console.WriteLine("GC in generation 0 {0}", GC.CollectionCount(1));


        }
    }
}
