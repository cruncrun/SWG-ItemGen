using System.Collections.Generic;
using SWG.RandomDataGenerator.ItemData.ItemTypes;

namespace SWG.RandomDataGenerator.LootTableData
{
    class LootItemGenerationParameters : ILootItemGenerationParameters
    {
        public List<ItemSlotType> PossibleItemSlotTypes { get; set; }
    }
}
