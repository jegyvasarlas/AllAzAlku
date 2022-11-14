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
            List<int> chosenBriefcases = new List<int>();
            Game.FillUp(briefcases);
            //Game.Inspect(briefcases);
            
            Console.Write("Válassz egy táskát (1-23): ");
            int selectedBriefcase = int.Parse(Console.ReadLine());
            while (selectedBriefcase >= 24 || selectedBriefcase <= 0 )
            {
                Console.Write("Válassz egy táskát (1-23): ");
                selectedBriefcase = int.Parse(Console.ReadLine());
            }

            switch(selectedBriefcase)
            {
                case 1: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 2: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 3: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-as táska\n"); break;
                case 4: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 5: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-ös táska\n"); break;
                case 6: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-os táska\n"); break;
                case 7: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 8: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-as táska\n"); break;
                case 9: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 10: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 11: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 12: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 13: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-as táska\n"); break;
                case 14: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 15: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-ös táska\n"); break;
                case 16: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-os táska\n"); break;
                case 17: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 18: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-as táska\n"); break;
                case 19: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 20: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-as táska\n"); break;
                case 21: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 22: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-es táska\n"); break;
                case 23: Console.WriteLine($"A kiválasztott táska a {briefcases.ElementAt(selectedBriefcase - 1).Key}-as táska\n"); break;
            }
            chosenBriefcases.Add(selectedBriefcase);
            int originalCaseID = selectedBriefcase; // in case it gets changed somehow

            int roundOne = 0; // elso
            while (roundOne < 5)
            {
                Console.Clear();
                Console.WriteLine("Első kör\n");
                Console.Write("Az eddig kiválasztott táskák: ");
                foreach (var briefcase in chosenBriefcases)
                    Console.Write($"{briefcase}, ");
                Console.WriteLine("\n");
                Console.Write("Válassz egy táskát (1-23): ");
                int newSelectedBriefcase = int.Parse(Console.ReadLine());
                while (newSelectedBriefcase >= 24 || newSelectedBriefcase <= 0 || chosenBriefcases.Contains(newSelectedBriefcase) == true)
                {
                    if(newSelectedBriefcase >= 24 || newSelectedBriefcase <= 0)
                    {
                        Console.Write("Válassz egy táskát (1-23): ");
                        newSelectedBriefcase = int.Parse(Console.ReadLine());
                    }
                    else if(chosenBriefcases.Contains(newSelectedBriefcase))
                    {
                        Console.Write("Ez a táska mar ki lett választva, válassz egy masik táskát (1-23): ");
                        newSelectedBriefcase = int.Parse(Console.ReadLine());
                    }
                }
                chosenBriefcases.Add(newSelectedBriefcase);
                roundOne++;
            }
            Console.Clear();
            Console.Write("Az eddig kiválasztott táskák: ");
            foreach (var briefcase in chosenBriefcases)
                Console.Write($"{briefcase}, ");
            Random rnd = new Random();
            int randomNumber = rnd.Next(1,6);
            Console.WriteLine("\n");
            Dictionary<int, int> firstRewardChosenByBank = briefcases.Where(x => x.Key == chosenBriefcases[randomNumber]).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"A bank ajánlata: {firstRewardChosenByBank.ElementAt(0).Value} forint\nElfogadod? (igen/nem)");
            //Console.WriteLine(firstRewardChosenByBank.ElementAt(0).Key);
            string acceptFirstOffer = Console.ReadLine();
            bool acceptFirst = false;
            while(acceptFirst == false)
            {
                if (String.Equals(acceptFirstOffer, "igen") || String.Equals(acceptFirstOffer, "nem"))
                    acceptFirst = true;
                else
                {
                    acceptFirstOffer = Console.ReadLine();
                }
            }
            
            if(acceptFirstOffer == "igen")
            {
                Console.Clear();
                Console.WriteLine($"Gratulálok, nyertél {firstRewardChosenByBank.ElementAt(0).Value} forintot!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if(acceptFirstOffer == "nem") { Console.Clear(); }
            
            int roundTwo = 0; // elso harom
            while (roundTwo < 3)
            {
                Console.Clear();
                Console.WriteLine("Második kör: \n");
                Console.Write("Az eddig kiválasztott táskák: ");
                foreach (var briefcase in chosenBriefcases)
                    Console.Write($"{briefcase}, ");
                Console.WriteLine("\n");
                Console.Write("Válassz egy táskát (1-23): ");
                int newSelectedBriefcase = int.Parse(Console.ReadLine());
                while (newSelectedBriefcase >= 24 || newSelectedBriefcase <= 0 || chosenBriefcases.Contains(newSelectedBriefcase) == true)
                {
                    if (newSelectedBriefcase >= 24 || newSelectedBriefcase <= 0)
                    {
                        Console.Write("Válassz egy táskát (1-23): ");
                        newSelectedBriefcase = int.Parse(Console.ReadLine());
                    }
                    else if (chosenBriefcases.Contains(newSelectedBriefcase))
                    {
                        Console.Write("Ez a táska mar ki lett választva, válassz egy masik táskát (1-23): ");
                        newSelectedBriefcase = int.Parse(Console.ReadLine());
                    }
                }
                chosenBriefcases.Add(newSelectedBriefcase);
                roundTwo++;
            }
            Console.Clear();
            Console.Write("Az eddig kiválasztott táskák: ");
            foreach (var briefcase in chosenBriefcases)
                Console.Write($"{briefcase}, ");
            rnd = new Random();
            randomNumber = rnd.Next(6, 9);
            Console.WriteLine("\n");
            Dictionary<int, int> secondRewardChosenByBank = briefcases.Where(x => x.Key == chosenBriefcases[randomNumber]).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"A bank ajánlata: {secondRewardChosenByBank.ElementAt(0).Value} forint\nElfogadod? (igen/nem)");
            acceptFirstOffer = Console.ReadLine();
            acceptFirst = false;
            while (acceptFirst == false)
            {
                if (String.Equals(acceptFirstOffer, "igen") || String.Equals(acceptFirstOffer, "nem"))
                    acceptFirst = true;
                else
                {
                    acceptFirstOffer = Console.ReadLine();
                }
            }

            if (acceptFirstOffer == "igen")
            {
                Console.Clear();
                Console.WriteLine($"Gratulálok, nyertél {secondRewardChosenByBank.ElementAt(0).Value} forintot!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (acceptFirstOffer == "nem") { Console.Clear(); }

            int roundThree = 0; // masodik harom
            while (roundThree < 3)
            {
                Console.Clear();
                Console.WriteLine("Harmadik kör: \n");
                Console.Write("Az eddig kiválasztott táskák: ");
                foreach (var briefcase in chosenBriefcases)
                    Console.Write($"{briefcase}, ");
                Console.WriteLine("\n");
                Console.Write("Válassz egy táskát (1-23): ");
                int newSelectedBriefcase = int.Parse(Console.ReadLine());
                while (newSelectedBriefcase >= 24 || newSelectedBriefcase <= 0 || chosenBriefcases.Contains(newSelectedBriefcase) == true)
                {
                    if (newSelectedBriefcase >= 24 || newSelectedBriefcase <= 0)
                    {
                        Console.Write("Válassz egy táskát (1-23): ");
                        newSelectedBriefcase = int.Parse(Console.ReadLine());
                    }
                    else if (chosenBriefcases.Contains(newSelectedBriefcase))
                    {
                        Console.Write("Ez a táska mar ki lett választva, válassz egy masik táskát (1-23): ");
                        newSelectedBriefcase = int.Parse(Console.ReadLine());
                    }
                }
                chosenBriefcases.Add(newSelectedBriefcase);
                roundThree++;
            }
            Console.Clear();
            Console.Write("Az eddig kiválasztott táskák: ");
            foreach (var briefcase in chosenBriefcases)
                Console.Write($"{briefcase}, ");
            rnd = new Random();
            randomNumber = rnd.Next(9, 12);
            Console.WriteLine("\n");
            Dictionary<int, int> thirdRewardChosenByBank = briefcases.Where(x => x.Key == chosenBriefcases[randomNumber]).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"A bank ajánlata: {thirdRewardChosenByBank.ElementAt(0).Value} forint\nElfogadod? (igen/nem)");
            acceptFirstOffer = Console.ReadLine();
            acceptFirst = false;
            while (acceptFirst == false)
            {
                if (String.Equals(acceptFirstOffer, "igen") || String.Equals(acceptFirstOffer, "nem"))
                    acceptFirst = true;
                else
                {
                    acceptFirstOffer = Console.ReadLine();
                }
            }
            if (acceptFirstOffer == "igen")
            {
                Console.Clear();
                Console.WriteLine($"Gratulálok, nyertél {thirdRewardChosenByBank.ElementAt(0).Value} forintot!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (acceptFirstOffer == "nem") { Console.Clear(); }

            int roundFour = 0; // harmadik harom
            while (roundFour < 3)
            {
                Console.Clear();
                Console.WriteLine("Negyedik kör: \n");
                Console.Write("Az eddig kiválasztott táskák: ");
                foreach (var briefcase in chosenBriefcases)
                    Console.Write($"{briefcase}, ");
                Console.WriteLine("\n");
                Console.Write("Válassz egy táskát (1-23): ");
                int newSelectedBriefcase = int.Parse(Console.ReadLine());
                while (newSelectedBriefcase >= 24 || newSelectedBriefcase <= 0 || chosenBriefcases.Contains(newSelectedBriefcase) == true)
                {
                    if (newSelectedBriefcase >= 24 || newSelectedBriefcase <= 0)
                    {
                        Console.Write("Válassz egy táskát (1-23): ");
                        newSelectedBriefcase = int.Parse(Console.ReadLine());
                    }
                    else if (chosenBriefcases.Contains(newSelectedBriefcase))
                    {
                        Console.Write("Ez a táska mar ki lett választva, válassz egy masik táskát (1-23): ");
                        newSelectedBriefcase = int.Parse(Console.ReadLine());
                    }
                }
                chosenBriefcases.Add(newSelectedBriefcase);
                roundFour++;
            }
            Console.Clear();
            Console.Write("Az eddig kiválasztott táskák: ");
            foreach (var briefcase in chosenBriefcases)
                Console.Write($"{briefcase}, ");
            rnd = new Random();
            randomNumber = rnd.Next(12, 15);
            Console.WriteLine("\n");
            Dictionary<int, int> fourthRewardChosenByBank = briefcases.Where(x => x.Key == chosenBriefcases[randomNumber]).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"A bank ajánlata: {fourthRewardChosenByBank.ElementAt(0).Value} forint\nElfogadod? (igen/nem)");
            acceptFirstOffer = Console.ReadLine();
            acceptFirst = false;
            while (acceptFirst == false)
            {
                if (String.Equals(acceptFirstOffer, "igen") || String.Equals(acceptFirstOffer, "nem"))
                    acceptFirst = true;
                else
                {
                    acceptFirstOffer = Console.ReadLine();
                }
            }
            if (acceptFirstOffer == "igen")
            {
                Console.Clear();
                Console.WriteLine($"Gratulálok, nyertél {fourthRewardChosenByBank.ElementAt(0).Value} forintot!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (acceptFirstOffer == "nem") { Console.Clear(); }
            Console.Clear();
            Console.WriteLine("Köszönjük a játékot, az eredeti táska nyereménye: " + briefcases.ElementAt(originalCaseID - 1).Value);
            Console.ReadKey();
        }
        
    }
}
