using System;
using System.Collections.Generic;
using System.Diagnostics;
using SWG.RandomDataGenerator.ItemData.ItemTypes;
using SWG.RandomDataGenerator.LootTableData;

namespace SWG.RandomDataGenerator
{
    public class ItemFactory
    {
        public IItem GetItem(ILootItem lootItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IItem> GetItems(IEnumerable<ILootItem> lootItems)
        {
            var droppedItems = new List<IItem>();

            foreach (var lootItem in lootItems)
            {
                droppedItems.Add(GetItem(lootItem));
            }

            return droppedItems;
        }
    }
}
