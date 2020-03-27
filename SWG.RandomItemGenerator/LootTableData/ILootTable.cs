using System.Collections.Generic;

namespace SWG.RandomDataGenerator.LootTableData
{
    public interface ILootTable
    {
        ILootTableGenerationParameters ItemGenerationParameters { get; set; }
        IEnumerable<ILootGroup> LootGroups { get; set; }
    }
}
