using SWG.RandomDataGenerator.ItemData.ItemTypes;
using SWG.RandomDataGenerator.LootTableData;
using System.Collections.Generic;
using System.Linq;

namespace SWG.RandomDataGenerator
{
    public class LootTableParser
    {
        private readonly ItemFactory _itemFactory = new ItemFactory();

        public IEnumerable<IItem> GetLoot(ILootTable lootTable)
        {
            var droppedLoot = new List<IItem>();

            var possibleLootGroups = lootTable.LootGroups
                .Where(g => g.IsPossible && CheckForHit(g.LootGroupRollProbability));

            foreach (var lootGroup in possibleLootGroups)
            {
                droppedLoot.AddRange(ProcessLootGroup(lootGroup));
            }

            return droppedLoot.Any() ? droppedLoot : Enumerable.Empty<IItem>();
        }

        public IEnumerable<IItem> ProcessLootGroup(ILootGroup lootGroup)
        {
            var droppedLoot = new List<IItem>();

            var possibleLootItems = GetPossibleLootItems(lootGroup);
            foreach (var lootItem in possibleLootItems.Where(lootItem => CheckForHit(lootItem.Probability) || lootItem.IsGuaranteed))
            {
                droppedLoot.Add(_itemFactory.GetItem(lootItem));
                possibleLootItems = CheckLootItemsForExclusion(lootItem.ItemsExcludedIfDropped, possibleLootItems);
            }

            return droppedLoot.Any() ? droppedLoot : Enumerable.Empty<IItem>();
        }

        public List<ILootItem> GetPossibleLootItems(ILootGroup lootGroup)
        {
            return lootGroup.LootItems.Where(g => g.IsPossible).ToList();
        }

        public List<ILootItem> GetGuaranteedItems(ILootGroup lootGroup)
        {
            return lootGroup.LootItems.Where(c => c.IsGuaranteed).ToList();
        }

        public List<ILootItem> CheckLootItemsForExclusion(List<int> excludedItems, List<ILootItem> possibleLootItems)
        {
            return possibleLootItems.Where(lootItem => !excludedItems.Contains(lootItem.Id)).ToList();
        }

        public bool CheckForHit(int probability)
        {
            return RandomGenerationHelper.RandomNumber(0, 10000) <= probability;
        }
    }
}
