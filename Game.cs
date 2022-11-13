using System;
using System.Collections.Generic;
using System.Linq;

namespace Main
{
    class Game
    {
        public enum Rewards
        {
            One = 1,
            Five = 5,
            Ten = 10,
            OneHundred = 100,
            FiveHundred = 500,
            OneThousand = 1000,
            FiveThousand = 5000,
            TenThousand = 10000,
            TwentyFiveThousand = 25000,
            FiftyThousand = 50000,
            EightyThousand = 80000,
            OneHundredFiftyThousand = 150000,
            ThreeHundredThousand = 300000,
            FiveHundredThousand = 500000,
            EightHundredThousand = 800000,
            OneMillion = 1000000,
            TwoMillionFiveHundredThousand = 2500000,
            FiveMillion = 5000000,
            SevenMillion = 7000000,
            TenMillion = 10000000,
            FifteenMillion = 15000000,
            TwentyMillion = 20000000,
            FiftyMillion = 50000000
        }
        public static Dictionary<int, int> FillUp(Dictionary<int, int> whichBriefcaseHasWhichReward)
        {
            HashSet<int> numbers = new HashSet<int>();

            Random r = new Random();

            while (numbers.Count != 23)
            {
                numbers.Add(r.Next(1, 24));
            }

            List<int> numbersList = new List<int>();

            foreach (var number in numbers)
            {
                numbersList.Add(number);
            }

            int index = 0;

            foreach (int i in Enum.GetValues(typeof(Rewards)))
            {
                whichBriefcaseHasWhichReward.Add(i, numbersList[index]);
                index++;
            }

            return whichBriefcaseHasWhichReward;
        }
        public static void PrintOutOrderByReward(Dictionary<int, int> whichBriefcaseHasWhichReward)
        {
            foreach (KeyValuePair<int, int> item in whichBriefcaseHasWhichReward)
            {
                Console.WriteLine($"ID: {item.Value.ToString()} \tReward: {item.Key}");
            }
        }
        public static void PrintOutOrderByID(Dictionary<int, int> whichBriefcaseHasWhichReward)
        {
            foreach (KeyValuePair<int, int> item in whichBriefcaseHasWhichReward.OrderBy(x => x.Value))
            {
                Console.WriteLine($"ID: {item.Value.ToString()} \tReward: {item.Key}");
            }
        }
        public static void Inspect(Dictionary<int, int> whichBriefcaseHasWhichReward)
        {
            Console.WriteLine("ID szerint rendezve:");
            PrintOutOrderByID(whichBriefcaseHasWhichReward);
            Console.WriteLine();
            Console.WriteLine("Nyerememeny szerint rendezve:");
            PrintOutOrderByReward(whichBriefcaseHasWhichReward);

        }
    }
}
