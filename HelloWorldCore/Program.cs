using System;

namespace HelloWorldCore
{
    public class Program
    {
        public static void Main()
        {
            //Console.WriteLine("Hello World!");
            Engene en = new Engene();
            //Console.WriteLine(en.isThisCorectStreeng("5x5 (0, 0) (1, 3) (4,4) (4, 2) (4, 2) (0, 1)(3, 2)(2, 3)(4, 1) "));
            //Console.WriteLine(en.convertToArr("15x15 (13,3)(4,4)"));
            Console.WriteLine(en.transformToString("5x5 (0, 0) (1, 3) (4,4) (4, 2) (4, 2) (0, 1)(3, 2)(2, 3)(4, 1) "));
            //Console.WriteLine(en.Run("5x5 (0,0)(1,3)(4,4)(4,2)(4,2)(0,1)(3,2)(2,3)(4,1)"));
        }
    }
}
