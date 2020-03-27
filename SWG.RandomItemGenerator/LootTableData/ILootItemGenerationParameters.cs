using System.Collections.Generic;
using SWG.RandomDataGenerator.ItemData.ItemTypes;

namespace SWG.RandomDataGenerator.LootTableData
{
    public interface ILootItemGenerationParameters
    {
        List<ItemSlotType> PossibleItemSlotTypes { get; set; }
    }
}
