using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SWG.RandomDataGenerator;
using SWG.RandomDataGenerator.ItemData.ItemTypes;
using SWG.RandomDataGenerator.LootTableData;

namespace ConsoleWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var lootTableGenerator = new LootTableGenerator();
            var calculator = new LootChanceCalculator();
            var reflections = new Reflections();

            var possibleItemList = new List<ItemType> {ItemType.OneHand, ItemType.TwoHand};

            var testClass = reflections.GetNewInstance(possibleItemList);
            foreach (var c in testClass)
            {
                Console.WriteLine(c.Name);
            }
            

            //calculator.Calculate(lootTableGenerator.GetLootTable());
            Console.ReadKey();
        }
    }

    enum ItemType
    {
        OneHand,
        TwoHand
    }

    class LootTableGenerator
    {
        public LootTable GetLootTable()
        {
            return new LootTable
            {
                ItemGenerationParameters = null,
                LootGroups = GetLootGroups()
            };
        }

        private IEnumerable<ILootGroup> GetLootGroups()
        {
            var lootGroups = new List<ILootGroup>();

            for (int i = 0; i < RandomGenerationHelper.RandomNumber(1, 5); i++)
            {
                lootGroups.Add(new LootGroup
                    {
                        IsPossible = true,
                        LootGroupRollProbability = RandomGenerationHelper.RandomNumber(1, 100),
                        LootItems = GetLootItems()
                    }
                );
            }

            return lootGroups;
        }

        private IEnumerable<ILootItem> GetLootItems()
        {
            var lootItems = new List<ILootItem>();

            for (var i = 0; i < RandomGenerationHelper.RandomNumber(1, 5); i++)
            {
                lootItems.Add(new LootItem
                {
                    GenerationParameters = null,
                    Id = RandomGenerationHelper.RandomNumber(100),
                    IsGuaranteed = false,
                    IsPossible = true,
                    IsUnique = false,
                    ItemsExcludedIfDropped = null,
                    Probability = RandomGenerationHelper.RandomNumber(1, 100)
                });
            }
            return lootItems;
        }
    }
}
