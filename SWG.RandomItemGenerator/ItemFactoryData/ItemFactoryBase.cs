using System;
using System.Collections.Generic;
using System.Text;
using SWG.RandomDataGenerator.ItemData.ItemTypes;
using SWG.RandomDataGenerator.LootTableData;

namespace SWG.RandomDataGenerator.ItemFactoryData
{
    abstract class ItemFactoryBase
    {
        public abstract IItem GetItem(ILootItem lootItem);
    }
}
