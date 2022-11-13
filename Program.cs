using System;
using System.Collections.Generic;
using System.Linq;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> briefcases = new Dictionary<int, int>();
            Game.FillUp(briefcases);
            Game.Inspect(briefcases);
            Console.ReadKey();
        } 
    }
}
