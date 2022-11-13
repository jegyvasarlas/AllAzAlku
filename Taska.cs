using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAzAlku
{
    class Taska
    {
        private string rewardsString = "1;5;10;100;500;1000;5000;10000;25000;50000;80000;150000;300000;500000;800000;1000000;2500000;5000000;7000000;10000000;15000000;20000000;50000000";
        private int id;
        private int reward;
        private List<int> rewardsList;
        private int[] rewardsArray;
        private bool isOpened;
        private Dictionary<int, int> idReward;
        public Taska(int a)
        {
            this.id = a;
            for (int i = 0; i < 23; i++)
            {
                rewardsArray[i] = int.Parse(rewardsString.Split(';'));
            }
            this.reward = ;
        }

        public Taska Open(int a)
        {

        }

    }
}
