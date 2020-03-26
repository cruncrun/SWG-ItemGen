using System.Collections.Generic;
using System.Linq;
using SWG.RandomDataGenerator.ItemData.ItemTypes;
using SWG.RandomDataGenerator.ItemData.ItemTypes.EquipableItems;
using SWG.RandomDataGenerator.ItemData.ItemTypes.EquipableItems.Armors.ChestArmors;
using SWG.RandomDataGenerator.ItemData.ItemTypes.EquipableItems.Armors.HeadArmors;
using SWG.RandomDataGenerator.LootTableData;

namespace SWG.RandomDataGenerator
{
    public class ItemFactory
    {
        public IItem GetItem(ILootItem lootItem)
        {
            return lootItem.IsPredefined ? GetPredefinedItem(lootItem) : GetRandomItem(lootItem);
        }

        public IEnumerable<IItem> GetItems(IEnumerable<ILootItem> lootItems)
        {
            return lootItems.Select(GetItem).ToList();
        }

        private IItem GetRandomItem(ILootItem lootItem)
        {
            var gen = new RandomItemGenerator();


            throw new System.NotImplementedException();
        }

        private IItem GetPredefinedItem(ILootItem lootItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
