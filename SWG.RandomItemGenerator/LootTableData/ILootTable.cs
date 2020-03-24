using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomDataGenerator.LootTableData
{
    public interface ILootTable
    {
        ILootTableGenerationParameters ItemGenerationParameters { get; set; }
        IEnumerable<ILootGroup> LootGroups { get; set; }
    }
}
