using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWG.RandomDataGenerator.LootTableData;

namespace ConsoleWriter
{
    class LootChanceCalculator
    {
        public void Calculate(ILootTable lootTable)
        {
            int groupIterator = 1;

            foreach (var lootGroup in lootTable.LootGroups)
            {
                Console.WriteLine($"Group {groupIterator}");
                Console.WriteLine($"Group probability: {Math.Round((double)lootGroup.LootGroupRollProbability, 2)}");

                foreach (var lootItem in lootGroup.LootItems)
                {
                    double probability = (lootGroup.LootGroupRollProbability * (double)lootItem.Probability) / 100;
                    Console.WriteLine($"Id: {lootItem.Id}\tBase probability: {Math.Round((double)lootItem.Probability, 2)}%\tCalculated probability: {Math.Round(probability, 2)}%");
                }

                groupIterator++;
            }
        }
    }
}
