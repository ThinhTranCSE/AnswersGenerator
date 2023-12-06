using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Randomizer
    {
        private Random Random;
        public Randomizer()
        {
            this.Random = new Random();
        }
        public int GetRandomIndexWithWeight(List<int> Weights)
        {
            double TotalWeight = Weights.Sum();
            double RandomValue = Random.NextDouble() * TotalWeight;

            for(int i = 0; i < Weights.Count; i++)
            {
                if(RandomValue < Weights[i])
                {
                    return i;
                }
                RandomValue -= Weights[i];
            }
            return -1;
        }
    }
}
