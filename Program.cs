using System;
using System.Collections.Generic;
using System.Linq;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> briefcases = new SortedDictionary<int, int>(); 
            Game.FillUp(briefcases);
            Game.Inspect(briefcases);

            Console.Write("Válassz egy táskát: ");
            int selectedBriefcase = int.Parse(Console.ReadLine());

            switch(selectedBriefcase)
            {
                case 1: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 2: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 3: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-as táska"); break;
                case 4: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 5: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-ös táska"); break;
                case 6: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-os táska"); break;
                case 7: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 8: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-as táska"); break;
                case 9: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 10: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 11: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 12: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 13: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-as táska"); break;
                case 14: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 15: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-ös táska"); break;
                case 16: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-os táska"); break;
                case 17: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 18: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-as táska"); break;
                case 19: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 20: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-as táska"); break;
                case 21: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 22: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska"); break;
                case 23: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-as táska"); break;
            }

            Console.ReadKey();
        }
        
    }
}
