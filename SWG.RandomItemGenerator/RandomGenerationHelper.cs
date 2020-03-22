using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SWG.RandomDataGenerator.LootTableData;

namespace SWG.RandomDataGenerator
{
    static class RandomGenerationHelper
    {
        private static readonly Random Random = new Random();
        private static readonly object SyncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (SyncLock)
            { 
                return Random.Next(min, max);
            }
        }

        public static int RandomNumber(int max)
        {
            lock (SyncLock)
            {
                return Random.Next(max);
            }
        }

        public static int GetSummedProbability(IEnumerable<ILootItem> items)
        {
            return items.Sum(i => i.Probability);
        }
    }
}
