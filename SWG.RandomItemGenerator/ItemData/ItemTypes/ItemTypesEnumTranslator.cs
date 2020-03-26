using System;
using System.Collections.Generic;
using System.Text;
using SWG.RandomDataGenerator.LootTableData;

namespace SWG.RandomDataGenerator.ItemData.ItemTypes
{
    class ItemTypesEnumTranslator
    {
        public List<ItemType> Translate(ILootItem lootItem)
        {
            var itemTypeList = new List<ItemType>();


            return itemTypeList;
        }
    }

    enum ItemType
    {
        Currency,
        QuestItem,
        EquipableItem,
        CraftingComponent,
        Weapon,
        Armor,
        Jewelery
    }
}
