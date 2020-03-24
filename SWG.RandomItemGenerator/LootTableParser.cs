using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SWG.RandomDataGenerator.ItemData.ItemTypes;
using SWG.RandomDataGenerator.LootTableData;

namespace SWG.RandomDataGenerator
{
    public class LootTableParser
    {
        private readonly ItemFactory _itemFactory = new ItemFactory();

        public IEnumerable<IItem> GetLoot(ILootTable lootTable)
        {
            var droppedLoot = new List<IItem>();

            var possibleLootGroups = lootTable.LootGroups
                .Where(g => g.IsPossible && RandomGenerationHelper.RandomNumber(0, 10000) <= g.LootGroupRollProbability);

            foreach (var lootGroup in possibleLootGroups)
            {
                droppedLoot.AddRange(ProcessLootGroup(lootGroup));
            }

            return droppedLoot.Any() ? droppedLoot : Enumerable.Empty<IItem>();
        }

        public IEnumerable<IItem> ProcessLootGroup(ILootGroup lootGroup)
        {
            var droppedLoot = new List<IItem>();
            
            droppedLoot.AddRange(_itemFactory.GetItems(lootGroup.LootItems.Where(c => c.IsGuaranteed)));

            List<ILootItem> possibleLootItems = lootGroup.LootItems.Where(g => g.IsPossible && !g.IsGuaranteed).ToList();
            foreach (var lootItem in possibleLootItems)
            {
                if (RandomGenerationHelper.RandomNumber(0, 10000) <= lootItem.Probability)
                {
                    droppedLoot.Add(_itemFactory.GetItem(lootItem));
                    possibleLootItems = CheckLootItemsForExclusion(lootItem.ItemsExcludedIfDropped, possibleLootItems);
                }
            }

            return droppedLoot.Any() ? droppedLoot : Enumerable.Empty<IItem>();
        }

        public List<ILootItem> CheckLootItemsForExclusion(List<int> excludedItems, List<ILootItem> possibleLootItems)
        {
            return possibleLootItems.Where(lootItem => !excludedItems.Contains(lootItem.Id)).ToList();
        }
    }
}
